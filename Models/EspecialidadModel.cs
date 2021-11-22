using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class EspecialidadModel : IModel
    {
        string nombre;
        string desc;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Desc { get => desc; set => desc = value; }

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

                SqlCommand command = new SqlCommand("exec AgregarEspecialidad @nombre, @desc", connect);

                command.Parameters.Add("nombre", SqlDbType.VarChar, 80).Value = Nombre;
                command.Parameters.Add("desc", SqlDbType.VarChar, 150).Value = Desc;

                command.ExecuteNonQuery();

                connect.Close();
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShowTables()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec MostrarEspecialidades", connect);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connect.Close();
                adapter.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
