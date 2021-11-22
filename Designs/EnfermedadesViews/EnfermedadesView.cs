using HealtyALTF4.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealtyALTF4.Designs.EnfermedadesViews
{
    public partial class EnfermedadesView : UserControl
    {
        EnfermedadController control = new EnfermedadController();
        public EnfermedadesView()
        {
            InitializeComponent();
        }

        private void EnfermedadesView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
            
        }

        public void MostrarTablas()
        {
            dgvEnfermedad.DataSource = control.ShowTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddEnfermedad frmAddEnfermedad = new FrmAddEnfermedad(this);
            frmAddEnfermedad.ShowDialog();
        }
    }
}
