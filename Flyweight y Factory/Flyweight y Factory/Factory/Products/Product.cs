using Flyweight_y_Factory.Flyweight.CustomExceptions;
using Flyweight_y_Factory.Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Factory.Products
{
    abstract class Product
    {
  
            public static IPieza[,] tablero;
            public static char[,] jugadores;
            public char blanco;
            public char negro;

            public Product()
            {
                tablero = new IPieza[8, 8];
                jugadores = new char[8, 8];
                blanco = 'B';
                negro = 'N';
            }

            enum Fila
            {
                a,
                b,
                c,
                d,
                e,
                f,
                g,
                h
            }

            abstract public void CrearTablero();


            public void Jugar()
            {

                const string separador = " -------------------------";

                for (int y = 8 - 1; y >= 0; y--)
                {
                    Console.WriteLine(" {0}", separador);
                    Console.Write("{0} ", y + 1);
                    for (int x = 0; x < 8; x++)
                    {
                        Console.Write("|{0}", tablero[x, y] != null ? tablero[x, y].nombrePieza + jugadores[x, y].ToString() : "  ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine(" {0}", separador);
                Console.Write("   ");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("{0}  ", Enum.GetName(typeof(Fila), i));
                }

                Seleccionar();
            }

            private void Seleccionar()
            {
                string seleccionarPieza;
                string seleccionarMovimiento;
                int[] seleccion;

                try
                {
                    Console.Write("\n\nSeleccione una pieza ingresando fila y columna: ");
                    seleccionarPieza = Console.ReadLine();

                    seleccion = ValidarSeleccion(seleccionarPieza);

                    IPieza piezaSeleccionada = tablero[seleccion[0], seleccion[1]];

                    if (piezaSeleccionada == null)
                        throw new Exception("No hay piezas en el casillero " + seleccionarPieza);

                    Console.Write("\n\nSeleccione un movimiento ingresando fila y columna: ");
                    seleccionarMovimiento = Console.ReadLine();

                    int[] movimientoSeleccionado = ValidarSeleccion(seleccionarMovimiento);

                    piezaSeleccionada.Mover(seleccion, movimientoSeleccionado);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(Environment.NewLine + ex.Message);
                }
                finally
                {
                    Jugar();
                }

            }

            private int[] ValidarSeleccion(string seleccion)
            {
                if (seleccion.Length < 2 || seleccion.Length > 2 || !Char.IsNumber(seleccion[0]) || !Char.IsLetter(seleccion[1]) || seleccion[0] == '0')
                    throw new MovimientosException();

                int fila = (int)Enum.Parse(typeof(Fila), seleccion[1].ToString());
                int columna = Convert.ToInt32(seleccion[0].ToString()) - 1;

                return new int[2] { fila, columna };
            }
        }

    
}

