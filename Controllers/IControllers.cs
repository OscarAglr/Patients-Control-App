using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public interface IControllers <T>
    {
        bool Create(T t);
        DataTable ShowTables();
        int Update(T t);
        bool ChangeState(T t);
    }
}
