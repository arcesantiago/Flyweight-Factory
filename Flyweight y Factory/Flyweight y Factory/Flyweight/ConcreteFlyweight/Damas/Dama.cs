using Flyweight_y_Factory.Exceptions;
using Flyweight_y_Factory.Factory.Products;

using Flyweight_y_Factory.Flyweight.Flyweight;
using System;


namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Damas
{
    class Dama : Pieza
    {
        public Dama(char nombrePieza) : base(nombrePieza)
        {

        }
        public override void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY)
        {
            if (Math.Abs(piezaSeleccionadaX - movimientoSeleccionadoX) != Math.Abs(piezaSeleccionadaY - movimientoSeleccionadoY))
                throw new MovimientoInvalidoException();
            else if (movimientoSeleccionadoX > piezaSeleccionadaX && movimientoSeleccionadoY > piezaSeleccionadaY)
            {
                var distancia = movimientoSeleccionadoX - piezaSeleccionadaX;
                var incrementaPosicionX = piezaSeleccionadaX;
                var incrementaPosicionY = piezaSeleccionadaY;

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[++incrementaPosicionX, ++incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoX < piezaSeleccionadaX && movimientoSeleccionadoY < piezaSeleccionadaY)
            {
                var distancia = piezaSeleccionadaX - movimientoSeleccionadoX;
                var incrementaPosicionX = piezaSeleccionadaX;
                var incrementaPosicionY = piezaSeleccionadaY;

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[--incrementaPosicionX, --incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoX < piezaSeleccionadaX && movimientoSeleccionadoY > piezaSeleccionadaY)
            {
                var distancia = movimientoSeleccionadoY - piezaSeleccionadaY;
                var incrementaPosicionX = piezaSeleccionadaX;
                var incrementaPosicionY = piezaSeleccionadaY;

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[--incrementaPosicionX, ++incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoX > piezaSeleccionadaX && movimientoSeleccionadoY < piezaSeleccionadaY)
            {
                var distancia = piezaSeleccionadaY - movimientoSeleccionadoY;
                var incrementaPosicionX = piezaSeleccionadaX;
                var incrementaPosicionY = piezaSeleccionadaY;

                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[++incrementaPosicionX, --incrementaPosicionY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            if (Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] != null && Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY].jugador == Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY].jugador)
                throw new MismoColorException();
            else
            {
                Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] = Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY];
                Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY] = null;
            }

        }

    }
}
