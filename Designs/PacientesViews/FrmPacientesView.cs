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
    public partial class FrmPacientesView : Form
    {
        static PacientesController pc;
        public FrmPacientesView()
        {
            InitializeComponent();
        }

        private void FrmPacientesView_Load(object sender, EventArgs e)
        {
            pc = new PacientesController();
            dgvPacientes.DataSource = pc.ShowTables();
        }
    }
}
