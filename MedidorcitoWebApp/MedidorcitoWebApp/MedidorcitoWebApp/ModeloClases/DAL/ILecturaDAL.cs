using ModeloClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DAL
{
    public interface ILecturaDAL
    {

        List<Lectura> Obtener();
        void Agregar(Lectura lectura);

        List<Lectura> Filtrar(Medidor medidorLectura);
    }
}
