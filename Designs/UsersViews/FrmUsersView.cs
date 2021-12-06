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

namespace HealtyALTF4.Designs.UsersViews
{
    public partial class FrmUsersView : Form
    {
        UserController control = new UserController();
        public FrmUsersView()
        {
            InitializeComponent();
        }

        private void FrmUsersView_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            cbRol.Items.Add("Administrador");
            cbRol.Items.Add("Secretaria");
            cbRol.Items.Add("Medico");
            cbRol.Items.Add("Gerente");
            cbRol.Items.Add("Farmaceutico");
            cbRol.Items.Add("Registrador");
        }

        public void MostrarUsuarios()
        {
            dgvUsers.DataSource = control.ShowTables();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmEmpleadoSearch search = new FrmEmpleadoSearch(this);
            search.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNEmp.Text) || string.IsNullOrEmpty(txtUN.Text) || string.IsNullOrEmpty (txtPassword.Text) || string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("Ningún dato puede quedar vacío");
                return;
            }
            UserModel model = new UserModel
            {
                Nombre = txtUN.Text,
                Password = txtPassword.Text,
                Rol = cbRol.Text,
                NoEmpleado = int.Parse(txtNEmp.Text)
            };
            if (control.ExisteUsuario(model.Nombre))
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
                return;
            }
            if (control.Create(model))
            {
                MessageBox.Show("Usuario agregado con exito");
                btnSave.Enabled = false;
                btnMod.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                MostrarUsuarios();
            }
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    int index = dgvUsers.CurrentCell.RowIndex;
                    index = int.Parse(dgvUsers.Rows[index].Cells[0].Value.ToString());
                    UserModel model = new UserModel
                    {
                        Id = index
                    };
                    if (MessageBox.Show("¿Está seguro de querer cambiar el estado del usuario con id " + model.Id.ToString() + "?",
                        "Confirmar cambio de estado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (control.ChangeState(model))
                        {
                            MessageBox.Show("Usuario actualizado con éxito");
                            MostrarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar al usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                btnMod.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                int index = dgvUsers.CurrentCell.RowIndex;
                txtID.Text = dgvUsers.Rows[index].Cells[0].Value.ToString();
                txtUN.Text = dgvUsers.Rows[index].Cells[1].Value.ToString();
                txtNEmp.Text = dgvUsers.Rows[index].Cells[2].Value.ToString();
                cbRol.Text = dgvUsers.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNEmp.Text) || string.IsNullOrEmpty(txtUN.Text) || string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("Ningún dato puede quedar vacío");
                return;
            }
            UserModel model = new UserModel
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtUN.Text,
                Rol = cbRol.Text,
                NoEmpleado = int.Parse(txtNEmp.Text)
            };
            if (control.ExisteUsuario(model.Nombre))
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
                return;
            }
            if (control.Update(model) != -1)
            {
                MessageBox.Show("Usuario actualizado con exito");
                btnSave.Enabled = false;
                btnMod.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("No se puedo actualizar al usuario");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnMod.Enabled = false;
        }
    }
}
