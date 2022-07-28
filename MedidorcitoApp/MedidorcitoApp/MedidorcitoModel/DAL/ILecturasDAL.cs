using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorcitoModel.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();
        List<Lectura> ObtenerLecturas(string estado);
        Lectura Obtener(int id);
        void AgregarLectura(Lectura lectura);
        void EliminarLectura(int id);
    }
}
