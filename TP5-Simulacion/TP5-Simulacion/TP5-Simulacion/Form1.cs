using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5_Simulacion.Modelos;

namespace TP5_Simulacion
{
    public partial class Form1 : Form
    {

        List<Persona> lista_personas;

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
            var lista_reloj = new List<double>();

            var cola_empleado = new List<Persona>();

            var cola_silla = new List<Persona>();

            var empleado_1 = new Empleado();
            var empleado_2 = new Empleado();
            var silla1 = new Silla();
            var silla2 = new Silla();
            var silla3 = new Silla();
            var silla4 = new Silla();
            var silla5 = new Silla();

            var reloj = (double)txtEntradaPersonas.Value;
            var persona_ultima_llegada = 0;
            var persona_proxima_llegada = persona_ultima_llegada + reloj;

            gridSimulacion.Rows.Clear();

            var rnd = new Random();
            gridSimulacion.Rows.Add(new[] { "0", "Inicializacion", "0", $"{txtEntradaPersonas.Value}", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" });
            var num_persona = 1;

            for (int i = 1; i < txtCantMinutos.Value; i++)
            {
                var random_atencion = rnd.NextDouble().TruncateDouble(4);
                var evento = GetTipoAtencion(random_atencion);

                double rnd_rl = 0, rnd_rc, rnd_pl;
                double tiempo_atencion = 0;

                #region nueva persona

                if ((persona_proxima_llegada < empleado_1.TiempoFinAtencion || empleado_1.Libre) &&
                    (persona_proxima_llegada < empleado_2.TiempoFinAtencion || empleado_2.Libre) &&
                    (persona_proxima_llegada < silla1.TiempoFinAtencion || silla1.Libre) &&
                    (persona_proxima_llegada < silla2.TiempoFinAtencion || silla2.Libre) &&
                    (persona_proxima_llegada < silla3.TiempoFinAtencion || silla3.Libre) &&
                    (persona_proxima_llegada < silla4.TiempoFinAtencion || silla4.Libre) &&
                    (persona_proxima_llegada < silla5.TiempoFinAtencion || silla5.Libre))
                {
                    reloj = persona_proxima_llegada;
                    var persona = new Persona(reloj, evento) { Numero = num_persona };
                    lista_personas.Add(persona);
                    num_persona++;
                    if (evento == "Recibir Libro")
                    {
                        tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);
                        persona.Evento_tiempo = tiempo_atencion;
                        var bandera = true;
                        persona.Estado = Estado.SADL;
                       
                        if (empleado_1.Libre && bandera)
                        {
                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_1.Atendiendo = persona;
                            bandera = false;
                        }
                        if (empleado_2.Libre && bandera)
                        {
                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_2.Atendiendo = persona;
                            bandera = false;
                        }
                        if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                        {
                            persona.Estado = Estado.EA;
                            cola_empleado.Add(persona);
                        }

                        gridSimulacion.Rows.Add(new[]
                        {
                            $"{i}", $"llega_persona_{persona.Numero}", $"{reloj}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada+ (double)txtEntradaPersonas.Value}",
                            $"{random_atencion}", $"{evento}", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                             $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                             $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });
                    }
                    if (evento == "Prestar Libro")
                    {
                        rnd_rc = rnd.NextDouble().TruncateDouble(4);
                        tiempo_atencion = GetTiempoAtencionPrestamo(rnd_rc);
                        persona.Evento_tiempo = tiempo_atencion;
                        var bandera = true;
                        persona.Estado = Estado.SARL;
                        if (empleado_1.Libre && bandera)
                        {
                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_1.Atendiendo = persona;
                            bandera = false;
                        }
                        if (empleado_2.Libre && bandera)
                        {
                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_2.Atendiendo = persona;
                            bandera = false;
                        }
                        if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                        {
                            persona.Estado = Estado.EA;
                            cola_empleado.Add(persona);
                        }

                        gridSimulacion.Rows.Add(new[]
                        {
                            $"{i}", $"llega_persona_{persona.Numero}", $"{reloj}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada+ (double)txtEntradaPersonas.Value}",
                            $"{random_atencion}", $"{evento}", "-",
                            "-", $"{rnd_rc}", $"{tiempo_atencion}", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                             $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                             $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });
                    }

                    if (evento == "Realizar Consulta")
                    {
                        rnd_pl = rnd.NextDouble().TruncateDouble(4);
                        tiempo_atencion = GetTiempoAtencionConsulta(rnd_pl);
                        persona.Evento_tiempo = tiempo_atencion;
                        var bandera = true;
                        persona.Estado = Estado.SAC;
                        if (empleado_1.Libre && bandera)
                        {
                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_1.Atendiendo = persona;
                            bandera = false;
                        }
                        if (empleado_2.Libre && bandera)
                        {
                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                            empleado_2.Atendiendo = persona;
                            bandera = false;
                        }
                        if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                        {
                            persona.Estado = Estado.EA;
                            cola_empleado.Add(persona);
                        }

                        gridSimulacion.Rows.Add(new[]
                        {
                            $"{i}", $"llega_persona_{persona.Numero}", $"{reloj}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada+ (double)txtEntradaPersonas.Value}",
                            $"{random_atencion}", $"{evento}", "-",
                            "-", "-", "-", $"{rnd_pl}", $"{tiempo_atencion}", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                             $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                             $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });
                    }
                    persona.Historico.Add(new[] { reloj.ToString(), persona.Minuto_llegada.ToString(), persona.Estado.ToString() });
                    persona_proxima_llegada = persona_proxima_llegada + (double)txtEntradaPersonas.Value;
                    continue;
                }

                #endregion nueva persona

                #region empleado 1

                if (((empleado_1.TiempoFinAtencion < empleado_2.TiempoFinAtencion || empleado_2.Libre) &&
                    (empleado_1.TiempoFinAtencion < silla1.TiempoFinAtencion || silla1.Libre) &&
                    (empleado_1.TiempoFinAtencion < silla2.TiempoFinAtencion || silla2.Libre) &&
                    (empleado_1.TiempoFinAtencion < silla3.TiempoFinAtencion || silla3.Libre) &&
                    (empleado_1.TiempoFinAtencion < silla4.TiempoFinAtencion || silla4.Libre) &&
                    (empleado_1.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !empleado_1.Libre)
                {
                    

                    if (empleado_1.Atendiendo.Estado == Estado.SADL)
                    {
                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_devolucion_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion + esperando.Evento_tiempo}", $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                                 $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = empleado_1.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_1.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);

                            continue;
                        }
                        else
                        {
                            empleado_1.Atendiendo.Minuto_Salida = empleado_1.TiempoFinAtencion;
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_devolucion_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                                 $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                        }
                        
                    }

                    if (empleado_1.Atendiendo.Estado == Estado.SARL)
                    {
                        var random_accion = rnd.NextDouble().TruncateDouble(4);
                        var accion = GetAccionPersona(random_atencion);
                        var show = accion == "Lee Biblioteca" ? txtTiempoLectura.Value.ToString() : "-";
                        string silla1txt = "-", silla2txt = "-", silla3txt = "-", silla4txt = "-", silla5txt = "-";

                        if (accion == "Lee Biblioteca")
                        {
                            if (!(silla1.Libre || silla2.Libre || silla3.Libre || silla4.Libre || silla5.Libre))
                            {
                                empleado_1.Atendiendo.Estado = Estado.EAB;
                                cola_silla.Add(empleado_1.Atendiendo);
                                empleado_1.Atendiendo.Historico.Add(new[]
                                {
                                    reloj.ToString(), empleado_1.Atendiendo.Minuto_llegada.ToString(),
                                    empleado_1.Atendiendo.Estado.ToString()
                                });
                            }
                            else
                            {
                                var bandera = true;
                                if (silla1.Libre)
                                {
                                    silla1.Libre = false;
                                    silla1.TiempoFinAtencion = empleado_1.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla1.persona = empleado_1.Atendiendo;
                                    silla1.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla2.Libre && bandera)
                                {
                                    silla2.Libre = false;
                                    silla2.TiempoFinAtencion = empleado_1.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla2.persona = empleado_1.Atendiendo;
                                    silla2.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla3.Libre && bandera)
                                {
                                    silla3.Libre = false;
                                    silla3.TiempoFinAtencion = empleado_1.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla3.persona = empleado_1.Atendiendo;
                                    silla3.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla4.Libre && bandera)
                                {
                                    silla4.Libre = false;
                                    silla4.TiempoFinAtencion = empleado_1.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla4.persona = empleado_1.Atendiendo;
                                    silla4.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla5.Libre && bandera)
                                {
                                    silla5.Libre = false;
                                    silla5.TiempoFinAtencion = empleado_1.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla5.persona = empleado_1.Atendiendo;
                                    silla5.persona.Estado = Estado.LB;
                                    bandera = false;
                                }

                            }
                            silla1txt = silla1.Libre ? "-" : silla1.TiempoFinAtencion.ToString();
                            silla2txt = silla2.Libre ? "-" : silla2.TiempoFinAtencion.ToString();
                            silla3txt = silla3.Libre ? "-" : silla3.TiempoFinAtencion.ToString();
                            silla4txt = silla4.Libre ? "-" : silla4.TiempoFinAtencion.ToString();
                            silla5txt = silla5.Libre ? "-" : silla5.TiempoFinAtencion.ToString();


                        }
                        else
                        {
                            empleado_1.Atendiendo.Minuto_Salida = empleado_1.TiempoFinAtencion;
                        }



                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_retiro_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion + esperando.Evento_tiempo}", $"{empleado_2.TiempoFinAtencion}", $"{random_accion}", $"{accion}", $"{show}", $"{silla1txt}",
                                 $"{silla2txt}",  $"{silla3txt}", $"{silla4txt}",  $"{silla5txt}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = empleado_1.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_1.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);

                            continue;
                        }
                        else
                        {
                           
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_retiro_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_2.TiempoFinAtencion}", $"{random_accion}", $"{accion}", $"{show}", $"{silla1txt}",
                                 $"{silla2txt}",  $"{silla3txt}", $"{silla4txt}",  $"{silla5txt}",
                                  $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                            
                        }



                    }

                    if (empleado_1.Atendiendo.Estado == Estado.SAC)
                    {
                        empleado_1.Atendiendo.Minuto_Salida = empleado_1.TiempoFinAtencion;
                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_consulta_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion + esperando.Evento_tiempo}", $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                                $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" , $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                            empleado_1.Libre = false;
                            empleado_1.TiempoFinAtencion = empleado_1.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_1.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);

                            continue;
                        }
                        else
                        {
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_consulta_{empleado_1.Atendiendo.Numero}",
                                $"{empleado_1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",
                                $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" , $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                        }

                    }

                    empleado_1.Libre = true;
                    empleado_1.TiempoFinAtencion = 0;
                    empleado_1.Atendiendo = null;

                    continue;
                }

                #endregion empleado 1

                #region empleado 2

                if (((empleado_2.TiempoFinAtencion < silla1.TiempoFinAtencion || silla1.Libre) &&
                   (empleado_2.TiempoFinAtencion < silla2.TiempoFinAtencion || silla2.Libre) &&
                   (empleado_2.TiempoFinAtencion < silla3.TiempoFinAtencion || silla3.Libre) &&
                   (empleado_2.TiempoFinAtencion < silla4.TiempoFinAtencion || silla4.Libre) &&
                   (empleado_2.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !empleado_2.Libre)
                {

                    

                    if (empleado_2.Atendiendo.Estado == Estado.SADL)
                    {
                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_devolucion_{empleado_2.Atendiendo.Numero}", $"{empleado_2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-","-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", $"{empleado_2.TiempoFinAtencion + esperando.Evento_tiempo}", "-", "-", "-",
                                 $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = empleado_2.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_2.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);

                            continue;
                        }
                        else
                        {
                            empleado_2.Atendiendo.Minuto_Salida = empleado_2.TiempoFinAtencion;
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_devolucion_{empleado_2.Atendiendo.Numero}", $"{empleado_2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-","-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", "-", "-", "-", "-",
                                 $"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                        }
                        
                    }

                    if (empleado_2.Atendiendo.Estado == Estado.SARL)
                    {

                        var random_accion = rnd.NextDouble().TruncateDouble(4);
                        var accion = GetAccionPersona(random_atencion);
                        var show = accion == "Lee Biblioteca" ? txtTiempoLectura.Value.ToString() : "-";
                        string silla1txt = "-", silla2txt = "-", silla3txt = "-", silla4txt = "-", silla5txt = "-";

                        if (accion == "Lee Biblioteca")
                        {
                            if (!(silla1.Libre || silla2.Libre || silla3.Libre || silla4.Libre || silla5.Libre))
                            {
                                empleado_2.Atendiendo.Estado = Estado.EAB;
                                cola_silla.Add(empleado_2.Atendiendo);
                            }
                            else
                            {
                                var bandera = true;
                                if (silla1.Libre)
                                {
                                    silla1.Libre = false;
                                    silla1.TiempoFinAtencion = empleado_2.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla1.persona = empleado_2.Atendiendo;
                                    silla1.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla2.Libre && bandera)
                                {
                                    silla2.Libre = false;
                                    silla2.TiempoFinAtencion = empleado_2.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla2.persona = empleado_2.Atendiendo;
                                    silla2.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla3.Libre && bandera)
                                {
                                    silla3.Libre = false;
                                    silla3.TiempoFinAtencion = empleado_2.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla3.persona = empleado_2.Atendiendo;
                                    silla3.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla4.Libre && bandera)
                                {
                                    silla4.Libre = false;
                                    silla4.TiempoFinAtencion = empleado_2.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla4.persona = empleado_2.Atendiendo;
                                    silla4.persona.Estado = Estado.LB;
                                    bandera = false;
                                }
                                if (silla5.Libre && bandera)
                                {
                                    silla5.Libre = false;
                                    silla5.TiempoFinAtencion = empleado_2.TiempoFinAtencion +
                                                               (double) txtTiempoLectura.Value;
                                    silla5.persona = empleado_2.Atendiendo;
                                    silla5.persona.Estado = Estado.LB;
                                    bandera = false;
                                }

                            }
                            silla1txt = silla1.Libre ? "-" : silla1.TiempoFinAtencion.ToString();
                            silla2txt = silla2.Libre ? "-" : silla2.TiempoFinAtencion.ToString();
                            silla3txt = silla3.Libre ? "-" : silla3.TiempoFinAtencion.ToString();
                            silla4txt = silla4.Libre ? "-" : silla4.TiempoFinAtencion.ToString();
                            silla5txt = silla5.Libre ? "-" : silla5.TiempoFinAtencion.ToString();
                            empleado_2.Atendiendo.Historico.Add(new[]
                            {
                                reloj.ToString(), empleado_2.Atendiendo.Minuto_llegada.ToString(),
                                empleado_2.Atendiendo.Estado.ToString()
                            });
                        }
                        else
                        {
                            empleado_2.Atendiendo.Minuto_Salida = empleado_2.TiempoFinAtencion;
                        }

                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_retiro_{empleado_2.Atendiendo.Numero}",
                                $"{empleado_2.TiempoFinAtencion}",$"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", $"{empleado_2.TiempoFinAtencion + esperando.Evento_tiempo}", $"{random_accion}", $"{accion}", $"{show}", $"{silla1txt}",
                                 $"{silla2txt}",  $"{silla3txt}", $"{silla4txt}",  $"{silla5txt}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = empleado_2.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_2.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);
                            continue;
                        }
                        else
                        {
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_retiro_{empleado_2.Atendiendo.Numero}",
                                $"{empleado_2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", "-",  $"{random_accion}", $"{accion}", $"{show}", $"{silla1txt}",
                                 $"{silla2txt}",  $"{silla3txt}", $"{silla4txt}",  $"{silla5txt}",
                                 $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                        }

                    }

                    if (empleado_2.Atendiendo.Estado == Estado.SAC)
                    {
                        if (cola_empleado.Any())
                        {
                            var esperando = cola_empleado.First();
                            esperando.Estado = Estado.SADL;
                            esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_consulta_{empleado_2.Atendiendo.Numero}",
                                $"{empleado_2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", $"{empleado_2.TiempoFinAtencion + esperando.Evento_tiempo}", "-", "-", "-",
                                $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" , $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                            empleado_2.Libre = false;
                            empleado_2.TiempoFinAtencion = empleado_2.TiempoFinAtencion + esperando.Evento_tiempo;
                            empleado_2.Atendiendo = esperando;
                            cola_empleado.RemoveAt(0);
                            continue;
                        }
                        else
                        {
                            empleado_2.Atendiendo.Minuto_Salida = empleado_2.TiempoFinAtencion;

                            gridSimulacion.Rows.Add(new[]
                            {
                                $"{i}", $"fin_atencion_consulta_{empleado_2.Atendiendo.Numero}",
                                $"{empleado_2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                                "-", "-", "-", "-", "-", "-", "-", "-", "-",
                                $"{empleado_1.TiempoFinAtencion}", "-", "-", "-",
                                $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" , $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                                $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });
                        }
                        
                    }



                    empleado_2.Libre = true;
                    empleado_2.TiempoFinAtencion = 0;
                    empleado_2.Atendiendo = null;
                    continue;

                }

                #endregion empleado 2

                #region silla 1

                if (((silla1.TiempoFinAtencion < silla2.TiempoFinAtencion || silla2.Libre) &&
                     (silla1.TiempoFinAtencion < silla3.TiempoFinAtencion || silla3.Libre) &&
                     (silla1.TiempoFinAtencion < silla4.TiempoFinAtencion || silla4.Libre) &&
                     (silla1.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !silla1.Libre)
                {

 
                    tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);

                    silla1.persona.Evento_tiempo = tiempo_atencion;
                    var bandera = true;
                    silla1.persona.Estado = Estado.SADL;
                    silla1.persona.Historico.Add(new[] { reloj.ToString(), silla1.persona.Minuto_llegada.ToString(), silla1.persona.Estado.ToString() });
                    if (empleado_1.Libre && bandera)
                    {
                        empleado_1.Libre = false;
                        empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_1.Atendiendo = silla1.persona;
                        bandera = false;
                    }
                    if (empleado_2.Libre && bandera)
                    {
                        empleado_2.Libre = false;
                        empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_2.Atendiendo = silla1.persona;
                        bandera = false;
                    }
                    if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                    {
                        silla1.persona.Estado = Estado.EA;
                        cola_empleado.Add(silla1.persona);
                    }

                    if (cola_silla.Any())
                    {
                        var esperando = cola_silla.First();
                        esperando.Estado = Estado.LB;
                        esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                        gridSimulacion.Rows.Add(new[]
                        {
                                $"{i}", $"fin_lectura_{silla1.persona.Numero}", $"{silla1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-", $"{silla1.TiempoFinAtencion + (double)txtTiempoLectura.Value}",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                        silla1.Libre = false;
                        silla1.TiempoFinAtencion = silla1.TiempoFinAtencion + (double)txtTiempoLectura.Value;
                        silla1.persona = esperando;
                        cola_silla.RemoveAt(0);

                        continue;
                    }

                    gridSimulacion.Rows.Add(new[]
                       {
                            $"{i}", $"fin_lectura_{silla1.persona.Numero}", $"{silla1.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-", "-",$"{silla2.GetTiempoAtencion()}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });

                    silla1.Libre = true;
                    silla1.TiempoFinAtencion = 0;
                    silla1.persona = null;
                    continue;

                }

                #endregion silla 1

                #region silla 2

                if (((silla2.TiempoFinAtencion < silla3.TiempoFinAtencion || silla3.Libre) &&
                     (silla2.TiempoFinAtencion < silla4.TiempoFinAtencion || silla4.Libre) &&
                     (silla2.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !silla2.Libre)
                {
                    tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);

                    silla2.persona.Evento_tiempo = tiempo_atencion;
                    var bandera = true;
                    silla2.persona.Estado = Estado.SADL;
                    silla2.persona.Historico.Add(new[] { reloj.ToString(), silla2.persona.Minuto_llegada.ToString(), silla2.persona.Estado.ToString() });
                    if (empleado_1.Libre && bandera)
                    {
                        empleado_1.Libre = false;
                        empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_1.Atendiendo = silla2.persona;
                        bandera = false;
                    }
                    if (empleado_2.Libre && bandera)
                    {
                        empleado_2.Libre = false;
                        empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_2.Atendiendo = silla2.persona;
                        bandera = false;
                    }
                    if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                    {
                        silla2.persona.Estado = Estado.EA;
                        cola_empleado.Add(silla2.persona);
                    }

                    if (cola_silla.Any())
                    {
                        var esperando = cola_silla.First();
                        esperando.Estado = Estado.LB;
                        esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                        gridSimulacion.Rows.Add(new[]
                        {
                                $"{i}", $"fin_lectura_{silla2.persona.Numero}", $"{silla2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",$"{silla1.GetTiempoAtencion()}", $"{silla2.TiempoFinAtencion + (double)txtTiempoLectura.Value}", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                        silla2.Libre = false;
                        silla2.TiempoFinAtencion = silla2.TiempoFinAtencion + (double)txtTiempoLectura.Value;
                        silla2.persona = esperando;
                        cola_silla.RemoveAt(0);

                        continue;
                    }


                    gridSimulacion.Rows.Add(new[]
                       {
                            $"{i}", $"fin_lectura_{silla2.persona.Numero}", $"{silla2.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-", $"{silla1.GetTiempoAtencion()}", "-", $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });

                    silla2.Libre = true;
                    silla2.TiempoFinAtencion = 0;
                    silla2.persona = null;
                    continue;

                }

                #endregion silla 2

                #region silla 3

                if (((silla3.TiempoFinAtencion < silla4.TiempoFinAtencion || silla4.Libre) &&
                     (silla3.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !silla3.Libre)
                {
                    tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);

                    silla3.persona.Evento_tiempo = tiempo_atencion;
                    var bandera = true;
                    silla3.persona.Estado = Estado.SADL;
                    silla3.persona.Historico.Add(new[] { reloj.ToString(), silla3.persona.Minuto_llegada.ToString(), silla3.persona.Estado.ToString() });
                    if (empleado_1.Libre && bandera)
                    {
                        empleado_1.Libre = false;
                        empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_1.Atendiendo = silla3.persona;
                        bandera = false;
                    }
                    if (empleado_2.Libre && bandera)
                    {
                        empleado_2.Libre = false;
                        empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_2.Atendiendo = silla3.persona;
                        bandera = false;
                    }
                    if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                    {
                        silla3.persona.Estado = Estado.EA;
                        cola_empleado.Add(silla3.persona);
                    }

                    if (cola_silla.Any())
                    {
                        var esperando = cola_silla.First();
                        esperando.Estado = Estado.LB;
                        esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                        gridSimulacion.Rows.Add(new[]
                        {
                                $"{i}", $"fin_lectura_{silla3.persona.Numero}", $"{silla3.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",$"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}" ,$"{silla3.TiempoFinAtencion + (double)txtTiempoLectura.Value}" , $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                        silla3.Libre = false;
                        silla3.TiempoFinAtencion = silla3.TiempoFinAtencion + (double)txtTiempoLectura.Value;
                        silla3.persona = esperando;
                        cola_silla.RemoveAt(0);

                        continue;
                    }


                    gridSimulacion.Rows.Add(new[]
                       {
                            $"{i}", $"fin_lectura_{silla3.persona.Numero}", $"{silla3.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-", $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}", "-",  $"{silla4.GetTiempoAtencion()}", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });

                    silla3.Libre = true;
                    silla3.TiempoFinAtencion = 0;
                    silla3.persona = null;
                    continue;
                }

                #endregion silla 3

                #region silla 4

                if (((silla4.TiempoFinAtencion < silla5.TiempoFinAtencion || silla5.Libre)) && !silla4.Libre)
                {
                    tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);

                    silla4.persona.Evento_tiempo = tiempo_atencion;
                    var bandera = true;
                    silla4.persona.Estado = Estado.SADL;
                    silla4.persona.Historico.Add(new[] { reloj.ToString(), silla4.persona.Minuto_llegada.ToString(), silla4.persona.Estado.ToString() });
                    if (empleado_1.Libre && bandera)
                    {
                        empleado_1.Libre = false;
                        empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_1.Atendiendo = silla4.persona;
                        bandera = false;
                    }
                    if (empleado_2.Libre && bandera)
                    {
                        empleado_2.Libre = false;
                        empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_2.Atendiendo = silla4.persona;
                        bandera = false;
                    }
                    if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                    {
                        silla4.persona.Estado = Estado.EA;
                        cola_empleado.Add(silla4.persona);
                    }

                    if (cola_silla.Any())
                    {
                        var esperando = cola_silla.First();
                        esperando.Estado = Estado.LB;
                        esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                        gridSimulacion.Rows.Add(new[]
                        {
                                $"{i}", $"fin_lectura_{silla4.persona.Numero}", $"{silla4.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",$"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}" , $"{silla3.GetTiempoAtencion()}",$"{silla4.TiempoFinAtencion + (double)txtTiempoLectura.Value}" , $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                        silla4.Libre = false;
                        silla4.TiempoFinAtencion = silla4.TiempoFinAtencion + (double)txtTiempoLectura.Value;
                        silla4.persona = esperando;
                        cola_silla.RemoveAt(0);

                        continue;
                    }


                    gridSimulacion.Rows.Add(new[]
                       {
                            $"{i}", $"fin_lectura_{silla4.persona.Numero}", $"{silla4.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",  $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" ,"-", $"{silla5.GetTiempoAtencion()}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });

                    silla4.Libre = true;
                    silla4.TiempoFinAtencion = 0;
                    silla4.persona = null;
                    continue;
                }

                #endregion silla 4

                #region silla 5

                if (true)
                {
                    tiempo_atencion = GetTiempoAtencionDevolucion(out rnd_rl);

                    silla5.persona.Evento_tiempo = tiempo_atencion;
                    var bandera = true;
                    silla5.persona.Estado = Estado.SADL;
                    silla5.persona.Historico.Add(new[] { reloj.ToString(), silla5.persona.Minuto_llegada.ToString(), silla5.persona.Estado.ToString() });
                    if (empleado_1.Libre && bandera)
                    {
                        empleado_1.Libre = false;
                        empleado_1.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_1.Atendiendo = silla5.persona;
                        bandera = false;
                    }
                    if (empleado_2.Libre && bandera)
                    {
                        empleado_2.Libre = false;
                        empleado_2.TiempoFinAtencion = reloj + tiempo_atencion;
                        empleado_2.Atendiendo = silla5.persona;
                        bandera = false;
                    }
                    if (!(empleado_2.Libre && empleado_1.Libre) && bandera)
                    {
                        silla5.persona.Estado = Estado.EA;
                        cola_empleado.Add(silla5.persona);
                    }

                    if (cola_silla.Any())
                    {
                        var esperando = cola_silla.First();
                        esperando.Estado = Estado.LB;
                        esperando.Historico.Add(new[] { reloj.ToString(), esperando.Minuto_llegada.ToString(), esperando.Estado.ToString() });
                        gridSimulacion.Rows.Add(new[]
                        {
                                $"{i}", $"fin_lectura_{silla5.persona.Numero}", $"{silla5.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-",$"{silla1.GetTiempoAtencion()}",$"{silla2.GetTiempoAtencion()}" , $"{silla3.GetTiempoAtencion()}", $"{silla4.GetTiempoAtencion()}", $"{silla5.TiempoFinAtencion + (double)txtTiempoLectura.Value}",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                            });

                        silla5.Libre = false;
                        silla5.TiempoFinAtencion = silla5.TiempoFinAtencion + (double)txtTiempoLectura.Value;
                        silla5.persona = esperando;
                        cola_silla.RemoveAt(0);

                        continue;
                    }


                    gridSimulacion.Rows.Add(new[]
                       {
                            $"{i}", $"fin_lectura_{silla5.persona.Numero}", $"{silla5.TiempoFinAtencion}", $"{txtEntradaPersonas.Value}", $"{persona_proxima_llegada}",
                            "-", $"Recibir Libro", $"{rnd_rl}",
                            $"{tiempo_atencion}", "-", "-", "-", "-", $"{empleado_1.TiempoFinAtencion}",
                            $"{empleado_2.TiempoFinAtencion}", "-", "-", "-", $"{silla1.GetTiempoAtencion()}", $"{silla2.GetTiempoAtencion()}",$"{silla3.GetTiempoAtencion()}" , $"{silla4.GetTiempoAtencion()}", "-",
                            $"{lista_personas.Where(x => x.Minuto_Salida > 0).Sum(x => (x.Minuto_Salida-x.Minuto_llegada))}",$"{lista_personas.Count(x => x.Minuto_Salida > 0)}"
                        });

                    silla5.Libre = true;
                    silla5.TiempoFinAtencion = 0;
                    silla5.persona = null;
                    continue;
                }

                #endregion silla 5
                lista_reloj.Add(reloj);


        }

            //foreach (var personas in lista_personas)
            //{
            //    grillaObjetos.Columns.Add($"persona{personas.Numero}", $"Persona {personas.Numero}");
            //}
          
            
        }




        private string GetTipoAtencion(double rand)
        {
            if (rand < (double)txtProbAtencion0.Value)
                return "Recibir Libro";
            return rand >= (double)(txtProbAtencion0.Value + txtProbAtencion1.Value) ? "Realizar Consulta" : "Prestar Libro";
        }

        private string GetAccionPersona(double rand)
        {
            return rand < (double)txtProbRetiraB.Value ? "Se Retira" : "Lee Biblioteca";
        }

        private double GetTiempoAtencionDevolucion(out double rand)
        {
            var rnd = new Random();
            rand = 0.0;
            for (var i = 0; i < 11; i++)
                rand += rnd.NextDouble().TruncateDouble(4);
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
            if (e.ColumnIndex == 25)
            {
                grillaObjetos.Columns.Clear();
                grillaObjetos.Rows.Clear();
                grillaObjetos.Columns.Add($"Fila_obj", $"Fila");
                grillaObjetos.Columns.Add($"rlj_min", $"Reloj (min)");
                var b = double.Parse(gridSimulacion.Rows[e.RowIndex].Cells[2].Value.ToString());
                var personasMostrar = lista_personas.Where(x => (x.Minuto_Salida == 0  && x.Minuto_llegada <= b) || x.Minuto_Salida >= b && x.Minuto_llegada <= b);
                var str_to_show = new List<string>();
                str_to_show.Add("1");
                str_to_show.Add($"{b}");
                foreach (var personas in personasMostrar)
                {
                    grillaObjetos.Columns.Add($"persona{personas.Numero}", $"Persona {personas.Numero}");
                    if (personas.Historico.Count > 1)
                    {
                        var to_show = personas.Historico.Where(x => double.Parse(x[0]) < b).Last();
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
            }


          


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
