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

namespace HealtyALTF4.Designs.ConsultasViews
{
    public partial class FrmConsultaView : Form
    {
        CitaController control = new CitaController();
        public FrmConsultaView()
        {
            InitializeComponent();
        }

        private void FrmConsultaView_Load(object sender, EventArgs e)
        {
            dgvCitas.DataSource = control.ShowTables();
        }
    }
}
