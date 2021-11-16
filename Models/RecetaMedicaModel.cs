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
        int id_consulta;
        int cantidad;
        int dosis;
        string descripcion;

        public int Id_med { get => id_med; set => id_med = value; }
        public int Id_consulta { get => id_consulta; set => id_consulta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Dosis { get => dosis; set => dosis = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarMedicamentosConsultas " +
                    "@id_med, @id_cons, @cantidad, @dosis, @desc", connect);

                command.Parameters.Add("id_med", System.Data.SqlDbType.Int).Value = Id_med;
                command.Parameters.Add("id_cons", System.Data.SqlDbType.Int).Value = Id_consulta;
                command.Parameters.Add("cantidad", System.Data.SqlDbType.Int).Value = Cantidad;
                command.Parameters.Add("dosis", System.Data.SqlDbType.Int).Value = Dosis;
                command.Parameters.Add("desc", System.Data.SqlDbType.VarChar, 100).Value = Descripcion;

                command.ExecuteNonQuery();

                connect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
