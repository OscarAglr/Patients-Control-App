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

namespace HealtyALTF4.Designs.PacientesViews
{

    public partial class PacienteView : UserControl
    {
        static PacientesController pc = new PacientesController();
        // Instancia del panel control
        Panel panelControl;
        // Se le pone como parámetro al constructor de la clase
        public PacienteView(Panel panelControl)
        {
            InitializeComponent();
            this.panelControl = panelControl;
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            Designs.PacientesViews.AddPaciente addpac = new AddPaciente();
            addpac.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(addpac);
           
        }

        public void MostrarTablas()
        {
            dgvPacientes.DataSource = pc.ShowTables();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = dgvPacientes.CurrentRow.Index;
            PacientesModel pm = new PacientesModel
            {
                Id = Convert.ToInt32(dgvPacientes.Rows[i].Cells[0].Value.ToString()),
                Primer_nombre = dgvPacientes.Rows[i].Cells[1].Value.ToString(),
                Segundo_nombre = dgvPacientes.Rows[i].Cells[2].Value.ToString(),
                Primer_apellido = dgvPacientes.Rows[i].Cells[3].Value.ToString(),
                Segundo_apellido = dgvPacientes.Rows[i].Cells[4].Value.ToString(),
                Fecha_nac = Convert.ToDateTime(dgvPacientes.Rows[i].Cells[5].Value.ToString()),
                Cedula = dgvPacientes.Rows[i].Cells[6].Value.ToString()
            };

            this.Hide();
            Designs.PacientesViews.UpdatePaciente uppac = new UpdatePaciente();
            uppac.p = pm;
            uppac.pv = this;
            uppac.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(uppac);
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int i = dgvPacientes.CurrentRow.Index;
            PacientesModel pm = new PacientesModel
            {
                Id = Convert.ToInt32(dgvPacientes.Rows[i].Cells[0].Value.ToString()),
            };
            if (pc.ChangeState(pm))
            {
                MessageBox.Show("Se cambio el estado del paciente");
                MostrarTablas();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el estado del paciente");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvPacientes.DataSource = pc.Search(textBox1.Text);
            }
            catch
            {
                return;
            }
        }
    }
}
