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
    public partial class UserView : UserControl
    {
        static UserController control;
        public UserView()
        {
            InitializeComponent();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserView_Load(object sender, EventArgs e)
        {
            control = new UserController();
            dgvUsers.DataSource = control.ShowTables();
        }
    }
}
