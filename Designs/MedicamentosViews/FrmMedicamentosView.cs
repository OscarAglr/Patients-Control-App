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
    public partial class FrmMedicamentosView : Form
    {
        MedicamentosControllers control = new MedicamentosControllers();
        public FrmMedicamentosView()
        {
            InitializeComponent();
        }

        private void FrmMedicamentosView_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        public void MostrarTablas()
        {
            dgvMedicamentos.DataSource = control.ShowTables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            tbName.Text = "";
            rtbComp.Text = "";
            tbNMed.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentosModel model = new MedicamentosModel
                {
                    Nombre = tbName.Text,
                    Componentes = rtbComp.Text
                };
                if (control.Create(model))
                {
                    MessageBox.Show("Medicamento guardado con éxito");
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    MostrarTablas();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el medicamento");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                int index = dgvMedicamentos.CurrentCell.RowIndex;
                tbNMed.Text = dgvMedicamentos.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvMedicamentos.Rows[index].Cells[1].Value.ToString();
                rtbComp.Text = dgvMedicamentos.Rows[index].Cells[2].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnMod.Enabled = true;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentosModel model = new MedicamentosModel
                {
                    Id = int.Parse(tbNMed.Text),
                    Nombre = tbName.Text,
                    Componentes = rtbComp.Text
                };
                if (control.Update(model) != -1)
                {
                    MessageBox.Show("Registro modificado con éxito");
                    btnMod.Enabled = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    MostrarTablas();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
