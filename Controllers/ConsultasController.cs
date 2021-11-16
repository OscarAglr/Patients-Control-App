using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    class ConsultasController : IControllers <ConsultaModel>
    {
        ConsultaModel model = new ConsultaModel();
        public bool Create(ConsultaModel c)
        {
            try
            {
                c.Create();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeState(ConsultaModel c)
        {
            throw new NotImplementedException();
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(ConsultaModel c)
        {
            throw new NotImplementedException();
        }
    }
}
