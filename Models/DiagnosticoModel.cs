using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class DiagnosticoModel
    {
        int id_enfermedad;
        int id_consulta;
        string descripcion;
        public int Id_enfermedad { get => id_enfermedad; set => id_enfermedad = value; }
        public int Id_consulta { get => id_consulta; set => id_consulta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool AgregarDiagnostico()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarDiagnosticos " +
                    "@id_enf, @id_cons, @descripcion", connect);

                command.Parameters.Add("id_enf", System.Data.SqlDbType.Int).Value = Id_enfermedad;
                command.Parameters.Add("id_cons", System.Data.SqlDbType.Int).Value = Id_consulta;
                command.Parameters.Add("descripcion", System.Data.SqlDbType.VarChar, 200).Value = Descripcion;

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
