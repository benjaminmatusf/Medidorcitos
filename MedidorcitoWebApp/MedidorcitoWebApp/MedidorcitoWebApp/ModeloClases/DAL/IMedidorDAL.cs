using ModeloClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DAL
{
    public interface IMedidorDAL
    {

        List<Medidor> ObtenerMedidores();

        void Agregar(Medidor medidor);

        List<Medidor> Filtrar(int tipo);


    }
}
