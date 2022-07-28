using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorcitoModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        private MedidorcitoDBEntities medidorcitoDB = new MedidorcitoDBEntities();
        public void AgregarLectura(Lectura lectura)
        {
            this.medidorcitoDB.Lecturas.Add(lectura);
            this.medidorcitoDB.SaveChanges();
        }

        public void EliminarLectura(int id)
        {
            Lectura lectura = this.medidorcitoDB.Lecturas.Find(id);
            this.medidorcitoDB.Lecturas.Remove(lectura);
            this.medidorcitoDB.SaveChanges();
        }

        public Lectura Obtener(int id)
        {
            return this.medidorcitoDB.Lecturas.Find(id);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidorcitoDB.Lecturas.ToList();
        }

        public void Actualizar(Lectura l) 
        {
            Lectura lOriginal = this.medidorcitoDB.Lecturas.Find(l.Id);
            lOriginal.Minuto = l.Minuto;
            lOriginal.Hora = l.Hora;
            lOriginal.Fecha = l.Fecha;
            lOriginal.Consumo = l.Consumo;
            this.medidorcitoDB.SaveChanges();
        }

        public List<Lectura> ObtenerLecturas(string fecha)
        {
            var query = from l in this.medidorcitoDB.Lecturas
                        where l.Fecha == fecha
                        select l;
            return query.ToList();
        }
    }
}
