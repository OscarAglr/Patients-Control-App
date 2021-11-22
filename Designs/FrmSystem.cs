using HealtyALTF4.Designs.ConsultasViews;
using HealtyALTF4.Designs.MedicamentosViews;
using HealtyALTF4.Designs.MedicosViews;
using HealtyALTF4.Designs.PacientesViews;
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

namespace HealtyALTF4.Designs
{
    public partial class FrmSystem : Form
    {
        Login login;
        UserModel user;
        public FrmSystem()
        {
            InitializeComponent();
            MenuDesing();
        }
        public FrmSystem(Login login, UserModel user)
        {
            InitializeComponent();
            MenuDesing();
            this.login = login;
            this.user = user;
        }

        //Con este método oculto los paneles no los borren UnU
        private void MenuDesing() 
        {
            subMenuCatalogo.Visible = false;
            subMenuOperaciones.Visible = false;
            subMenuReporte.Visible = false;
            subMenuSeguridad.Visible = false;
        }
        private void HideMenu() 
        {
            if (subMenuCatalogo.Visible==true)
                subMenuCatalogo.Visible = false;
            if (subMenuOperaciones.Visible == true)
                subMenuOperaciones.Visible = false;
            if (subMenuReporte.Visible == true)
                subMenuReporte.Visible = false;
            if (subMenuSeguridad.Visible == true)
                subMenuSeguridad.Visible = false;
        }
        private void ShowMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                HideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ShowMenu(subMenuCatalogo);
        }

        private void btnPacientes_Click_1(object sender, EventArgs e)
        {
            Designs.PacientesViews.PacienteView control = new PacienteView(this.panelControl);
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Designs.MedicosViews.MedicosView control = new MedicosView(this.panelControl);
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Designs.ConsultasViews.ConsultasView control = new Designs.ConsultasViews.ConsultasView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void btnMedicamentos_Click_1(object sender, EventArgs e)
        {
            Designs.MedicamentosViews.MedicamentoView control = new MedicamentoView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Designs.UsersViews.UserView control = new UsersViews.UserView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login.Show();
            login.txtUser.Focus();
            Close();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            ShowMenu(subMenuOperaciones);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMenu(subMenuReporte);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ShowMenu(subMenuSeguridad);
        }

        int counter = 0;
        int len = 0;
        string txt;

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            if (user.Nombre != "")
            {
                txtWelcome.Text = "Bienvenido, " + user.Nombre;
            }
            // Animación
            txt = txtWelcome.Text;
            len = txt.Length;
            txtWelcome.Text = "";
            timer1.Start();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Designs.ConsultasViews.ConsultasView control = new ConsultasView(this);
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                timer1.Stop();
                return;
            }
            else
            {
                txtWelcome.Text = txt.Substring(0, counter);
            }
        }

        private void btnEnfermedades_Click(object sender, EventArgs e)
        {
            Designs.EnfermedadesViews.EnfermedadesView control = new EnfermedadesViews.EnfermedadesView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Designs.EmpleadosViews.UCEmpleadoView control = new EmpleadosViews.UCEmpleadoView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Designs.EspecialidadViews.UCEspecialidadView control = new EspecialidadViews.UCEspecialidadView();
            control.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(control);
            HideMenu();
        }
    }
}
