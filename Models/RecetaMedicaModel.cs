using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class RecetaMedicaModel
    {
        int id_med;
        int id_diag;
        int cantidad;
        int dosis;
        string descripcion;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Dosis { get => dosis; set => dosis = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_med { get => id_med; set => id_med = value; }
        public int Id_diag { get => id_diag; set => id_diag = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarMedicamentosDiagnosticos " +
                    "@id_med, @id_diag, @cantidad, @dosis, @desc", connect);

                command.Parameters.Add("id_med", System.Data.SqlDbType.Int).Value = Id_med;
                command.Parameters.Add("id_diag", System.Data.SqlDbType.Int).Value = Id_diag;
                command.Parameters.Add("cantidad", System.Data.SqlDbType.Int).Value = Cantidad;
                command.Parameters.Add("dosis", System.Data.SqlDbType.Int).Value = Dosis;
                command.Parameters.Add("desc", System.Data.SqlDbType.VarChar, 100).Value = Descripcion;

                command.ExecuteNonQuery();

                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
