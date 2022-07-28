using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorcitoModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        private MedidorcitoDBEntities medidorcitoDB = new MedidorcitoDBEntities();
        public void Agregar(Medidor medidor)
        {
            this.medidorcitoDB.Medidors.Add(medidor);
            this.medidorcitoDB.SaveChanges();
        }

        public void EliminarMedidor(int id)
        {
            Medidor medidor = this.medidorcitoDB.Medidors.Find(id);
            this.medidorcitoDB.Medidors.Remove(medidor);
            this.medidorcitoDB.SaveChanges();
        }

        public List<Medidor> ObtenerMedidores()
        {
           return this.medidorcitoDB.Medidors.ToList();
        }
    }
}
