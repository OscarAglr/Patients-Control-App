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
    public partial class FrmConsultasViews : Form
    {
        ConsultasController consultasController;
        public FrmConsultasViews()
        {
            InitializeComponent();
        }

        private void FrmConsultasViews_Load(object sender, EventArgs e)
        {
            consultasController = new ConsultasController();
            dgvConsultas.DataSource = consultasController.ShowTables();
        }
    }
}
