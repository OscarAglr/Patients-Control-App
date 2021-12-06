using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealtyALTF4.Models;

namespace HealtyALTF4.Controllers
{
    public class CValidacionCedula
    {
        MValidacionCedula m = new MValidacionCedula();
        public bool Validar(string dato)
        {
            return m.Validar(dato);
        }
    }
}
