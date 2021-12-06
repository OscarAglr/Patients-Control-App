using HealtyALTF4.Controllers;
using HealtyALTF4.Models;
using HealtyALTF4.Reports;
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
        UserModel u;
        FrmSystem fs;
        public FrmMedicoView(UserModel u, FrmSystem fs)
        {
            InitializeComponent();
            this.u = u;
            this.fs = fs;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMedicoView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
            if (u.Rol != "Gerente")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                button1.Enabled = false;
            }
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
                if (string.IsNullOrEmpty(txtNEmp.Text) || string.IsNullOrEmpty(txtNEsp.Text))
                {
                    MessageBox.Show("Falta rellenar algunos datos");
                    return;
                }
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
                if (string.IsNullOrEmpty(txtNEmp.Text) || string.IsNullOrEmpty(txtNEsp.Text))
                {
                    MessageBox.Show("Falta rellenar algunos datos");
                    return;
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedico.SelectedRows.Count > 0)
                {
                    int index = dgvMedico.CurrentCell.RowIndex;
                    index = int.Parse(dgvMedico.Rows[index].Cells[0].Value.ToString());
                    MedicosModel model = new MedicosModel
                    {
                        Id = index
                    };
                    if (MessageBox.Show("¿Está seguro de querer cambiar el estado del paciente con id " + model.Id.ToString() + "?",
                        "Confirmar cambio de estado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (control.ChangeState(model))
                        {
                            MessageBox.Show("Medico actualizado con éxito");
                            MostrarTablas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar al medico");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dgvMedico.DataSource = control.Search(textBox5.Text);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteMedico frmReporteMedico = new FrmReporteMedico();
                int i = dgvMedico.CurrentCell.RowIndex;
                string idmed = dgvMedico.Rows[i].Cells[0].Value.ToString();
                frmReporteMedico.textBox1.Text = idmed;
                fs.openChildForm(frmReporteMedico);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
