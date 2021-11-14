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

namespace HealtyALTF4.Designs.MedicamentosViews
{
    public partial class MedicamentoView : UserControl
    {
        static MedicamentosControllers controllers = new MedicamentosControllers();
        public MedicamentoView()
        {
            InitializeComponent();
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddMedicamento frmAddMedicamento = new FrmAddMedicamento();
            frmAddMedicamento.mv = this;
            frmAddMedicamento.ShowDialog();
        }

        public void MostrarTablas()
        {
            dgvMedicamentos.DataSource = controllers.ShowTables();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dgvMedicamentos.CurrentRow.Index;
            MedicamentosModel mm = new MedicamentosModel
            {
                Id = Convert.ToInt32(dgvMedicamentos.Rows[i].Cells[0].Value.ToString()),
            };
            if (controllers.ChangeState(mm))
            {
                MessageBox.Show("Se cambio el estado del medicamento");
                MostrarTablas();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el estado del medicamento");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dgvMedicamentos.CurrentRow.Index;
            MedicamentosModel mm = new MedicamentosModel
            {
                Id = Convert.ToInt32(dgvMedicamentos.Rows[i].Cells[0].Value.ToString()),
                Nombre = dgvMedicamentos.Rows[i].Cells[1].Value.ToString(),
                Componentes = dgvMedicamentos.Rows[i].Cells[2].Value.ToString()
            };
            FrmUpdateMedicamento frmUpdateMedicamento = new FrmUpdateMedicamento();
            frmUpdateMedicamento.m = mm;
            frmUpdateMedicamento.mv = this;
            frmUpdateMedicamento.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvMedicamentos.DataSource = controllers.Search(textBox1.Text);
        }
    }
}
