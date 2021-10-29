using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    class MedicamentosControllers : IControllers <MedicamentosModel>
    {
        MedicamentosModel model = new MedicamentosModel();
        public bool Create(MedicamentosModel m)
        {
            try
            {
                m.Create();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChangeState(MedicamentosModel m)
        {
            return m.ChangeState();
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(MedicamentosModel m)
        {
            return m.Update();
        }
    }
}
