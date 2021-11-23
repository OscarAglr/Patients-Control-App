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

namespace HealtyALTF4.Designs.MedicosViews
{
    public partial class FrmMedicoView : Form
    {
        MedicosController control = new MedicosController();
        public FrmMedicoView()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMedicoView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas ()
        {
            dgvMedico.DataSource = control.ShowTables();
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchEmpleado_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleado frmBuscarEmpleado = new FrmBuscarEmpleado(this);
            frmBuscarEmpleado.ShowDialog();
        }

        private void btnSearchEspecialidad_Click(object sender, EventArgs e)
        {
            FrmBuscarEspecialidad frmBuscarEspecialidad = new FrmBuscarEspecialidad(this);
            frmBuscarEspecialidad.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            tbNCons.Text = "";
            txtNEmp.Text = "";
            txtNombreEmp.Text = "";
            txtNEsp.Text = "";
            txtNombreEsp.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MedicosModel model = new MedicosModel
                {
                    Id_med = int.Parse(txtNEmp.Text),
                    Id_esp = int.Parse(txtNEsp.Text)
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Médico guardado con éxito");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMedico.SelectedRows.Count > 0)
            {
                int index = dgvMedico.CurrentCell.RowIndex;
                tbNCons.Text = dgvMedico.Rows[index].Cells[0].Value.ToString();
                txtNEmp.Text = dgvMedico.Rows[index].Cells[1].Value.ToString();
                txtNombreEmp.Text = dgvMedico.Rows[index].Cells[2].Value.ToString();
                txtNEsp.Text = dgvMedico.Rows[index].Cells[3].Value.ToString();
                txtNombreEsp.Text = dgvMedico.Rows[index].Cells[4].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnMod.Enabled = true;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                MedicosModel model = new MedicosModel
                {
                    Id = int.Parse(tbNCons.Text),
                    Id_med = int.Parse(txtNEmp.Text),
                    Id_esp = int.Parse(txtNEsp.Text)
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
    }
}
