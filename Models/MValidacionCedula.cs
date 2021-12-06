using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public class MValidacionCedula
    {
        public bool Validar(string dato)
        {
            try
            {
                DataTable DtResultado = new DataTable("Inicio_Sesión");
                SqlConnection connect = new SqlConnection(Connection.cn);
                connect.Open();
                SqlCommand command = new SqlCommand("Exec VerificarCedula @cedula", connect);
                command.Parameters.AddWithValue("@cedula", dato);

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(DtResultado);
                connect.Close();
                sda.Dispose();
                if (DtResultado.Rows[0][0].ToString() == "Valido")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
