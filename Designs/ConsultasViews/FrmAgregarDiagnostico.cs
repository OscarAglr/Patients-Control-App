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
    public partial class FrmAgregarDiagnostico : Form
    {
        FrmConsultaOperacion op;
        public FrmAgregarDiagnostico(FrmConsultaOperacion op)
        {
            InitializeComponent();
            this.op = op;
        }

        private void FrmAgregarDiagnostico_Load(object sender, EventArgs e)
        {

        }
    }
}
