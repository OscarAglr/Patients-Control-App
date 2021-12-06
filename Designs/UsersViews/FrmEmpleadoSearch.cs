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
    public partial class FrmEmpleadoSearch : Form
    {
        EmpleadosController control = new EmpleadosController();
        FrmUsersView fu;
        public FrmEmpleadoSearch(FrmUsersView fu)
        {
            InitializeComponent();
            this.fu = fu;
        }

        private void FrmEmpleadoSearch_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas()
        {
            dataGridView1.DataSource = control.ShowTables();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[index].Cells[8].Value.ToString() == "Deshabilitado")
                {
                    MessageBox.Show("No se puede elegir a este empleado porque su estado es deshabilitado");
                    return;
                }
                fu.txtNEmp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                MessageBox.Show("Se selecciono al empleado con éxito");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = control.Search(textBox1.Text);
        }
    }
}
