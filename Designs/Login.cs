using HealtyALTF4.Controllers;
using HealtyALTF4.Designs;
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

namespace HealtyALTF4
{
    public partial class Login : Form
    {
        int pivot = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dato, rol;
            dato = UserController.Validar_acceso(this.txtUser.Text, this.txtPassword.Text);
            UserController control = new UserController();
            if (dato == null)
            {
                MessageBox.Show("No se pudo conectar al Servidor", "Sistema de Control de Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
             if (dato.Rows.Count > 0)
            {

                if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                {
                    UserModel user = new UserModel();
                    user.Nombre = txtUser.Text;
                    rol = UserController.GetRol(user);
                    user.Id = control.GetIDUser(user.Nombre);
                    user.Rol = rol.Rows[0][0].ToString();
                    MessageBox.Show("Bienvenido al Sistema " + user.Id, "Sistema de Control de Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmSystem system = new FrmSystem(this, user);
                    system.Show();
                    this.Hide();
                    this.txtPassword.Text = "";
                    this.txtUser.Text = "";
                    this.txtUser.Focus();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado", "Sistema de Control de Hospital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUser.Text = string.Empty;
                    this.txtPassword.Text = string.Empty;
                    this.txtUser.Focus();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            txtUser.Focus();
        }

        private void btnHideView_Click(object sender, EventArgs e)
        {
            if (pivot == 1)
            {
                pivot = 0;
                btnHideView.Image = HealtyALTF4.Properties.Resources.visible;
                txtPassword.PasswordChar = '\0';
            }
            else if (pivot == 0)
            {
                pivot = 1;
                btnHideView.Image = HealtyALTF4.Properties.Resources.hidden;
                txtPassword.PasswordChar = '*';
            }
        }

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
