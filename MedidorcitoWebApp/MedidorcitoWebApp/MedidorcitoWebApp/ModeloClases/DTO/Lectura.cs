using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DTO
{
    public class Lectura
    {
        private Medidor medidorLectura;
        private string fecha;
        private int hora;
        private int minuto;
        private int consumo;


        public string Fecha { get => fecha; set => fecha = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public Medidor MedidorLectura { get => medidorLectura; set => medidorLectura = value; }
    }
}
