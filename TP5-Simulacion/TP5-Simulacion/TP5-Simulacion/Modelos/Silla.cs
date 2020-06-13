using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion.Modelos
{
   public class Silla
    {
        public Silla(int numero)
        {
            Libre = true;
            Numero = numero;
        }

        public int Numero { get; set; }

        public bool Libre { get; set; }

        public double TiempoFinAtencion { get; set; }

        public Persona Persona { get; set; }

        public string GetTiempoAtencion() => TiempoFinAtencion == 0 ? "-" : TiempoFinAtencion.ToString();

        public string GetEstado() => this.Libre ? "Libre" : "Ocupado";
    }
}
