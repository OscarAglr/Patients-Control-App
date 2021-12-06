using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class DiagnosticoController
    {
        public int Create(DiagnosticoModel model)
        {
            return model.Create();
        }

        public void AgregarDetalles(DiagnosticoModel model)
        {
            model.AgregarDetalles();
        }

        //public void CambiarEstado(DiagnosticoModel model)
        //{
        //    model.CambiarEstado();
        //}
    }
}
