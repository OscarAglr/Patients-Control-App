﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    class ConsultaModel : IModel
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
            DataTable dt = new DataTable("Mostrar Consultas");
            SqlConnection connect = new SqlConnection(Connection.cn);
            connect.Open();
            SqlCommand command = new SqlCommand("Exec MostrarConsultas", connect);

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
    }
}
