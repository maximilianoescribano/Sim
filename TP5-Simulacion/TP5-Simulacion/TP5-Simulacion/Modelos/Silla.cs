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
        public Silla()
        {
            Libre = true;
        }

        public bool Libre { get; set; }

        public double TiempoFinAtencion { get; set; }

        public Persona persona { get; set; }

        public string GetTiempoAtencion() => TiempoFinAtencion == 0 ? "-" : TiempoFinAtencion.ToString();

        public string GetEstado() => this.Libre ? "Libre" : "Ocupado";
    }
}
