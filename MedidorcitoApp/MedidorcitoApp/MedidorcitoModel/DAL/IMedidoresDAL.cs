using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorcitoModel.DAL
{
    public interface IMedidoresDAL
    {

        List<Medidor> ObtenerMedidores();

        void Agregar(Medidor medidor);

        void EliminarMedidor(int id);
    }
}
