using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    class UserModel
    {
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
