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
    public partial class FrmUpdateMedicamento : Form
    {
        public MedicamentosModel m { get; set; }
        MedicamentosControllers mc = new MedicamentosControllers();
        public MedicamentoView mv { get; set; }
        public FrmUpdateMedicamento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentosModel m_new = new MedicamentosModel
                {
                    Id = m.Id,
                    Nombre = txtNombre.Text,
                    Componentes = txtComp.Text
                };
                if (string.IsNullOrEmpty(m_new.Nombre))
                {
                    MessageBox.Show("El campo del nombre no puede estar vacío");
                    return;
                }
                if (mc.Update(m_new) == -1)
                {
                    MessageBox.Show("Error al actualizar");
                    return;
                }
                else
                {
                    mc.Update(m_new);
                    MessageBox.Show("Medicamento actualizado con éxito");
                    mv.MostrarTablas();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmUpdateMedicamento_Load(object sender, EventArgs e)
        {
            txtId.Text = m.Id.ToString();
            txtNombre.Text = m.Nombre;
            txtComp.Text = m.Componentes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
