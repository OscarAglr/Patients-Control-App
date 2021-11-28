using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class EmpleadosController : IControllers<EmpleadoModel>
    {
        
        public bool ChangeState(EmpleadoModel t)
        {
            throw new NotImplementedException();
        }

        public bool Create(EmpleadoModel t)
        {
            try
            {
                t.Create();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable ShowTables()
        {
            EmpleadoModel model = new EmpleadoModel();
            return model.ShowTables();
        }

        public int Update(EmpleadoModel t)
        {
            return t.Update();
        }
    }
}
