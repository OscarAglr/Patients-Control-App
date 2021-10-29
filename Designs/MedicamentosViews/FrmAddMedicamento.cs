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
    public partial class FrmAddMedicamento : Form
    {
        MedicamentosControllers mc = new MedicamentosControllers();
        public MedicamentoView mv { get; set; }
        public FrmAddMedicamento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MedicamentosModel mm = new MedicamentosModel
                {
                    Nombre = txtNombre.Text,
                    Componentes = txtComp.Text
                };
                if (string.IsNullOrEmpty(mm.Nombre))
                {
                    MessageBox.Show("El campo del nombre no puede estar vacío");
                    return;
                }
                if (mc.Create(mm))
                {
                    MessageBox.Show("El medicamento fue registrado con éxito");
                    mv.MostrarTablas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
