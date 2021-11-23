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

namespace HealtyALTF4.Designs.MedicosViews
{
    public partial class FrmBuscarEmpleado : Form
    {
        EmpleadosController control = new EmpleadosController();
        FrmMedicoView view;
        public FrmBuscarEmpleado(FrmMedicoView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmBuscarEmpleado_Load(object sender, EventArgs e)
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
                view.txtNEmp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                view.txtNombreEmp.Text = dataGridView1.Rows[index].Cells[1].Value.ToString() + " " + dataGridView1.Rows[index].Cells[2].Value.ToString() + " " 
                    + dataGridView1.Rows[index].Cells[3].Value.ToString() + " " + dataGridView1.Rows[index].Cells[4].Value.ToString();
                MessageBox.Show("Se selecciono al empleado con éxito");
                this.Close();
            }
            
        }
    }
}
