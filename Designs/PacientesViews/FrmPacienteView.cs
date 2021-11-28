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

namespace HealtyALTF4.Designs.PacientesViews
{
    public partial class FrmPacienteView : Form
    {
        PacientesController control = new PacientesController();
        public FrmPacienteView()
        {
            InitializeComponent();
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
                PacientesModel model = new PacientesModel
                {
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Altura = int.Parse(nudAltura.Value.ToString()),
                    Peso = int.Parse(nudPeso.Value.ToString()),
                    Tiposangre = cbTipoSangre.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Paciente agregado con éxito");
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

        private void FrmPacienteView_Load(object sender, EventArgs e)
        {
            cbTipoSangre.Items.Add("A+");
            cbTipoSangre.Items.Add("A-");
            cbTipoSangre.Items.Add("B+");
            cbTipoSangre.Items.Add("B-");
            cbTipoSangre.Items.Add("O+");
            cbTipoSangre.Items.Add("O-");
            cbTipoSangre.Items.Add("AB+");
            cbTipoSangre.Items.Add("AB-");
            cbTipoSangre.Items.Add("Desconocido");
            dgvPacientes.DataSource = control.ShowTables();
            dtFNac.MaxDate = DateTime.Now;
        }

        private void MostrarTablas()
        {
            dgvPacientes.DataSource = control.ShowTables();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    int index = dgvPacientes.CurrentCell.RowIndex;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnMod.Enabled = true;
                    txtID.Text = dgvPacientes.Rows[index].Cells[0].Value.ToString();
                    txtPNom.Text = dgvPacientes.Rows[index].Cells[1].Value.ToString();
                    // Los try catch son para los valores nulos, evita que sucedan errores al pasarlos desde sql a c# dspojsdioadsja
                    try
                    {
                        txtSNom.Text = dgvPacientes.Rows[index].Cells[2].Value.ToString();
                    }
                    catch { }
                    
                    txtPApe.Text = dgvPacientes.Rows[index].Cells[3].Value.ToString();
                    try
                    {
                        txtSApe.Text = dgvPacientes.Rows[index].Cells[4].Value.ToString();
                    }
                    catch{}
                    try
                    {
                        nudAltura.Value = int.Parse(dgvPacientes.Rows[index].Cells[5].Value.ToString());
                    }
                    catch { }
                    try { nudPeso.Value = int.Parse(dgvPacientes.Rows[index].Cells[6].Value.ToString()); } catch { }
                    try { cbTipoSangre.Text = dgvPacientes.Rows[index].Cells[7].Value.ToString(); } catch { }
                    try { txtCedula.Text = dgvPacientes.Rows[index].Cells[9].Value.ToString(); } catch { }
                    dtFNac.Value = DateTime.Parse(dgvPacientes.Rows[index].Cells[8].Value.ToString()).Date;
                    
                }
            }
            catch
            {
            }
            
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesModel model = new PacientesModel
                {
                    Id = int.Parse(txtID.Text),
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Altura = int.Parse(nudAltura.Value.ToString()),
                    Peso = int.Parse(nudPeso.Value.ToString()),
                    Tiposangre = cbTipoSangre.Text
                };
                if (control.Update(model) != -1)
                {
                    MessageBox.Show("Paciente actualizado con éxito");
                    MostrarTablas();
                    btnAdd.Enabled = true;
                    btnMod.Enabled = false;
                    btnUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnMod.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    int index = dgvPacientes.CurrentCell.RowIndex;
                    index = int.Parse(dgvPacientes.Rows[index].Cells[0].Value.ToString());
                    PacientesModel model = new PacientesModel
                    {
                        Id = index
                    };
                    if (MessageBox.Show("¿Está seguro de querer cambiar el estado del paciente con id " + model.Id.ToString() + "?", 
                        "Confirmar cambio de estado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (control.ChangeState(model))
                        {
                            MessageBox.Show("Paciente actualizado con éxito");
                            MostrarTablas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar al paciente");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
