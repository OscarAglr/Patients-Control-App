using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class UserModel : IModel
    {
        public void Create()
        {
            throw new NotImplementedException();
        }
        public bool ChangeState()
        {
            throw new NotImplementedException();
        }

        public DataTable ShowTables()
        {
            DataTable dt = new DataTable("Mostrar usuarios");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec MostrarUsuarios", connect);

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

        public DataTable Validar_acceso(string usuario, string password)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec Validar_Acceso @user, @pass", connect);
            command.Parameters.AddWithValue("@user", usuario);
            command.Parameters.AddWithValue("@pass", password);

            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(DtResultado);
            connect.Close();
            sda.Dispose();
            return DtResultado;
        }
    }
}
