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

namespace HealtyALTF4.Designs.MedicosViews
{
    public partial class MedicosView : UserControl
    {
        
        MedicosController controller = new MedicosController();
        Panel panelControl;
        public MedicosView(Panel panelControl)
        {
            InitializeComponent();
            this.panelControl = panelControl;
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.MedicosViews.AddMedico addmec = new AddMedico();
            addmec.mv = this;
            addmec.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(addmec);
        }

        public void MostrarTablas()
        {
            dgvMedicos.DataSource = controller.ShowTables();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dgvMedicos.CurrentRow.Index;
            MedicosModel mm = new MedicosModel
            {
                Id = Convert.ToInt32(dgvMedicos.Rows[i].Cells[0].Value.ToString()),
                Primer_nombre = dgvMedicos.Rows[i].Cells[1].Value.ToString(),
                Segundo_nombre = dgvMedicos.Rows[i].Cells[2].Value.ToString(),
                Primer_apellido = dgvMedicos.Rows[i].Cells[3].Value.ToString(),
                Segundo_apellido = dgvMedicos.Rows[i].Cells[4].Value.ToString(),
                Fecha_nac = Convert.ToDateTime(dgvMedicos.Rows[i].Cells[5].Value.ToString()),
                Cedula = dgvMedicos.Rows[i].Cells[6].Value.ToString(),
                Especialidad = dgvMedicos.Rows[i].Cells[7].Value.ToString()
            };
            this.Hide();
            Designs.MedicosViews.UpdateMedico upmec = new UpdateMedico();
            upmec.m = mm;
            upmec.mv = this;
            upmec.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(upmec);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dgvMedicos.CurrentRow.Index;
            MedicosModel mm = new MedicosModel
            {
                Id = Convert.ToInt32(dgvMedicos.Rows[i].Cells[0].Value.ToString()),
            };
            if (controller.ChangeState(mm))
            {
                MessageBox.Show("Se cambio el estado del medico");
                MostrarTablas();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el estado del medico");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = controller.Search(textBox1.Text);
        }
    }
}
