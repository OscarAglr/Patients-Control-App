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
    public partial class AddMedico : UserControl
    {
        MedicosController mc = new MedicosController();
        public MedicosView mv { get; set; }
        public AddMedico()
        {
            InitializeComponent();
        }

        private void AddMedico_Load(object sender, EventArgs e)
        {
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
                MedicosModel mm = new MedicosModel
                {
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFNac.Value.Date,
                    Cedula = txtCedula.Text,
                    Especialidad = cbEspecialidad.Text
                };
                if (string.IsNullOrEmpty(mm.Primer_nombre))
                {
                    MessageBox.Show("El campo del primer nombre no puede estar vacío");
                    return;
                }
                else if (string.IsNullOrEmpty(mm.Primer_apellido))
                {
                    MessageBox.Show("El campo del primer apellido no puede estar vacío");
                    return;
                }
                if (mc.Create(mm))
                {
                    MessageBox.Show("El medico fue registrado con éxito");
                    mv.MostrarTablas();
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

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
