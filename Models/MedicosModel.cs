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
        string primer_nombre;
        string segundo_nombre;
        string primer_apellido;
        string segundo_apellido;
        DateTime fecha_nac;
        string cedula;
        string especialidad;

        public int Id { get => id; set => id = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

        public void Create()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec AgregarMedico " +
                    "@p_nom, @s_nom, @p_ape, @s_ape, @f_nac, @cedula, @especialidad", connect);

                command.Parameters.Add("p_nom", SqlDbType.VarChar, 50).Value = Primer_nombre;
                command.Parameters.Add("s_nom", SqlDbType.VarChar, 50).Value = Segundo_nombre;
                command.Parameters.Add("p_ape", SqlDbType.VarChar, 50).Value = Primer_apellido;
                command.Parameters.Add("s_ape", SqlDbType.VarChar, 50).Value = Segundo_apellido;
                command.Parameters.Add("f_nac", SqlDbType.Date).Value = Fecha_nac;
                command.Parameters.Add("cedula", SqlDbType.VarChar, 50).Value = Cedula;
                command.Parameters.Add("especialidad", SqlDbType.VarChar, 45).Value = Especialidad;

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
                    "@id, @p_nom, @s_nom, @p_ape, @s_ape, @f_nac, @cedula, @especialidad", connect);

                command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("p_nom", SqlDbType.VarChar, 50).Value = Primer_nombre;
                command.Parameters.Add("s_nom", SqlDbType.VarChar, 50).Value = Segundo_nombre;
                command.Parameters.Add("p_ape", SqlDbType.VarChar, 50).Value = Primer_apellido;
                command.Parameters.Add("s_ape", SqlDbType.VarChar, 50).Value = Segundo_apellido;
                command.Parameters.Add("f_nac", SqlDbType.Date).Value = Fecha_nac;
                command.Parameters.Add("cedula", SqlDbType.VarChar, 50).Value = Cedula;
                command.Parameters.Add("especialidad", SqlDbType.VarChar, 45).Value = Especialidad;

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
