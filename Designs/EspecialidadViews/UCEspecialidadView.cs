using HealtyALTF4.Controllers;
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

namespace HealtyALTF4.Designs.EspecialidadViews
{
    public partial class UCEspecialidadView : UserControl
    {
        EspecialidadController control = new EspecialidadController();
        public UCEspecialidadView()
        {
            InitializeComponent();
        }

        private void UCEspecialidadView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas()
        {
            dgvEspecialidad.DataSource = control.ShowTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEspecialidad frmAddEspecialidad = new FrmAddEspecialidad(this);
            frmAddEspecialidad.ShowDialog();
            
        }
    }
}
