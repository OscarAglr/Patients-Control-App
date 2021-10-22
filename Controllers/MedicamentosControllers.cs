using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    class MedicamentosControllers : IControllers
    {
        MedicamentosModel model = new MedicamentosModel();
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
            return model.ShowTables();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
