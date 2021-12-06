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

namespace HealtyALTF4.Designs.EmpleadosViews
{
    public partial class FrmEmpleadoView : Form
    {
        UserModel u;
        EmpleadosController control = new EmpleadosController();
        public FrmEmpleadoView(UserModel u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void FrmEmpleadoView_Load(object sender, EventArgs e)
        {
            cbPuesto.Items.Add("Administrador");
            cbPuesto.Items.Add("Médico");
            cbPuesto.Items.Add("Enfermera");
            cbPuesto.Items.Add("Farmaceutico");
            cbPuesto.Items.Add("Gerente");
            cbPuesto.Items.Add("Secretaria");
            cbPuesto.Items.Add("Otros");
            MostrarTablas();
            dtFNac.MaxDate = DateTime.Now;
            if (u.Rol != "Gerente")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnChangeState.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void MostrarTablas()
        {
            dgvEmpleados.DataSource = control.ShowTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPNom.Text) || string.IsNullOrEmpty(txtPApe.Text) || string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Falta rellenar algunos datos");
                    return;
                }
                CValidacionCedula validar = new CValidacionCedula();
                if (validar.Validar(txtCedula.Text) != true)
                {
                    MessageBox.Show("La cedula no es valida");
                    return;
                }
                EmpleadoModel model = new EmpleadoModel
                {
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Puesto = cbPuesto.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Empleado agregado con éxito");
                    MostrarTablas();
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
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
            try
            {
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    int index = dgvEmpleados.CurrentCell.RowIndex;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnMod.Enabled = true;
                    txtID.Text = dgvEmpleados.Rows[index].Cells[0].Value.ToString();
                    txtPNom.Text = dgvEmpleados.Rows[index].Cells[1].Value.ToString();
                    try { txtSNom.Text = dgvEmpleados.Rows[index].Cells[2].Value.ToString(); } catch { }
                    txtPApe.Text = dgvEmpleados.Rows[index].Cells[3].Value.ToString();
                    try { txtSApe.Text = dgvEmpleados.Rows[index].Cells[4].Value.ToString(); } catch { }
                    dtFNac.Value = DateTime.Parse(dgvEmpleados.Rows[index].Cells[5].Value.ToString()).Date;
                    txtCedula.Text = dgvEmpleados.Rows[index].Cells[6].Value.ToString();
                    cbPuesto.Text = dgvEmpleados.Rows[index].Cells[7].Value.ToString();
                }
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnMod.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPNom.Text) || string.IsNullOrEmpty(txtPApe.Text) || string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Falta rellenar algunos datos");
                    return;
                }
                CValidacionCedula validar = new CValidacionCedula();
                if (validar.Validar(txtCedula.Text) != true)
                {
                    MessageBox.Show("La cedula no es valida");
                    return;
                }
                EmpleadoModel model = new EmpleadoModel
                {
                    Id = int.Parse(txtID.Text),
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Puesto = cbPuesto.Text
                };
                if (control.Update(model) != -1)
                {
                    MessageBox.Show("Empleado actualizado con éxito");
                    MostrarTablas();
                    btnAdd.Enabled = true;
                    btnMod.Enabled = false;
                    btnUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el empleado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = control.Search(textBox1.Text);
        }
    }
}
