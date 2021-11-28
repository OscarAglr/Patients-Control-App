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
        EmpleadosController control = new EmpleadosController();
        public FrmEmpleadoView()
        {
            InitializeComponent();
        }

        private void FrmEmpleadoView_Load(object sender, EventArgs e)
        {
            cbPuesto.Items.Add("Administrador");
            cbPuesto.Items.Add("Médico");
            cbPuesto.Items.Add("Enfermera");
            MostrarTablas();
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
    }
}
