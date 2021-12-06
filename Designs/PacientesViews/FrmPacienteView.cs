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
using HealtyALTF4.Reports;

namespace HealtyALTF4.Designs.PacientesViews
{
    public partial class FrmPacienteView : Form
    {
        PacientesController control = new PacientesController();
        UserModel u;
        FrmSystem fs;
        public FrmPacienteView(UserModel u, FrmSystem fs)
        {
            InitializeComponent();
            this.u = u;
            this.fs = fs;
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
                if (string.IsNullOrEmpty(txtPNom.Text) || string.IsNullOrEmpty(txtPApe.Text)) 
                {
                    MessageBox.Show("Los datos del primer nombre y del primer apellido no pueden estar vacíos");
                    return;
                }
                CValidacionCedula validar = new CValidacionCedula();
                // Si el campo de cédula está vacío se toma como la persona no tiene cédula
                if (txtCedula.Text != "")
                {
                    if (validar.Validar(txtCedula.Text) != true)
                    {
                        MessageBox.Show("La cedula no es valida");
                        return;
                    }
                }
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
            if (u.Rol != "Secretaria")
            {
                btnAdd.Enabled = false;
                btnChangeState.Enabled = false;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
            }
            if (u.Rol != "Medico")
            {
                btnReporte.Enabled = false;
            }
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
                if (string.IsNullOrEmpty(txtPNom.Text) || string.IsNullOrEmpty(txtPApe.Text))
                {
                    MessageBox.Show("Los datos del primer nombre y del primer apellido no pueden estar vacíos");
                    return;
                }
                CValidacionCedula validar = new CValidacionCedula();
                if (txtCedula.Text != "")
                {
                    if (validar.Validar(txtCedula.Text) != true)
                    {
                        MessageBox.Show("La cedula no es valida");
                        return;
                    }
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = control.Search(textBox1.Text);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportePaciente frmReportePaciente = new FrmReportePaciente();
                int i = dgvPacientes.CurrentCell.RowIndex;
                string idpac = dgvPacientes.Rows[i].Cells[0].Value.ToString();
                frmReportePaciente.textBox1.Text = idpac;
                fs.openChildForm(frmReportePaciente);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
