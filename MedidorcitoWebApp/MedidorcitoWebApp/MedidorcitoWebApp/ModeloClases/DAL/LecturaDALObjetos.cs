using ModeloClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DAL
{
    public class LecturaDALObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> Filtrar(Medidor medidorLectura)
        {

            return lecturas.FindAll(l => l.MedidorLectura == medidorLectura);
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }
    }
}
