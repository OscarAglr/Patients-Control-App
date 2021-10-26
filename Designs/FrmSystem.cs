using HealtyALTF4.Designs.ConsultasViews;
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
            Designs.PacientesViews.PacienteView control = new PacienteView();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Designs.MedicosViews.MedicosView control = new MedicosView();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            Designs.MedicamentosViews.MedicamentoView control = new MedicamentoView();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Designs.ConsultasViews.ConsultasView control = new Designs.ConsultasViews.ConsultasView();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Designs.UsersViews.UserView control = new UsersViews.UserView();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
    }
}
