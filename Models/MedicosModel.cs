using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class MedicosModel : IModel
    {
        int id;
        int id_med;
        int id_esp;

        public int Id { get => id; set => id = value; }
        public int Id_med { get => id_med; set => id_med = value; }
        public int Id_esp { get => id_esp; set => id_esp = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarMedico " +
                    "@NEmp, @IDEsp", connect);

                command.Parameters.Add("NEmp", SqlDbType.Int).Value = Id_med;
                command.Parameters.Add("IDEsp", SqlDbType.Int).Value = Id_esp;

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
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec CambiarEstadoMedico " +
                    "@id", connect);

                command.Parameters.Add("id", SqlDbType.Int).Value = Id;

                command.ExecuteNonQuery();

                connect.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ShowTables()
        {
            DataTable dt = new DataTable("Mostrar Medicos");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec MostrarMedicos", connect);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connect.Close();
            adapter.Dispose();
            return dt;
        }

        public int Update()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec ActualizarMedico " +
                    "@idMed, @NEmp, @IDEsp", connect);

                command.Parameters.Add("idMed", SqlDbType.Int).Value = Id;
                command.Parameters.Add("NEmp", SqlDbType.Int).Value = Id_med;
                command.Parameters.Add("IDEsp", SqlDbType.Int).Value = Id_esp;

                command.ExecuteNonQuery();

                connect.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public DataTable Search(string dato)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec BusquedaMedicos @Buscar", connect);
            command.Parameters.Add("Buscar", SqlDbType.VarChar, 100).Value = dato;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connect.Close();
            adapter.Dispose();
            return dt;
        }

        
    }
}
