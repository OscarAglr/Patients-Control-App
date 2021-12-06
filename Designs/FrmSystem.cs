using HealtyALTF4.Controllers;
using HealtyALTF4.Designs.CitasViews;
using HealtyALTF4.Designs.ConsultasViews;
using HealtyALTF4.Designs.EmpleadosViews;
using HealtyALTF4.Designs.EnfermedadesViews;
using HealtyALTF4.Designs.EspecialidadViews;
using HealtyALTF4.Designs.MedicamentosViews;
using HealtyALTF4.Designs.MedicosViews;
using HealtyALTF4.Designs.PacientesViews;
using HealtyALTF4.Designs.UsersViews;
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
            openChildForm(new FrmPacienteView(user, this));
            HideMenu();
        }

        // Boton medicos
        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmMedicoView(user, this));
        }

        private void btnMedicamentos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmMedicamentosView(user));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmUsersView());
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
            if (user.Rol == "Administrador")
            {
                // boton usuario
                btnPacientes.Enabled = true;
                btnDoctores.Enabled = true;
                btnMedicamentos.Enabled = true;
                btnEnfermedades.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                btnCitas.Enabled = false;
                btnConsulta.Enabled = false;
                button10.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            } 
            else if (user.Rol == "Secretaria")
            {
                btnPacientes.Enabled = true;
                btnDoctores.Enabled = false;
                btnMedicamentos.Enabled = false;
                btnEnfermedades.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                btnCitas.Enabled = true;
                btnConsulta.Enabled = false;
                button10.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                // boton usuario
                button5.Enabled = false;
            }
            else if (user.Rol == "Medico")
            {
                btnPacientes.Enabled = true;
                btnDoctores.Enabled = false;
                btnMedicamentos.Enabled = true;
                btnEnfermedades.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                btnCitas.Enabled = false;
                btnConsulta.Enabled = true;
                button10.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;
                // boton usuario
                button5.Enabled = false;
                user.Id_med = new UserController().GetIDMedico(user.Nombre);
            }
            else if (user.Rol == "Gerente")
            {
                btnPacientes.Enabled = false;
                btnDoctores.Enabled = true;
                btnMedicamentos.Enabled = false;
                btnEnfermedades.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
                btnCitas.Enabled = false;
                btnConsulta.Enabled = false;
                button10.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = false;
                // boton usuario
                button5.Enabled = false;
            }
            else if (user.Rol == "Farmaceutico")
            {
                btnPacientes.Enabled = false;
                btnDoctores.Enabled = false;
                btnMedicamentos.Enabled = true;
                btnEnfermedades.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                btnCitas.Enabled = false;
                btnConsulta.Enabled = false;
                button10.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                // boton usuario
                button5.Enabled = false;
            }
            else if (user.Rol == "Farmaceutico")
            {
                btnPacientes.Enabled = false;
                btnDoctores.Enabled = false;
                btnMedicamentos.Enabled = true;
                btnEnfermedades.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                btnCitas.Enabled = false;
                btnConsulta.Enabled = false;
                button10.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                // boton usuario
                button5.Enabled = false;
            }
            // Animación
            txt = txtWelcome.Text;
            len = txt.Length;
            txtWelcome.Text = "";
            timer1.Start();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaView(this, user));
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
            openChildForm(new FrmEnfermedadesView(user));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmEmpleadoView(user));
            HideMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEspecialidadView(user));
        }

        public Form form = null;
        public void openChildForm(Form childForm)
        {
            if (form != null)
            {
                form.Close();
            }
            form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCitaView());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.FrmReportePaciente());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.FrmReporteMedico());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports.FrmReporT());
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChangePassword(user));
        }
    }
}
