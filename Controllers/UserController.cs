using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class UserController : IControllers
    {
        public static DataTable Validar_acceso(string usuario, string password)
        {
            return new UserModel().Validar_acceso(usuario, password);
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public DataTable ShowTables()
        {
            return new UserModel().ShowTables();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
