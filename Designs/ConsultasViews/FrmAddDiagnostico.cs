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
    public partial class FrmAddDiagnostico : Form
    {
        ConsultaModel consultaModel;
        
        public FrmAddDiagnostico(ConsultaModel consultaModel)
        {
            InitializeComponent();
            this.consultaModel = consultaModel;
        }

        private void FrmAddDiagnostico_Load(object sender, EventArgs e)
        {
            txtNoPaciente.Text = consultaModel.Id_med.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelectEnfermedad frmSelectEnfermedad = new FrmSelectEnfermedad();
            frmSelectEnfermedad.ShowDialog();
        }
    }
}
