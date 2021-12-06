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

namespace HealtyALTF4.Designs.ConsultasViews
{
    public partial class FrmConsultaView : Form
    {
        CitaController control = new CitaController();
        FrmSystem fs;
        UserModel user;
        public FrmConsultaView(FrmSystem fs, UserModel user)
        {
            InitializeComponent();
            this.fs = fs;
            this.user = user;
        }

        private void FrmConsultaView_Load(object sender, EventArgs e)
        {
            dgvCitas.DataSource = control.ShowTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                int i = dgvCitas.CurrentCell.RowIndex;
                int idCita = int.Parse(dgvCitas.Rows[i].Cells[0].Value.ToString());
                int idMed = int.Parse(dgvCitas.Rows[i].Cells[1].Value.ToString());
                if (idMed != user.Id_med )
                {
                    MessageBox.Show("Usted no fue asignado para esta cita, " + user.Id_med);
                    return;
                }
                if (DateTime.Parse(dgvCitas.Rows[i].Cells[5].Value.ToString()) > DateTime.Now &&
                    DateTime.Parse(dgvCitas.Rows[i].Cells[6].Value.ToString()).TimeOfDay > DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("Aún no se puede atender esta cita");
                    return;
                }
                FrmConsultaOperacion o = new FrmConsultaOperacion(this);
                o.txtIDC.Text = idCita.ToString();
                this.Close();
                fs.openChildForm(o);
            }
        }
    }
}
