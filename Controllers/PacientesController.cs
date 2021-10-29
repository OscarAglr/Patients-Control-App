using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class PacientesController : IControllers <PacientesModel>
    {
        public static PacientesModel model = new PacientesModel();
        public bool Create(PacientesModel p)
        {
            try
            {
                p.Create();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool ChangeState(PacientesModel p)
        {
            return p.ChangeState();
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(PacientesModel p)
        {
            return p.Update();
        }
    }
}
