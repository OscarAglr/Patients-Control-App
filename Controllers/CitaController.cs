using HealtyALTF4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealtyALTF4.Controllers
{
    public class CitaController : IControllers<CitaModel>
    {
        CitaModel model = new CitaModel();
        public bool ChangeState(CitaModel t)
        {
            try
            {
                t.CambiarEstado();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Create(CitaModel t)
        {
            try
            {
                t.Create();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable ShowTables()
        {
            return model.ShowTables();
        }

        public int Update(CitaModel t)
        {
            throw new NotImplementedException();
        }

        public DataTable Citita()
        {
            return model.Citita();
        }

        public bool Reservado(CitaModel t)
        {
            return t.Reservado();
        }
    }
}
