using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class EnfermedadController : IControllers<EnfermedadModel>
    {
        EnfermedadModel model = new EnfermedadModel();
        public bool ChangeState(EnfermedadModel t)
        {
            throw new NotImplementedException();
        }

        public bool Create(EnfermedadModel t)
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
            return model.ShowTables();
        }

        public int Update(EnfermedadModel t)
        {
            throw new NotImplementedException();
        }
    }
}
