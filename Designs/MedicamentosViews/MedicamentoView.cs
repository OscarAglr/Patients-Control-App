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

namespace HealtyALTF4.Designs.MedicamentosViews
{
    public partial class MedicamentoView : UserControl
    {
        static MedicamentosControllers controllers;
        public MedicamentoView()
        {
            InitializeComponent();
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            controllers = new MedicamentosControllers();
            dgvMedicamentos.DataSource = controllers.ShowTables();
        }
    }
}
