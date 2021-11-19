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
    public partial class FrmSelectEnfermedad : Form
    {
        EnfermedadController ec = new EnfermedadController();
        public FrmSelectEnfermedad()
        {
            InitializeComponent();
        }

        private void dgvSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelect.DataSource = ec.ShowTables();
        }
    }
}
