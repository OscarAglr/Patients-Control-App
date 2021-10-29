using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    class MedicosController : IControllers <MedicosModel>
    {
        public static MedicosModel model = new MedicosModel();
        public bool Create(MedicosModel mm)
        {
            try
            {
                mm.Create();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChangeState(MedicosModel mm)
        {
            return mm.ChangeState();
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(MedicosModel mm)
        {
            return mm.Update();
        }
    }
}
