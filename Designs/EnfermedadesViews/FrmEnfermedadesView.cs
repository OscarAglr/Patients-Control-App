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

namespace HealtyALTF4.Designs.EnfermedadesViews
{
    public partial class FrmEnfermedadesView : Form
    {
        EnfermedadController control = new EnfermedadController();
        public FrmEnfermedadesView()
        {
            InitializeComponent();
        }

        private void FrmEnfermedadesView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }
        public void MostrarTablas()
        {
            dgvEnfermedad.DataSource = control.ShowTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEnfermedad.SelectedRows.Count > 0)
            {
                int index = dgvEnfermedad.CurrentCell.RowIndex;
                tbIDEsp.Text = dgvEnfermedad.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvEnfermedad.Rows[index].Cells[1].Value.ToString();
                rtbDesc.Text = dgvEnfermedad.Rows[index].Cells[2].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnMod.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EnfermedadModel model = new EnfermedadModel
                {
                    Nombre = tbName.Text,
                    Desc = rtbDesc.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show(model.Nombre + " guardado con éxito");
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    MostrarTablas();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                EnfermedadModel model = new EnfermedadModel
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
                    tbName.Text = "";
                    rtbDesc.Text = "";
                    tbIDEsp.Text = "";
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
    }
}
