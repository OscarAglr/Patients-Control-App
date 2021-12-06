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
    public partial class FrmReporteMedico : Form
    {
        public FrmReporteMedico()
        {
            InitializeComponent();
        }

        private void FrmReporteMedico_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Medico2' Puede moverla o quitarla según sea necesario.
            this.Medico2TableAdapter.Fill(this.DataSet1.Medico2,int.Parse(textBox1.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.MedicoCo' Puede moverla o quitarla según sea necesario.
            this.MedicoCoTableAdapter.Fill(this.DataSet1.MedicoCo, int.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
