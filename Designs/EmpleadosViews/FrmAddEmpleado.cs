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

namespace HealtyALTF4.Designs.EmpleadosViews
{
    public partial class FrmAddEmpleado : Form
    {
        EmpleadosController control = new EmpleadosController();
        UCEmpleadoView view;
        public FrmAddEmpleado(UCEmpleadoView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmAddEmpleado_Load(object sender, EventArgs e)
        {
            cbPuesto.Items.Add("Administrador");
            cbPuesto.Items.Add("Médico");
            cbPuesto.Items.Add("Enfermera");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmpleadoModel model = new EmpleadoModel();
            model.Primer_nombre = txtPN.Text;
            model.Segundo_nombre = txtSN.Text;
            model.Primer_apellido = txtPA.Text;
            model.Segundo_apellido = txtSA.Text;
            model.Fecha_nac = dtFN.Value.Date;
            model.Cedula = txtCed.Text;
            model.Puesto = cbPuesto.Text;
            if (control.Create(model))
            {
                MessageBox.Show("¡Empleado añadido con éxito!");
                view.MostrarTablas();
            }
            else
            {
                MessageBox.Show("¡No se pudo añadir al empleado!");
            }
            
        }
    }
}
