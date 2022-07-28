using ModeloClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void Agregar(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> Filtrar(int tipo) { 
        
        return medidores.FindAll(m => m.Tipo == tipo);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
