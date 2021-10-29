using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class MedicamentosModel : IModel
    {
        int id;
        string nombre;
        string componentes;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Componentes { get => componentes; set => componentes = value; }
        public int Id { get => id; set => id = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarMedicamento " +
                    "@nombre, @componentes", connect);

                command.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = Nombre;
                command.Parameters.Add("componentes", SqlDbType.VarChar, 150).Value = Componentes;

                command.ExecuteNonQuery();

                connect.Close();
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public bool ChangeState()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec CambiarEstadoMedicamento " +
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
            DataTable dt = new DataTable("Mostrar Medicamentos");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec MostrarMedicamentos", connect);

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

                SqlCommand command = new SqlCommand("exec ActualizarMedicamento " +
                    "@id, @nombre, @componentes", connect);

                command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = Nombre;
                command.Parameters.Add("componentes", SqlDbType.VarChar, 50).Value = Componentes;

                command.ExecuteNonQuery();

                connect.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
