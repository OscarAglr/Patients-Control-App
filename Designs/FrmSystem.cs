using HealtyALTF4.Designs.MedicamentosViews;
using HealtyALTF4.Designs.MedicosViews;
using HealtyALTF4.Designs.PacientesViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealtyALTF4.Designs
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientesView pacientesView = new FrmPacientesView();
            pacientesView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMedicosViews medicosViews = new FrmMedicosViews();
            medicosViews.Show();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            FrmMedicamentosViews medicamentosViews = new FrmMedicamentosViews();
            medicamentosViews.Show();
        }
    }
}
