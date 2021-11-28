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

namespace HealtyALTF4.Designs.CitasViews
{
    public partial class FrmBuscarPacienteCita : Form
    {
        PacientesController control = new PacientesController();
        FrmCitaView view;
        public FrmBuscarPacienteCita(FrmCitaView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmBuscarPacienteCita_Load(object sender, EventArgs e)
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
                view.txtIDP.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                view.txtNameP.Text = dataGridView1.Rows[index].Cells[1].Value.ToString() + " " + dataGridView1.Rows[index].Cells[2].Value.ToString() + " "
                    + dataGridView1.Rows[index].Cells[3].Value.ToString() + " " + dataGridView1.Rows[index].Cells[4].Value.ToString();
                MessageBox.Show("Se selecciono al paciente con éxito");
                this.Close();
            }
        }
    }
}
