using HealtyALTF4.Models;
using HealtyALTF4.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealtyALTF4.Designs.UsersViews
{
    public partial class FrmChangePassword : Form
    {
        UserModel user;
        UserController control = new UserController();
        public FrmChangePassword(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtIDUser.Text = user.Id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string p1 = txtP1.Text, p2 = txtP2.Text;
            if (p1 != p2)
            {
                MessageBox.Show("Las contraseñas son distintas");
                return;
            }
            string newP = txtNewP.Text;
            if (control.ChangePassword(user, p1, newP))
            {
                MessageBox.Show("Se cambio su contraseña con exito");
                txtNewP.Text = "";
                txtP1.Text = "";
                txtP2.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudo cambiar su contraseña");
                txtNewP.Text = "";
                txtP1.Text = "";
                txtP2.Text = "";
            }
        }
    }
}
