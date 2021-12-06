using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Reports
{
    class Class1
    {
        public DateTime fechaReport { get; private set; }

        public void fecha()
        {
            fechaReport = DateTime.Now;
        }
    }
}
