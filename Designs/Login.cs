using HealtyALTF4.Controllers;
using HealtyALTF4.Designs;
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
            DataTable dato;
            dato = UserController.Validar_acceso(this.txtUser.Text, this.txtPassword.Text);
            if (dato == null)
            {
                MessageBox.Show("No se pudo conectar al Servidor", "Sistema de Control de Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
             if (dato.Rows.Count > 0)
            {

                if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                {
                    MessageBox.Show("Bienvenido al Sistema", "Sistema de Control de Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmSystem system = new FrmSystem();
                    system.Show();
                    this.Hide();
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
    }
}
