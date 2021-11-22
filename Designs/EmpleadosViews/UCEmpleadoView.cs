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

namespace HealtyALTF4.Designs.EmpleadosViews
{
    public partial class UCEmpleadoView : UserControl
    {
        EmpleadosController control = new EmpleadosController();
        public UCEmpleadoView()
        {
            InitializeComponent();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddEmpleado frmAddEmpleado = new FrmAddEmpleado(this);
            frmAddEmpleado.ShowDialog();
        }

        private void UCEmpleadoView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas()
        {
            dgvEmpleado.DataSource = control.ShowTables();
        }
    }
}
