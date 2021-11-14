using HealtyALTF4.Controllers;
using HealtyALTF4.Designs.MedicosViews;
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
    public partial class UpdateMedico : UserControl
    {
        public MedicosModel m { get; set; }
        MedicosController mc = new MedicosController();
        public MedicosView mv { get; set; }
        public UpdateMedico()
        {
            InitializeComponent();
        }

        private void UpdateMedico_Load(object sender, EventArgs e)
        {
            txtID.Text = m.Id.ToString();
            txtPNom.Text = m.Primer_nombre;
            txtSNom.Text = m.Segundo_nombre;
            txtPApe.Text = m.Primer_apellido;
            txtSApe.Text = m.Segundo_apellido;
            dtFNac.Value = m.Fecha_nac;
            txtCedula.Text = m.Cedula;
            cbEspecialidad.Text = m.Especialidad;
            cbEspecialidad.Items.Add("Anestesiología");
            cbEspecialidad.Items.Add("Anatomía patológica");
            cbEspecialidad.Items.Add("Cardiología");
            cbEspecialidad.Items.Add("Cirugía pediátrica");
            cbEspecialidad.Items.Add("Cirugía general");
            cbEspecialidad.Items.Add("Dermatología");
            cbEspecialidad.Items.Add("Ginecología");
            cbEspecialidad.Items.Add("Hematología");
            cbEspecialidad.Items.Add("Infectología");
            cbEspecialidad.Items.Add("Medicina de rehabilitación");
            cbEspecialidad.Items.Add("Nefrología");
            cbEspecialidad.Items.Add("Neumología");
            cbEspecialidad.Items.Add("Oftalmología");
            cbEspecialidad.Items.Add("Pediatría");
            cbEspecialidad.Items.Add("Psiquiatría");
            cbEspecialidad.Items.Add("Radiología");
            cbEspecialidad.Items.Add("Urología");
            cbEspecialidad.Items.Add("Otro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicosModel m_new = new MedicosModel
                {
                    Id = m.Id,
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Especialidad = cbEspecialidad.Text
                };
                if (string.IsNullOrEmpty(m_new.Primer_nombre))
                {
                    MessageBox.Show("El campo del primer nombre no puede estar vacío");
                    return;
                }
                else if (string.IsNullOrEmpty(m_new.Primer_apellido))
                {
                    MessageBox.Show("El campo del primer apellido no puede estar vacío");
                    return;
                }
                if (mc.Update(m_new) == -1)
                {
                    MessageBox.Show("Error al actualizar");
                    return;
                }
                else
                {
                    mc.Update(m_new);
                    MessageBox.Show("Paciente actualizado con éxito");
                    mv.MostrarTablas();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
