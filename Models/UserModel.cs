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
        string nombre;
        string rol;
        int noEmpleado;
        string password;
        int id;
        int id_med;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public int Id_med { get => id_med; set => id_med = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec InsertarUsuario @usuario, @contra, @rol, @NoEmpleado", connect);
                command.Parameters.Add("usuario", SqlDbType.VarChar, 50).Value = Nombre;
                command.Parameters.Add("contra", SqlDbType.VarChar, 50).Value = Password;
                command.Parameters.Add("rol", SqlDbType.VarChar, 50).Value = Rol;
                command.Parameters.Add("NoEmpleado", SqlDbType.Int).Value = NoEmpleado;
                command.ExecuteNonQuery();

                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            
        }
        public bool ChangeState()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec CambiarEstadoUsuario @id", connect);
                command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                command.ExecuteNonQuery();

                connect.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
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
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec ActualizarUsuario @id, @usuario, @rol, @NoEmpleado", connect);
                command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("usuario", SqlDbType.VarChar, 50).Value = Nombre;
                command.Parameters.Add("rol", SqlDbType.VarChar, 50).Value = Rol;
                command.Parameters.Add("NoEmpleado", SqlDbType.Int).Value = NoEmpleado;
                command.ExecuteNonQuery();

                connect.Close();
                return Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
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

        public DataTable GetRol()
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec GetRol @username", connect);
            command.Parameters.AddWithValue("@username", Nombre);

            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(DtResultado);
            connect.Close();
            sda.Dispose();
            return DtResultado;
        }

        public bool ExisteUsuario(string usuario)
        {
            try
            {
                DataTable DtResultado = new DataTable();
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec sp_existe_usuario @username", connect);
                command.Parameters.AddWithValue("@username", usuario);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(DtResultado);
                connect.Close();
                sda.Dispose();
                if (DtResultado.Rows[0][0].ToString() == "Existe")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }

        public int GetIDMedico(string username)
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec getIdMedico @username", connect);
                command.Parameters.Add("username", SqlDbType.VarChar, 50).Value = username;
                int key = Convert.ToInt32(command.ExecuteScalar());

                connect.Close();
                return key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int GetIDUsuario(string username)
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec GetIDUser @user", connect);
                command.Parameters.Add("user", SqlDbType.VarChar, 50).Value = username;
                int key = Convert.ToInt32(command.ExecuteScalar());

                connect.Close();
                return key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public bool ChangePassword(string oldP, string newP)
        {
            // ChangePassword @id int, @usuario varchar(50), @old varchar(50), @new varchar(50)
            try
            {
                DataTable DtResultado = new DataTable();
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec ChangePassword @id, @usuario, @old, @new", connect);
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@usuario", Nombre);
                command.Parameters.AddWithValue("@old", oldP);
                command.Parameters.AddWithValue("@new", newP);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(DtResultado);
                connect.Close();
                sda.Dispose();
                if (DtResultado.Rows[0][0].ToString() == "Cambiado")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
