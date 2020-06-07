using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_Simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (CheckValues())
                Simular();
        }

        private void Simular()
        {
            gridSimulacion.Rows.Clear();
            var rnd = new Random();
            gridSimulacion.Rows.Add(new[] {"0", "Inicializacion", "4", "4", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" });
            for (int i = 1; i < txtCantMinutos.Value; i++)
            {
                var random = rnd.NextDouble().TruncateDouble(4);
                var evento = GetTipoAtencion(random);
                gridSimulacion.Rows.Add(new[] { $"{i}", $"llega_persona_{i}", "4", "8", $"{random}", $"{evento}", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" });
               
            }
        }




        private string GetTipoAtencion(double rand)
        {
            if (rand < (double) txtProbAtencion0.Value)
                return "Recibir Libro";
            return rand >= (double)(txtProbAtencion0.Value + txtProbAtencion1.Value) ? "Realizar Consulta" : "Prestar Libro";
        }

        private string GetAccionPersona(double rand)
        {
            return rand < (double)txtProbRetiraB.Value ? "Se Retira" : "Lee Biblioteca";
        }

        private double GetTiempoAtencionDevolucion()
        {
            var rnd = new Random();
            var sum = 0.0;
            for (var i = 0; i < 11; i++)
                sum += rnd.NextDouble();
            return (sum * (double)txtDevolucionDesv.Value) + (double)txtDevolucionMedia.Value;
        }

        private double GetTiempoAtencionPrestamo()
        {
            var rnd = new Random();
            return ((double)txtRetiraExpMedia.Value * Math.Log(1 - rnd.NextDouble()));
        }

        private double GetTiempoAtencionConsulta()
        {
            var rnd = new Random();
            return (double) txtConsultasRA.Value +
                   rnd.NextDouble() * ((double) txtConsultasRB.Value - (double) txtConsultasRA.Value);
        }





        private bool CheckValues()
        {
            //if(txtHasta.Value > txtCantMinutos.Value)
            //{
            //    MessageBox.Show($"Hasta debe ser un número menor o igual a {txtCantMinutos.Value}");
            //    txtHasta.Focus();
            //    return false;

            //}

            if (txtDesde.Value > txtHasta.Value)
            {
                MessageBox.Show($"Desde debe ser un número menor o igual a {txtHasta.Value}");
                txtHasta.Focus();
                return false;

            }

            if (!ValidateProbAtencion())
            {
                MessageBox.Show("La sumatoria de probabilidades de Atencion debe ser igual a 1");
                txtHasta.Focus();
                return false;

            }

            if (!ValidateProDspRetiro())
            {
                MessageBox.Show("La sumatoria de probabilidades de Personas Despues de Retiro debe ser igual a 1");
                txtHasta.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateProDspRetiro()
        {
            var probTotal = 0.0;
            probTotal += (double)txtProbAtencion0.Value;
            probTotal += (double)txtProbAtencion1.Value;
            probTotal += (double)txtProbAtencion2.Value;
            return probTotal.Equals(1.0);
        }

        private bool ValidateProbAtencion()
        {
            var probTotal = 0.0;
            probTotal += (double)txtProbRetiraB.Value;
            probTotal += (double)txtProbQuedaB.Value;
            return probTotal.Equals(1.0);
        }
    }

    public static class Helpers
    {
        public static double TruncateDouble(this double value, double precision)
        {
            var val = Math.Pow(10, precision);
            return (Math.Truncate(val * value)) / val;
        }

     
    }
}
