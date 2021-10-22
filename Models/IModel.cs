using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Models
{
    public interface IModel
    {
        bool Create();
        DataTable ShowTables();
        int Update();
        bool Delete();
    }
}
