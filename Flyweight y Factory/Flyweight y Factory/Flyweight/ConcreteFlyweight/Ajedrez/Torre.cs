using Flyweight_y_Factory.Exceptions;
using Flyweight_y_Factory.Factory.Products;

using Flyweight_y_Factory.Flyweight.Flyweight;


namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez
{
    class Torre : Pieza
    {
        public Torre(char nombrePieza) : base(nombrePieza)
        {

        }
        public override void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY)
        {
            if (movimientoSeleccionadoX != piezaSeleccionadaX && movimientoSeleccionadoY != piezaSeleccionadaY)
                throw new MovimientoInvalidoException();
            else if (movimientoSeleccionadoX > piezaSeleccionadaX)
            {
                var distancia = movimientoSeleccionadoX - piezaSeleccionadaX;
                var incrementaPosicion = piezaSeleccionadaX;
                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[++incrementaPosicion, piezaSeleccionadaY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoX < piezaSeleccionadaX)
            {
                var distancia = piezaSeleccionadaX - movimientoSeleccionadoX;
                var incrementaPosicion = piezaSeleccionadaX;
                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[--incrementaPosicion, piezaSeleccionadaY] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoY > piezaSeleccionadaY)
            {
                var distancia = movimientoSeleccionadoY - piezaSeleccionadaY;
                var incrementaPosicion = piezaSeleccionadaY;
                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[piezaSeleccionadaX, ++incrementaPosicion] != null;

                    if (hayObstaculo)
                        throw new ObstaculoException();
                }
            }
            else if (movimientoSeleccionadoY < piezaSeleccionadaY)
            {
                var distancia = piezaSeleccionadaY - movimientoSeleccionadoY;
                var incrementaPosicion = piezaSeleccionadaY;
                for (int i = 0; i < distancia - 1; i++)
                {
                    var hayObstaculo = Product.tablero[piezaSeleccionadaX, --incrementaPosicion] != null;

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
