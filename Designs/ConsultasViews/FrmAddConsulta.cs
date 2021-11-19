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
        FrmSystem fs;
        public FrmAddConsulta()
        {
            InitializeComponent();
        }
        public FrmAddConsulta(FrmSystem fs)
        {
            InitializeComponent();
            this.fs = fs;
        }

        private void FrmAddConsulta_Load(object sender, EventArgs e)
        {
            dtFechaConsulta.MaxDate = DateTime.Today;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelectPaciente frmSelectPaciente = new FrmSelectPaciente(this);
            frmSelectPaciente.ShowDialog();
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            FrmSelectMedico frmSelectMedico = new FrmSelectMedico(this);
            frmSelectMedico.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ConsultaModel cm = new ConsultaModel();
            cm.Id_pac = int.Parse(txtNoPaciente.Text);
            cm.Id_med = int.Parse(txtNoMedico.Text);
            FrmAddDiagnostico fad = new FrmAddDiagnostico(cm);
            fs.new
        }
    }
}
