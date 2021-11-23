using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class EspecialidadController : IControllers<EspecialidadModel>
    {
        public bool ChangeState(EspecialidadModel t)
        {
            throw new NotImplementedException();
        }

        public bool Create(EspecialidadModel t)
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
            EspecialidadModel model = new EspecialidadModel();
            return model.ShowTables();
        }

        public int Update(EspecialidadModel t)
        {
            return t.Update();
        }
    }
}
