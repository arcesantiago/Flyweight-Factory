using Flyweight_y_Factory.Factory.Products;
using Flyweight_y_Factory.Flyweight.CustomExceptions;
using Flyweight_y_Factory.Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez
{
    class Alfil : IPieza
    {
        public char nombrePieza {get;set;}

        public Alfil()
        {
            this.nombrePieza = 'A';
        }



        public void Mover(int[] piezaSeleccionada, int[] movimientoSeleccionado)
        {
            if (Math.Abs(piezaSeleccionada[0] - movimientoSeleccionado[0]) != Math.Abs(piezaSeleccionada[1] - movimientoSeleccionado[1]))
                throw new MovimientoInvalidoException();
            else if (movimientoSeleccionado[0] > piezaSeleccionada[0] && movimientoSeleccionado[1] > piezaSeleccionada[1])
            {
                var distancia = movimientoSeleccionado[0] - piezaSeleccionada[0];
                var incrementaPosicionX = piezaSeleccionada[0];
                var incrementaPosicionY = piezaSeleccionada[1];

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[++incrementaPosicionX, ++incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionado[0] < piezaSeleccionada[0] && movimientoSeleccionado[1] < piezaSeleccionada[1])
            {
                var distancia = piezaSeleccionada[0] - movimientoSeleccionado[0];
                var incrementaPosicionX = piezaSeleccionada[0];
                var incrementaPosicionY = piezaSeleccionada[1];

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[--incrementaPosicionX, --incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionado[0] < piezaSeleccionada[0] && movimientoSeleccionado[1] > piezaSeleccionada[1])
            {
                var distancia = movimientoSeleccionado[1] - piezaSeleccionada[1];
                var incrementaPosicionX = piezaSeleccionada[0];
                var incrementaPosicionY = piezaSeleccionada[1];

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[--incrementaPosicionX, ++incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionado[0] > piezaSeleccionada[0] && movimientoSeleccionado[1] < piezaSeleccionada[1])
            {
                var distancia = piezaSeleccionada[1] - movimientoSeleccionado[1];
                var incrementaPosicionX = piezaSeleccionada[0];
                var incrementaPosicionY = piezaSeleccionada[1];

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[++incrementaPosicionX, --incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            if (Product.tablero[movimientoSeleccionado[0], movimientoSeleccionado[1]] != null && Product.jugadores[movimientoSeleccionado[0], movimientoSeleccionado[1]] == Product.jugadores[piezaSeleccionada[0], piezaSeleccionada[1]])
                throw new MismoColorException();
            else
            {
                Product.tablero[movimientoSeleccionado[0], movimientoSeleccionado[1]] = Product.tablero[piezaSeleccionada[0], piezaSeleccionada[1]];
                Product.jugadores[movimientoSeleccionado[0], movimientoSeleccionado[1]] = Product.jugadores[piezaSeleccionada[0], piezaSeleccionada[1]];
                Product.tablero[piezaSeleccionada[0], piezaSeleccionada[1]] = null;
                Product.jugadores[piezaSeleccionada[0], piezaSeleccionada[1]] = ' ';
            }

        }

    }

}
