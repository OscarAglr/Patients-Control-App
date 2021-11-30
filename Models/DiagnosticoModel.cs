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
        int id_cita;
        string descripcion;
        public int Id_enfermedad { get => id_enfermedad; set => id_enfermedad = value; }
        public int Id_cita { get => id_cita; set => id_cita = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarDiagnosticos " +
                    "@id_enf, @id_cita, @descripcion", connect);

                command.Parameters.Add("id_enf", System.Data.SqlDbType.Int).Value = Id_enfermedad;
                command.Parameters.Add("id_cita", System.Data.SqlDbType.Int).Value = Id_cita;
                command.Parameters.Add("descripcion", System.Data.SqlDbType.VarChar, 200).Value = Descripcion;

                command.ExecuteNonQuery();
                int key = Convert.ToInt32(command.ExecuteScalar());
                connect.Close();
                return key;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
