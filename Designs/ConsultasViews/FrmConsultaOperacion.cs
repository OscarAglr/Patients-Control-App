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
    public partial class FrmConsultaOperacion : Form
    {
        FrmConsultaView view;
        public FrmConsultaOperacion(FrmConsultaView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmConsultaOperacion_Load(object sender, EventArgs e)
        {

        }
    }
}
