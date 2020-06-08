using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion.Modelos
{
    public class Persona
    {

        public Persona(double minuto_llegado, string evento)
        {
            this.Minuto_llegada = minuto_llegado;
            this.Evento = evento;
            Historico = new List<string[]>();
        }

        public double Minuto_llegada { get; set; }

        public double Minuto_Salida { get; set; }

        public Estado Estado { get; set; }

        public string Evento { get; set; }

        public double Evento_tiempo { get; set; }

        public int CantLibrosRetirados { get; set; }
        
        public int Numero { get; set; }

        public List<string[]> Historico { get; set; }
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
