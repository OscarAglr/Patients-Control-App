using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class CitaModel : IModel
    {
        int id;
        int n_med;
        int n_pac;
        DateTime fecha;
        TimeSpan hora;
        string motivo;

        public int Id { get => id; set => id = value; }
        public int N_med { get => n_med; set => n_med = value; }
        public int N_pac { get => n_pac; set => n_pac = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        public bool ChangeState()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec ProgramarCita @n_med, @n_pac, @fecha, @hora, @motivo", connect);

                command.Parameters.Add("n_med", SqlDbType.Int).Value = N_med;
                command.Parameters.Add("n_pac", SqlDbType.Int).Value = N_pac;
                command.Parameters.Add("fecha", SqlDbType.Date).Value = Fecha;
                command.Parameters.Add("hora", SqlDbType.Time).Value = Hora;
                command.Parameters.Add("motivo", SqlDbType.VarChar, 200).Value = Motivo;

                command.ExecuteNonQuery();

                connect.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DataTable ShowTables()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
