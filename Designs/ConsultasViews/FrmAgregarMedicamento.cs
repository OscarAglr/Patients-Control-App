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

namespace HealtyALTF4.Designs.ConsultasViews
{
    public partial class FrmAgregarMedicamento : Form
    {
        MedicamentosControllers control = new MedicamentosControllers();
        FrmConsultaOperacion op;
        public FrmAgregarMedicamento(FrmConsultaOperacion op)
        {
            InitializeComponent();
            this.op = op;
        }

        private void FrmAgregarMedicamento_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        private void MostrarTablas()
        {
            dataGridView1.DataSource = control.ShowTables();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Deshabilitado")
                {
                    MessageBox.Show("No se puede elegir a este medicamento porque su estado es deshabilitado");
                    return;
                }
                op.txtIDM.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                op.txtNM.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                MessageBox.Show("Datos agregados con éxito");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = control.Search(textBox1.Text);
        }
    }
}
