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

namespace HealtyALTF4.Designs.PacientesViews
{
    public partial class PacienteView : UserControl
    {
        static PacientesController pc;
        public PacienteView()
        {
            InitializeComponent();
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            pc = new PacientesController();
            dgvPacientes.DataSource = pc.ShowTables();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
