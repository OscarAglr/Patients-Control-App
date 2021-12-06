using HealtyALTF4.Controllers;
using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealtyALTF4.Designs.EspecialidadViews
{
    public partial class FrmEspecialidadView : Form
    {
        UserModel u;
        EspecialidadController control = new EspecialidadController();
        public FrmEspecialidadView(UserModel u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void FrmEspecialidadView_Load(object sender, EventArgs e)
        {

            MostrarTablas();
            if (u.Rol != "Registrador")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        public void MostrarTablas()
        {
            dgvEspecialidad.DataSource = control.ShowTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            tbName.Text = "";
            rtbDesc.Text = "";
            tbIDEsp.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("El nombre de la especialidad no puede ir vacía");
                    return;
                }
                EspecialidadModel model = new EspecialidadModel
                {
                    Nombre = tbName.Text,
                    Desc = rtbDesc.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Medicamento guardado con éxito");
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    MostrarTablas();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el medicamento");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedRows.Count > 0)
            {
                int index = dgvEspecialidad.CurrentCell.RowIndex;
                tbIDEsp.Text = dgvEspecialidad.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvEspecialidad.Rows[index].Cells[1].Value.ToString();
                rtbDesc.Text = dgvEspecialidad.Rows[index].Cells[2].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnMod.Enabled = true;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("El nombre de la especialidad no puede ir vacía");
                    return;
                }
                EspecialidadModel model = new EspecialidadModel
                {
                    Id = int.Parse(tbIDEsp.Text),
                    Nombre = tbName.Text,
                    Desc = rtbDesc.Text
                };
                if (control.Update(model) != -1)
                {
                    MessageBox.Show("Registro modificado con éxito");
                    btnMod.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    MostrarTablas();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEspecialidad.DataSource = control.Search(tbSearch.Text);
        }
    }
}
