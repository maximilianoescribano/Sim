using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5_Simulacion.Modelos;

namespace TP5_Simulacion
{
    public partial class Form1 : Form
    {

        List<Persona> lista_personas;
        private int contador;

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

            lista_personas = new List<Persona>();
            contador = 0;


            var cola_empleado = new List<Persona>();

            var cola_silla = new List<Persona>();

            var lista_empledos = new List<Empleado>()
            {
                new Empleado(1),
                new Empleado(2)
            };

            var lista_sillas = new List<Silla>()
            {
                new Silla(1),
                new Silla(2),
                new Silla(3),
                new Silla(4),
                new Silla(5),
            };


            var reloj = (double)txtEntradaPersonas.Value;

            var persona_ultima_llegada = 0;

            var persona_proxima_llegada = persona_ultima_llegada + reloj;

            gridSimulacion.Rows.Clear();

            var rnd = new Random();

            gridSimulacion.Rows.Add(new[] { "0", "Inicializacion", "0", $"{txtEntradaPersonas.Value}", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" });

            var num_persona = 1;

            for (int i = 1; i < txtCantMinutos.Value; i++)
            {

                double tiempo_atencion = 0;

                if (reloj > (double)txtCantMinutos.Value)
                {
                    Fin_simulacion();
                    break;
                }

                #region nueva persona

                if (persona_proxima_llegada < (lista_empledos.Any(x => !x.Libre) ? lista_empledos.Where(x => !x.Libre).Min(x => x.TiempoFinAtencion) : double.MaxValue) &&
                    persona_proxima_llegada < (lista_sillas.Any(x => !x.Libre) ? lista_sillas.Where(x => !x.Libre).Min(x => x.TiempoFinAtencion) : double.MaxValue))
                {
                    //calcular tipo atencion 
                    var random_atencion = rnd.NextDouble().TruncateDouble(4);
                    var evento = GetTipoAtencion(random_atencion);

                    double rnd_dev = 0, rnd_pr = 0, rnd_con = 0;

                    reloj = persona_proxima_llegada;

                    //creo nueva persona
                    var persona = new Persona(reloj, evento) { Numero = num_persona };
                    lista_personas.Add(persona);
                    num_persona++;

                    //calculo tiempos segun eventos y cambio estado
                    if (evento == "Devolver Libro")
                    {
                        rnd_dev = GetRandomSum();
                        tiempo_atencion = GetTiempoAtencionDevolucion(rnd_dev);
                        persona.Estado = Estado.AtendidoDevolucionLibro;
                    }
                    if (evento == "Retirar Libro")
                    {
                        rnd_pr = rnd.NextDouble().TruncateDouble(4);
                        tiempo_atencion = GetTiempoAtencionPrestamo(rnd_pr);
                        persona.Estado = Estado.AtendidoRetirarLibro;
                    }
                    if (evento == "Realizar Consulta")
                    {
                        rnd_con = rnd.NextDouble().TruncateDouble(4);
                        tiempo_atencion = GetTiempoAtencionConsulta(rnd_con);
                        persona.Estado = Estado.AtendidoConsulta;
                    }

                    persona.Evento_tiempo = tiempo_atencion;
                    //chekeo algun empleado libre para atenderlo y lo asigno
                    var empleado_libre = lista_empledos.FirstOrDefault(x => x.Libre);

                    if (empleado_libre != null)
                    {
                        empleado_libre.Libre = false;
                        empleado_libre.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_libre.Atendiendo = persona;
                    }
                    else //no hya empleados libres mando a cola y cambio estado
                    {

                        persona.Estado = (persona.Estado == Estado.AtendidoDevolucionLibro)
                            ? Estado.EsperandoAtencionDevolucion
                            : (persona.Estado == Estado.AtendidoConsulta
                                ? Estado.EsperandoAtencionConsulta
                                : Estado.EsperandoAtencionRetirar);
                        cola_empleado.Add(persona);
                    }

                    var tiempo_devolver_grilla = rnd_dev == 0 ? "-" : tiempo_atencion.ToStringGrid();
                    var tiempo_retirar_grilla = rnd_pr == 0 ? "-" : tiempo_atencion.ToStringGrid();
                    var tiempo_consultar_grilla = rnd_con == 0 ? "-" : tiempo_atencion.ToStringGrid();

                    //genero fila de la grilla
                    AddRowsToGrid(reloj, new[]
                      {
                            $"{i}", $"llega_persona_{persona.Numero}", $"{reloj}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada+ (double)txtEntradaPersonas.Value}",
                            $"{random_atencion}", $"{evento}",
                            $"{rnd_dev.ToStringGrid()}",$"{tiempo_devolver_grilla}" ,
                             $"{rnd_pr.ToStringGrid()}",$"{tiempo_retirar_grilla}" ,
                            $"{rnd_con.ToStringGrid()}",$"{tiempo_consultar_grilla}" ,
                            $"{lista_empledos[0].GetTiempoAtencion()}", $"{lista_empledos[1].GetTiempoAtencion()}", "-", "-", "-",
                             $"{lista_sillas[0].GetTiempoAtencion()}",$"{lista_sillas[1].GetTiempoAtencion()}", $"{lista_sillas[2].GetTiempoAtencion()}", $"{lista_sillas[3].GetTiempoAtencion()}", $"{lista_sillas[4].GetTiempoAtencion()}",
                             $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida - x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}",

                              $"{lista_empledos[0].GetEstado()}",$"{lista_empledos[1].GetEstado()}", $"{cola_empleado.Count}",
                             $"{lista_sillas[0].GetEstado()}",$"{lista_sillas[1].GetEstado()}", $"{lista_sillas[2].GetEstado()}", $"{lista_sillas[3].GetEstado()}", $"{lista_sillas[4].GetEstado()}",$"{cola_silla.Count}"
                        });

                    persona.Historico.Add(new[] { reloj.ToString(), persona.Minuto_llegada.ToString(), persona.Estado.ToString() });
                    persona_proxima_llegada = persona_proxima_llegada + (double)txtEntradaPersonas.Value;
                    continue;
                }

                #endregion nueva persona

                #region empleados

                if (lista_empledos.Where(x => !x.Libre).Min(x => x.TiempoFinAtencion) < (lista_sillas.Any(x => !x.Libre) ?
                    lista_sillas.Where(x => !x.Libre).Min(x => x.TiempoFinAtencion) : double.MaxValue))
                {

                    var evento_to_show = "";
                    string show = "-";
                    var accion = "-";
                    double random_accion = 0;
                    //empleado menor tiempo
                    var empleado =
                        lista_empledos.Where(x => !x.Libre).FirstOrDefault(
                            x => x.TiempoFinAtencion == lista_empledos.Min(y => y.Libre ? double.MaxValue : y.TiempoFinAtencion));

                    if (empleado == null) throw new ArgumentNullException(nameof(empleado));

                    //mayor tiempo termina simulacion
                    if (empleado.TiempoFinAtencion > (double)txtCantMinutos.Value)
                    {
                        Fin_simulacion();
                        break;
                    }

                    if (empleado.Atendiendo.Estado == Estado.AtendidoDevolucionLibro)
                    {
                        evento_to_show = $"fin_devolucion_{empleado.Atendiendo.Numero}";
                    }

                    if (empleado.Atendiendo.Estado == Estado.AtendidoRetirarLibro)
                    {
                        evento_to_show = $"fin_retiro_{empleado.Atendiendo.Numero}";

                        random_accion = rnd.NextDouble().TruncateDouble(4);
                        accion = GetAccionPersona(random_accion);
                        show = accion == "Lee Biblioteca" ? txtTiempoLectura.Value.ToString() : "-";
                        if (accion == "Lee Biblioteca")
                            empleado.Atendiendo.Estado = Estado.LeyendoBiblioteca;
                        cola_silla.Add(empleado.Atendiendo);
                    }

                    if (empleado.Atendiendo.Estado == Estado.AtendidoConsulta)
                    {
                        evento_to_show = $"fin_consulta_{empleado.Atendiendo.Numero}";
                    }

                    if (empleado.Atendiendo.Estado != Estado.LeyendoBiblioteca)
                        empleado.Atendiendo.Minuto_Salida = empleado.TiempoFinAtencion;

                    if (cola_empleado.Any())
                    {
                        var esperando = cola_empleado.First();

                        esperando.Historico.Add(new[]
                            {reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString()});

                        var empleado_1_time = empleado.Numero == 1
                            ? empleado.TiempoFinAtencion + esperando.Evento_tiempo
                            : lista_empledos[0].TiempoFinAtencion;

                        var empleado_2_time = empleado.Numero == 2
                           ? empleado.TiempoFinAtencion + esperando.Evento_tiempo
                           : lista_empledos[1].TiempoFinAtencion;

                        empleado.Libre = false;

                        AddRowsToGrid(reloj, new[]
                        {
                            $"{i}", $"{evento_to_show}",
                            $"{empleado.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", "-", "-", "-", "-", "-", "-", "-",
                             $"{empleado_1_time}", $"{empleado_2_time}",$"{random_accion.ToStringGrid()}", $"{accion}",  $"{show}",
                            $"{lista_sillas[0].GetTiempoAtencion()}",$"{lista_sillas[1].GetTiempoAtencion()}", $"{lista_sillas[2].GetTiempoAtencion()}", $"{lista_sillas[3].GetTiempoAtencion()}", $"{lista_sillas[4].GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida - x.Minuto_llegada))}",
                            $"{lista_personas.Count(x => x.Minuto_Salida > 0)}",
                             $"{lista_empledos[0].GetEstado()}",$"{lista_empledos[1].GetEstado()}", $"{cola_empleado.Count}",
                             $"{lista_sillas[0].GetEstado()}",$"{lista_sillas[1].GetEstado()}", $"{lista_sillas[2].GetEstado()}", $"{lista_sillas[3].GetEstado()}", $"{lista_sillas[4].GetEstado()}",$"{cola_silla.Count}"
                        });

                        
                        empleado.TiempoFinAtencion = empleado.TiempoFinAtencion + esperando.Evento_tiempo;
                        empleado.Atendiendo = esperando;
                        cola_empleado.RemoveAt(0);
                        continue;
                    }
                    else
                    {


                        var empleado_1_time = empleado.Numero == 1
                            ? "-"
                            : lista_empledos[0].GetTiempoAtencion();

                        var empleado_2_time = empleado.Numero == 2
                           ? "-"
                           : lista_empledos[1].GetTiempoAtencion();

                        empleado.Libre = true;

                        AddRowsToGrid(reloj, new[]
                        {
                            $"{i}", $"{evento_to_show}",
                            $"{empleado.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", "-", "-", "-", "-", "-", "-", "-",
                            $"{empleado_1_time}", $"{empleado_2_time}", "-", "-", "-",
                            $"{lista_sillas[0].GetTiempoAtencion()}",$"{lista_sillas[1].GetTiempoAtencion()}", $"{lista_sillas[2].GetTiempoAtencion()}", $"{lista_sillas[3].GetTiempoAtencion()}", $"{lista_sillas[4].GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida - x.Minuto_llegada))}",
                            $"{lista_personas.Count(x => x.Minuto_Salida > 0)}",
                              $"{lista_empledos[0].GetEstado()}",$"{lista_empledos[1].GetEstado()}", $"{cola_empleado.Count}",
                             $"{lista_sillas[0].GetEstado()}",$"{lista_sillas[1].GetEstado()}", $"{lista_sillas[2].GetEstado()}", $"{lista_sillas[3].GetEstado()}", $"{lista_sillas[4].GetEstado()}",$"{cola_silla.Count}"
                        });
                    }

                    empleado.Atendiendo = null;
                    empleado.TiempoFinAtencion = 0;
                    continue;
                }

                #endregion empleados


                #region silla 

                var silla =
                       lista_sillas.Where(x => !x.Libre).FirstOrDefault(
                           x => x.TiempoFinAtencion == lista_sillas.Min(y => y.TiempoFinAtencion));

                if (silla == null) throw new ArgumentNullException(nameof(silla));


                if (silla.TiempoFinAtencion > (double)txtCantMinutos.Value)
                {
                    Fin_simulacion();
                    break;
                }

                var rnd_rl1 = GetRandomSum();
                tiempo_atencion = GetTiempoAtencionDevolucion(rnd_rl1);

                silla.Persona.Evento_tiempo = tiempo_atencion;
                silla.Persona.Estado = Estado.AtendidoDevolucionLibro;
                silla.Persona.Historico.Add(new[] { reloj.ToString(), silla.Persona.Minuto_llegada.ToString(), silla.Persona.Estado.ToString() });

                //chekeo algun empleado libre para atenderlo y lo asigno
                var empleado_libre_silla = lista_empledos.FirstOrDefault(x => x.Libre);

                if (empleado_libre_silla != null)
                {
                    empleado_libre_silla.Libre = false;
                    empleado_libre_silla.TiempoFinAtencion = reloj + tiempo_atencion;
                    empleado_libre_silla.Atendiendo = silla.Persona;
                }
                else //no hya empleados libres mando a cola y cambio estado
                {

                    silla.Persona.Estado = (silla.Persona.Estado == Estado.AtendidoDevolucionLibro)
                        ? Estado.EsperandoAtencionDevolucion
                        : (silla.Persona.Estado == Estado.AtendidoConsulta
                            ? Estado.EsperandoAtencionConsulta
                            : Estado.EsperandoAtencionRetirar);
                    cola_empleado.Add(silla.Persona);
                }

                AddRowsToGrid(reloj, new[]
                    {
                        $"{i}", $"fin_lectura_{silla.Persona.Numero}", $"{silla.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                        "-", $"Devolver Libro", $"{rnd_rl1}",
                        $"{tiempo_atencion}", "-", "-", "-", "-",
                         $"{lista_empledos[0].GetTiempoAtencion()}", $"{lista_empledos[1].GetTiempoAtencion()}", "-", "-", "-",
                   $"{lista_sillas[0].GetTiempoAtencion()}",$"{lista_sillas[1].GetTiempoAtencion()}", $"{lista_sillas[2].GetTiempoAtencion()}", $"{lista_sillas[3].GetTiempoAtencion()}", $"{lista_sillas[4].GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida - x.Minuto_llegada))}",
                            $"{lista_personas.Count(x => x.Minuto_Salida > 0)}",
                              $"{lista_empledos[0].GetEstado()}",$"{lista_empledos[1].GetEstado()}", $"{cola_empleado.Count}",
                             $"{lista_sillas[0].GetEstado()}",$"{lista_sillas[1].GetEstado()}", $"{lista_sillas[2].GetEstado()}", $"{lista_sillas[3].GetEstado()}", $"{lista_sillas[4].GetEstado()}",$"{cola_silla.Count}"

                    });

                silla.Persona = null;
                silla.Libre = true;
                silla.TiempoFinAtencion = 0;

                #endregion silla 





            }


            label8.Text = $"{(lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida - x.Minuto_llegada)) / lista_personas.Count(x => x.Minuto_Salida > 0)).TruncateDouble(2)} minutos ";

        }




        private string GetTipoAtencion(double rand)
        {
            if (rand < (double)txtProbAtencion0.Value)
                return "Devolver Libro";
            return rand >= (double)(txtProbAtencion0.Value + txtProbAtencion1.Value) ? "Realizar Consulta" : "Retirar Libro";
        }

        private string GetAccionPersona(double rand)
        {
            return rand < (double)txtProbRetiraB.Value ? "Se Retira" : "Lee Biblioteca";
        }


        private double GetRandomSum()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            var rand = 0.0;
            for (var i = 0; i < 11; i++)
                rand += rnd.NextDouble().TruncateDouble(4);
            return rand;
        }

        private double GetTiempoAtencionDevolucion(double rand)
        {
            return (rand * (double)txtDevolucionDesv.Value) + (double)txtDevolucionMedia.Value;
        }

        private double GetTiempoAtencionPrestamo(double rnd)
        {
            return ((double)-txtRetiraExpMedia.Value * Math.Log(1 - rnd)).TruncateDouble(4);
        }

        private double GetTiempoAtencionConsulta(double rnd)
        {
            return ((double)txtConsultasRA.Value +
                   rnd * ((double)txtConsultasRB.Value - (double)txtConsultasRA.Value)).TruncateDouble(4);
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

        private void gridSimulacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 34)
            {
                grillaObjetos.Columns.Clear();
                grillaObjetos.Rows.Clear();
                grillaObjetos.Columns.Add($"Fila_obj", $"Fila");
                grillaObjetos.Columns.Add($"rlj_min", $"Reloj (min)");
                var b = double.Parse(gridSimulacion.Rows[e.RowIndex].Cells[2].Value.ToString());
                var fila = int.Parse(gridSimulacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                var personasMostrar = lista_personas.Where(x => (x.Minuto_Salida == 0 && x.Minuto_llegada <= b) || x.Minuto_Salida >= b && x.Minuto_llegada <= b);
                var str_to_show = new List<string>();
                str_to_show.Add($"{fila}");
                str_to_show.Add($"{b}");
                foreach (var personas in personasMostrar)
                {
                    grillaObjetos.Columns.Add($"persona{personas.Numero}", $"Persona {personas.Numero}");
                    if (personas.Historico.Count > 1)
                    {
                        var to_show = personas.Historico.Where(x => double.Parse(x[0]) <= b).Last();
                        str_to_show.Add($"Minuto llego = {to_show[1]} , Estado = {to_show[2]} ");

                        //for (var i = 0; i < personas.Historico.Count; i++)
                        //{
                        //    if(double.Parse(personas.Historico[i][0]) > b)
                        //        str_to_show.Add($"Minuto llego = {personas.Historico[i-1][1]} , Estado = {personas.Historico[i-1][2]} ");

                        //}
                    }
                    else
                    {
                        str_to_show.Add($"Minuto llego = {personas.Historico.Last()[1]} , Estado = {personas.Historico.Last()[2]} ");
                    }


                }

                grillaObjetos.Rows.Add(str_to_show.ToArray());
                tabControl1.SelectedIndex = 1;
            }
        }

        private void AddRowsToGrid(double reloj, string[] row)
        {

            if ((double)txtDesde.Value < reloj && contador < (double)txtHasta.Value && (double)txtCantMinutos.Value >= reloj)
            {
                gridSimulacion.Rows.Add(row);
                contador++;
            }
        }

        private void Fin_simulacion()
        {

            var ultima_fila = gridSimulacion.Rows[gridSimulacion.Rows.Count - 1].Cells;

            gridSimulacion.Rows.Add(new[] { "-", "Fin Simulacion", $"{txtCantMinutos.Value}",
               "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-",  $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",
                $"{lista_personas.Count(x => x.Minuto_Salida > 0)}", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" });



        }
    }

    public static class Helpers
    {
        public static double TruncateDouble(this double value, double precision)
        {
            var val = Math.Pow(10, precision);
            return (Math.Truncate(val * value)) / val;
        }

        public static string ToStringGrid(this double value) => value == 0 ? "-" : value.ToString();
    }
}
