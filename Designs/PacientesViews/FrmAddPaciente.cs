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
    public partial class FrmAddPaciente : Form
    {
        PacientesController pc = new PacientesController();
        public PacienteView pv { get; set; }
        public FrmAddPaciente()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesModel pm = new PacientesModel
                {
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFecha.Value.Date,
                    Cedula = txtCedula.Text
                };
                if (string.IsNullOrEmpty(pm.Primer_nombre))
                {
                    MessageBox.Show("El campo del primer nombre no puede estar vacío");
                    return;
                }
                else if (string.IsNullOrEmpty(pm.Primer_apellido))
                {
                    MessageBox.Show("El campo del primer apellido no puede estar vacío");
                    return;
                }
                if (pc.Create(pm))
                {
                    MessageBox.Show("El paciente fue registrado con éxito");
                    pv.MostrarTablas();
                } else
                {
                    MessageBox.Show("No se pudo registrar al paciente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
