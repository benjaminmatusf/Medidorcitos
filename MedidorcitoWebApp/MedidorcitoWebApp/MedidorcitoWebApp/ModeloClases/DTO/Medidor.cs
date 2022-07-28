using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloClases.DTO
{
    public class Medidor
    {
        
        private int numeroSerie;


        private int tipo;

        public string TipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (tipo)
                {
                    case 1:
                        tipoTxt = "Medidor de enchufe";
                        break;
                    case 2:
                        tipoTxt = "Medidor con monitor";
                        break;
                }
                return tipoTxt;
            }
        }

        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
