using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class UserController : IControllers <UserModel>
    {
        public static DataTable Validar_acceso(string usuario, string password)
        {
            return new UserModel().Validar_acceso(usuario, password);
        }

        public bool Create(UserModel u)
        {
            try
            {
                u.Create();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeState(UserModel u)
        {
            return u.ChangeState();
        }

        public DataTable ShowTables()
        {
            return new UserModel().ShowTables();
        }

        public int Update(UserModel u)
        {
            return u.Update();
        }

        public static DataTable GetRol(UserModel u)
        {
            return u.GetRol();
        }

        public bool ExisteUsuario(string usuario)
        {
            return new UserModel().ExisteUsuario(usuario);
        }

        public int GetIDMedico(string username)
        {
            return new UserModel().GetIDMedico(username);
        }

        public int GetIDUser(string username)
        {
            return new UserModel().GetIDUsuario(username);
        }

        public bool ChangePassword(UserModel user, string oldP, string newP)
        {
            return user.ChangePassword(oldP, newP);
        }
    }
}
