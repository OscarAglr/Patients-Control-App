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
    public partial class FrmReportePaciente : Form
    {
        public FrmReportePaciente()
        {
            InitializeComponent();
        }

        private void FrmReportePaciente_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Paciente21' Puede moverla o quitarla según sea necesario.
            this.Paciente21TableAdapter.Fill(this.DataSet1.Paciente21,int.Parse(textBox1.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Paciente1' Puede moverla o quitarla según sea necesario.
            this.Paciente1TableAdapter.Fill(this.DataSet1.Paciente1, int.Parse(textBox1.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Paciente31' Puede moverla o quitarla según sea necesario.
            this.Paciente31TableAdapter.Fill(this.DataSet1.Paciente31, int.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
