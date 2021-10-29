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
        void Create();
        DataTable ShowTables();
        int Update();
        bool ChangeState();
    }
}
