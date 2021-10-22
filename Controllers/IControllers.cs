using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public interface IControllers
    {
        bool Create();
        DataTable ShowTables();
        int Update();
        bool Delete();
    }
}
