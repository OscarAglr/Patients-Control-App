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
    public partial class FrmSelectMedico : Form
    {
        MedicosController mc = new MedicosController();
        FrmAddConsulta fac;
        public FrmSelectMedico()
        {
            InitializeComponent();
        }

        public FrmSelectMedico(FrmAddConsulta fac)
        {
            InitializeComponent();
            this.fac = fac;
        }

        private void FrmSelectMedico_Load(object sender, EventArgs e)
        {
            dgvSelect.DataSource = mc.ShowTables();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvSelect.DataSource = mc.Search(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSelect.SelectedRows.Count > 0)
                {
                    int i = dgvSelect.CurrentRow.Index;
                    fac.txtNoMedico.Text = dgvSelect.Rows[i].Cells[0].Value.ToString();
                    fac.txtMedicoNombre.Text = dgvSelect.Rows[i].Cells[1].Value.ToString() + ' ' + dgvSelect.Rows[i].Cells[2].Value.ToString()
                        + ' ' + dgvSelect.Rows[i].Cells[3].Value.ToString() + ' ' + dgvSelect.Rows[i].Cells[4].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Debe seleccionar una fila!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
