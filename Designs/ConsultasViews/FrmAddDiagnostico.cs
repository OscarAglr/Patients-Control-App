using HealtyALTF4.Models;
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
    public partial class FrmAddDiagnostico : Form
    {
        ConsultaModel consultaModel;
        public FrmAddDiagnostico(ConsultaModel consultaModel)
        {
            InitializeComponent();
            this.consultaModel = consultaModel;
        }
    }
}
