using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Simulacion.Modelos
{
   public class Empleado
    {

        public Empleado()
        {
            Libre = true;
        }

        public bool Libre { get; set; }

        public double TiempoFinAtencion { get; set; }

        public Persona Atendiendo { get; set; }
    }
}
