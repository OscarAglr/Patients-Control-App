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
    public partial class FrmConsultaOperacion : Form
    {
        List<DiagnosticoModel> listDiagnosticos;
        List<RecetaMedicaModel> listMedicamentos;
        DataTable dt;
        FrmConsultaView view;
        DiagnosticoController control;
        public FrmConsultaOperacion(FrmConsultaView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void btnAddEnfermedad_Click(object sender, EventArgs e)
        {
            FrmAgregarDiagnostico frmAgregarDiagnostico = new FrmAgregarDiagnostico(this);
            frmAgregarDiagnostico.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FrmConsultaOperacion_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ID medicamento", typeof(int));
            dt.Columns.Add("Nombre del medicamento", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Dosis", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            NuevaTabla();
            control = new DiagnosticoController();
            listDiagnosticos = new List<DiagnosticoModel>();
            listMedicamentos = new List<RecetaMedicaModel>();
        }

        public void NuevaTabla()
        {
            dt.Clear();
            dgvReceta.DataSource = dt;
        }

        private void btnBuscarMed_Click(object sender, EventArgs e)
        {
            FrmAgregarMedicamento frmAgregarMedicamento = new FrmAgregarMedicamento(this);
            frmAgregarMedicamento.ShowDialog();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dt.NewRow();
                dr[0] = int.Parse(txtIDM.Text);
                dr[1] = txtNM.Text;
                dr[2] = int.Parse(numCantidad.Value.ToString());
                dr[3] = int.Parse(numDosis.Value.ToString());
                dr[4] = rtbMed.Text;
                if (string.IsNullOrEmpty(txtNM.Text) || string.IsNullOrEmpty(txtIDM.Text) ||int.Parse(numCantidad.Value.ToString()) <= 0 || int.Parse(numDosis.Value.ToString()) <= 0)
                {
                    MessageBox.Show("Los datos no pueden ir vacíos");
                    return;
                }
                RecetaMedicaModel rm = new RecetaMedicaModel
                {
                    Id_med = int.Parse(txtIDM.Text),
                    Cantidad = int.Parse(numCantidad.Value.ToString()),
                    Dosis = int.Parse(numDosis.Value.ToString()),
                    Descripcion = rtbMed.Text
                };
                bool contiene = listMedicamentos.Any(r => r.Id_med == rm.Id_med);
                if (contiene)
                {
                    // Actualiza
                    if (ExisteEnDGV(rm.Id_med))
                    {
                        int index = listMedicamentos.FindIndex(r => r.Id_med == rm.Id_med);
                        DataGridViewRow row = dgvReceta.Rows[index];
                        row.Cells[2].Value = numCantidad.Value;
                        row.Cells[3].Value = numDosis.Value;
                        MessageBox.Show("Se actualizo con éxito el medicamento");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Este medicamento ya se registro en un diagnostico pasado");
                        return;
                    }
                }
                listMedicamentos.Add(rm);
                dt.Rows.Add(dr);
                dgvReceta.DataSource = dt;
                numCantidad.Value = 0;
                numDosis.Value = 0;
                rtbMed.Text = "";
                txtIDM.Text = "";
                txtNM.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ExisteEnDGV(int busqueda)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (busqueda == int.Parse(dgvReceta.Rows[i].Cells[0].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de hacer esto?, luego no se podrá modificar la información", 
                "Mensaje de aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtIDE.Text))
                {
                    MessageBox.Show("Aún no ha agregado una enfermedad al diagnostico");
                    return;
                }
                DiagnosticoModel model = new DiagnosticoModel
                {
                    Id_enfermedad = int.Parse(txtIDE.Text),
                    Id_cita = int.Parse(txtIDC.Text),
                    Descripcion = rtbDiagnostico.Text
                };
                bool contiene = listDiagnosticos.Any(r => r.Id_enfermedad == model.Id_enfermedad);
                if (contiene)
                {
                    MessageBox.Show("No se pueden repetir enfermedades en el diagnostico");
                    return;
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RecetaMedicaModel rm = new RecetaMedicaModel
                    {
                        Id_med = int.Parse(dgvReceta.Rows[i].Cells[0].Value.ToString()),
                        Cantidad = int.Parse(dgvReceta.Rows[i].Cells[2].Value.ToString()),
                        Dosis = int.Parse(dgvReceta.Rows[i].Cells[3].Value.ToString()),
                        Descripcion = dgvReceta.Rows[i].Cells[4].Value.ToString()
                    };
                    model.recetados.Add(rm);
                }
                listDiagnosticos.Add(model);

                DialogResult d1 = MessageBox.Show("Datos guardados, ¿desea agregar un nuevo diagnóstico?",
                "Mensaje de aviso", MessageBoxButtons.YesNo);
                if (d1 == DialogResult.Yes)
                {
                    txtIDE.Text = "";
                    txtNE.Text = "";
                    txtIDM.Text = "";
                    txtNM.Text = "";
                    numCantidad.Value = 0;
                    numDosis.Value = 0;
                    rtbDiagnostico.Text = "";
                    rtbMed.Text = "";
                    NuevaTabla();
                    
                }
                else if (d1 == DialogResult.No)
                {
                    try
                    {
                        for (int i = 0; i < listDiagnosticos.Count; i++)
                        {
                            int id = control.Create(listDiagnosticos[i]);
                            listDiagnosticos[i].Id_diag = id;
                            control.AgregarDetalles(listDiagnosticos[i]);
                        }
                        CitaModel cm = new CitaModel
                        {
                            Id = int.Parse(txtIDC.Text)
                        };
                        CitaController controlCita = new CitaController();
                        if (controlCita.ChangeState(cm))
                        {
                            MessageBox.Show("Se guardaron los detalles con éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error en los detalles");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dgvReceta.CurrentCell.RowIndex;
            var itemToRemove = listMedicamentos.Single(r => r.Id_med == int.Parse(dgvReceta.Rows[index].Cells[0].Value.ToString()));
            listMedicamentos.Remove(itemToRemove);
            dgvReceta.Rows.RemoveAt(index);
        }

        private void dgvReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //DataGridViewRow row = dgvReceta.Rows[index];
            //txtIDM.Text = row.Cells[0].Value.ToString();
            //txtNM.Text = row.Cells[1].Value.ToString();
            //numCantidad.Value = Decimal.Parse(row.Cells[2].Value.ToString());
            //numDosis.Value = Decimal.Parse(row.Cells[3].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int index = dgvReceta.CurrentCell.RowIndex;
            //DataGridViewRow row = dgvReceta.Rows[index];
            //bool contiene = listMedicamentos.Any(r => r.Id_med == rm.Id_med);
            //RecetaMedicaModel rm = new RecetaMedicaModel
            //{
            //    Id_med = int.Parse(txtIDM.Text),
            //    Cantidad = int.Parse(numCantidad.Value.ToString()),
            //    Dosis = int.Parse(numDosis.Value.ToString()),
            //    Descripcion = rtbMed.Text
            //};
            //if (contiene)
            //{
            //    MessageBox.Show("No se pueden repetir medicamentos");
            //    return;
            //}
            
            //row.Cells[1].Value = txtNM.Text;
            //row.Cells[2].Value = numCantidad.Value;
            //row.Cells[3].Value = numDosis.Value;
            //MessageBox.Show("Se actualizo con éxito el medicamento");
        }
    }
}
