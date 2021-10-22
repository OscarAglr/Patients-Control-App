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

namespace HealtyALTF4.Designs.MedicosViews
{
    public partial class FrmMedicosViews : Form
    {
        MedicosController controller;
        public FrmMedicosViews()
        {
            InitializeComponent();
        }

        private void FrmMedicosViews_Load(object sender, EventArgs e)
        {
            controller = new MedicosController();
            dgvMedicos.DataSource = controller.ShowTables();
        }
    }
}
