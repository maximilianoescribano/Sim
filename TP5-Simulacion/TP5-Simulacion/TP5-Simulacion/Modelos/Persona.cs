using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion.Modelos
{
    public class Persona
    {

        public Persona(int minuto_llegado)
        {
            this.Minuto_llegada = minuto_llegado;
        }

        public int Minuto_llegada { get; set; }

        public int Minuto_Salida { get; set; }

        public Estado Estado { get; set; }

        public int CantLibrosRetirados { get; set; }
    }


    public enum Estado
    {
        SADL,
        SARL,
        SAC,
        EA,
        LB,
        EAB
    }
}
