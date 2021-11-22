using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealtyALTF4.Controllers;
using HealtyALTF4.Models;

namespace HealtyALTF4.Designs.EspecialidadViews
{
    public partial class FrmAddEspecialidad : Form
    {
        UCEspecialidadView view;
        EspecialidadController control = new EspecialidadController();
        public FrmAddEspecialidad(UCEspecialidadView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EspecialidadModel model = new EspecialidadModel();
            model.Nombre = tbName.Text;
            model.Desc = rtbDesc.Text;
            if (control.Create(model))
            {
                MessageBox.Show(model.Nombre + " añadido con éxito!");
                view.MostrarTablas();
            }
            else
            {
                MessageBox.Show("¡No se pudo añadir el registro!");
            }
        }
    }
}
