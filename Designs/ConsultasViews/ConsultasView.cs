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
    public partial class ConsultasView : UserControl
    {
        ConsultasController consultasController;
        FrmSystem fs;
        public ConsultasView()
        {
            InitializeComponent();
        }
        public ConsultasView(FrmSystem fs)
        {
            InitializeComponent();
            this.fs = fs;
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            consultasController = new ConsultasController();
            dgvConsultas.DataSource = consultasController.ShowTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddConsulta fac = new FrmAddConsulta(this.fs);
            openChildForm(fac);
        }

        private Form form = null;
        private void openChildForm(Form childForm)
        {
            if (form != null)
            {
                form.Close();
            }
            form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            fs.panelControl.Controls.Add(childForm);
            fs.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
