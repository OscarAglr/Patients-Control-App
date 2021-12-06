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
    public partial class FrmBuscarEspecialidad : Form
    {
        EspecialidadController control = new EspecialidadController();
        FrmMedicoView view;
        public FrmBuscarEspecialidad(FrmMedicoView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmBuscarEspecialidad_Load(object sender, EventArgs e)
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
                view.txtNEsp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                view.txtNombreEsp.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                MessageBox.Show("Se selecciono la especialidad con éxito");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = control.Search(textBox1.Text);
        }
    }
}
