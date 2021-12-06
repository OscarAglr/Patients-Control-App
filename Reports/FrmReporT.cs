using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealtyALTF4.Reports
{
    public partial class FrmReporT : Form
    {
        public FrmReporT()
        {
            InitializeComponent();
        }

        private void FrmReporT_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReportePaciente' Puede moverla o quitarla según sea necesario.
            this.ReportePacienteTableAdapter.Fill(this.DataSet1.ReportePaciente, int.Parse(txtNumerito.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteMedico' Puede moverla o quitarla según sea necesario.
            this.ReporteMedicoTableAdapter.Fill(this.DataSet1.ReporteMedico, int.Parse(txtNumerito.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteDiagnostico' Puede moverla o quitarla según sea necesario.
            this.ReporteDiagnosticoTableAdapter.Fill(this.DataSet1.ReporteDiagnostico, int.Parse(txtNumerito.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteEnfermedades' Puede moverla o quitarla según sea necesario.
            this.ReporteEnfermedadesTableAdapter.Fill(this.DataSet1.ReporteEnfermedades, int.Parse(txtNumerito.Text));

            this.reportViewer1.RefreshReport();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
