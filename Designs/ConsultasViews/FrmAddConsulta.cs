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

namespace HealtyALTF4.Designs.ConsultasViews
{
    public partial class FrmAddConsulta : Form
    {
        public PacientesModel pacientesModel = new PacientesModel();
        public MedicosModel medicosModel = new MedicosModel();
        public FrmAddConsulta()
        {
            InitializeComponent();
        }

        private void FrmAddConsulta_Load(object sender, EventArgs e)
        {

        }

        public void RellenarDatosPacientes(int id, string nombre)
        {
            txtNoPaciente.Text = id.ToString();
            txtPacienteNombre.Text = nombre;
        }

        public void RellenarDatosMedicos(int id, string nombre)
        {
            txtNoMedico.Text = id.ToString();
            txtMedicoNombre.Text = nombre;
        }
    }
}
