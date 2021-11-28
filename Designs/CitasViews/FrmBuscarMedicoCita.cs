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
    public partial class FrmBuscarMedicoCita : Form
    {
        MedicosController control = new MedicosController();
        FrmCitaView view;
        public FrmBuscarMedicoCita(FrmCitaView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void FrmBuscarMedicoCita_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas()
        {
            dataGridView1.DataSource = control.ShowTables();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    view.txtIDM.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    view.txtNameM.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    MessageBox.Show("Se selecciono al médico con éxito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
