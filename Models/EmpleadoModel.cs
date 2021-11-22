using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class EmpleadoModel : IModel
    {
        int id;
        string primer_nombre;
        string segundo_nombre;
        string primer_apellido;
        string segundo_apellido;
        DateTime fecha_nac;
        string cedula;
        string puesto;

        public int Id { get => id; set => id = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Puesto { get => puesto; set => puesto = value; }

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

                SqlCommand command = new SqlCommand("exec AgregarEmpleados @pnom, @snom, @pape, @sape, @fnac, @cedula, @puesto", connect);

                command.Parameters.Add("pnom", SqlDbType.VarChar, 50).Value = Primer_nombre;
                command.Parameters.Add("snom", SqlDbType.VarChar, 50).Value = Segundo_nombre;
                command.Parameters.Add("pape", SqlDbType.VarChar, 50).Value = Primer_apellido;
                command.Parameters.Add("sape", SqlDbType.VarChar, 50).Value = Segundo_apellido;
                command.Parameters.Add("fnac", SqlDbType.Date).Value = Fecha_nac;
                command.Parameters.Add("cedula", SqlDbType.VarChar, 50).Value = Cedula;
                command.Parameters.Add("puesto", SqlDbType.VarChar, 45).Value = Puesto;

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
                SqlCommand command = new SqlCommand("Exec MostrarEmpleados", connect);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connect.Close();
                adapter.Dispose();
                return dt;
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }

        public int Update()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Connection.cn);

                connect.Open();

                SqlCommand command = new SqlCommand("exec ActualizarEmpleado " +
                    "@id, @pnom, @snom, @pape, @sape, @fnac, @cedula, @puesto", connect);

                command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("pnom", SqlDbType.VarChar, 50).Value = Primer_nombre;
                command.Parameters.Add("snom", SqlDbType.VarChar, 50).Value = Segundo_nombre;
                command.Parameters.Add("pape", SqlDbType.VarChar, 50).Value = Primer_apellido;
                command.Parameters.Add("sape", SqlDbType.VarChar, 50).Value = Segundo_apellido;
                command.Parameters.Add("fnac", SqlDbType.Date).Value = Fecha_nac;
                command.Parameters.Add("cedula", SqlDbType.VarChar, 50).Value = Cedula;
                command.Parameters.Add("puesto", SqlDbType.VarChar, 45).Value = Puesto;

                command.ExecuteNonQuery();

                connect.Close();
                return Id;
            }
            catch
            {
                return -1;
            }
        }
    }
}
