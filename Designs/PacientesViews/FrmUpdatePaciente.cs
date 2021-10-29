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
    public partial class FrmUpdatePaciente : Form
    {
        public PacientesModel p { get; set; }
        PacientesController pc = new PacientesController();
        public PacienteView pv { get; set; }
        public FrmUpdatePaciente()
        {
            InitializeComponent();
        }

        private void FrmUpdatePaciente_Load(object sender, EventArgs e)
        {
            txtID.Text = p.Id.ToString();
            txtPNom.Text = p.Primer_nombre;
            txtSNom.Text = p.Segundo_nombre;
            txtPApe.Text = p.Primer_apellido;
            txtSApe.Text = p.Segundo_apellido;
            dtFecha.Value = p.Fecha_nac;
            txtCedula.Text = p.Cedula;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesModel p_new = new PacientesModel
                {
                    Id = p.Id,
                    Primer_nombre = txtPNom.Text,
                    Segundo_nombre = txtSNom.Text,
                    Primer_apellido = txtPApe.Text,
                    Segundo_apellido = txtSApe.Text,
                    Fecha_nac = dtFecha.Value.Date,
                    Cedula = txtCedula.Text
                };
                if (string.IsNullOrEmpty(p_new.Primer_nombre))
                {
                    MessageBox.Show("El campo del primer nombre no puede estar vacío");
                    return;
                }
                else if (string.IsNullOrEmpty(p_new.Primer_apellido))
                {
                    MessageBox.Show("El campo del primer apellido no puede estar vacío");
                    return;
                }
                if (pc.Update(p_new) == -1)
                {
                    MessageBox.Show("Error al actualizar");
                    return;
                }
                else
                {
                    pc.Update(p_new);
                    MessageBox.Show("Paciente actualizado con éxito");
                    pv.MostrarTablas();
                    return;
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
    }
}
