using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class ConsultaModel : IModel
    {
        int id_pac;
        int id_med;
        DateTime fecha;

        public int Id_pac { get => id_pac; set => id_pac = value; }
        public int Id_med { get => id_med; set => id_med = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarConsulta " +
                    "@id_pac, @id_med, @fecha", connect);

                command.Parameters.Add("id_pac", SqlDbType.Int).Value = Id_pac;
                command.Parameters.Add("id_med", SqlDbType.Int).Value = Id_med;
                command.Parameters.Add("fecha", SqlDbType.Date).Value = fecha;

                command.ExecuteNonQuery();

                connect.Close();
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChangeState()
        {
            throw new NotImplementedException();
        }

        public DataTable ShowTables()
        {
            DataTable dt = new DataTable("Mostrar Consultas");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec MostrarConsultas", connect);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connect.Close();
            adapter.Dispose();
            return dt;
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
