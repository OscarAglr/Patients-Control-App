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

namespace HealtyALTF4.Designs.CitasViews
{
    public partial class FrmCitaView : Form
    {
        CitaController control = new CitaController();
        public FrmCitaView()
        {
            InitializeComponent();
        }

        private void btnSearchPaciente_Click(object sender, EventArgs e)
        {
            FrmBuscarPacienteCita frmBuscar = new FrmBuscarPacienteCita(this);
            frmBuscar.ShowDialog();
        }

        private void btnSearchMedico_Click(object sender, EventArgs e)
        {
            FrmBuscarMedicoCita frmBuscar = new FrmBuscarMedicoCita(this);
            frmBuscar.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CitaModel model = new CitaModel
                {
                    N_med = int.Parse(txtIDM.Text),
                    N_pac = int.Parse(txtIDP.Text),
                    Fecha = dtFecha.Value.Date,
                    Hora = dtHora.Value.TimeOfDay,
                    Motivo = rtbMotivos.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Los datos de la cita han sido guardados");
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los datos de las citas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
