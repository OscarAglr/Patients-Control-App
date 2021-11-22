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

namespace HealtyALTF4.Designs.EnfermedadesViews
{
    public partial class FrmAddEnfermedad : Form
    {
        EnfermedadController controller = new EnfermedadController();
        EnfermedadesView ev;
        public FrmAddEnfermedad(EnfermedadesView ev)
        {
            InitializeComponent();
            this.ev = ev;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string desc = rtbDesc.Text;
            EnfermedadModel model = new EnfermedadModel();
            model.Nombre = name;
            model.Desc = desc;
            if (controller.Create(model))
            {
                MessageBox.Show("¡" + name + " agregado con éxito!");
                ev.MostrarTablas();
                this.Close();
            }
            else
            {
                MessageBox.Show("¡Hubo un error al agregar el registro!");
                tbName.Text = "";
                rtbDesc.Text = "";
            }
        }
    }
}
