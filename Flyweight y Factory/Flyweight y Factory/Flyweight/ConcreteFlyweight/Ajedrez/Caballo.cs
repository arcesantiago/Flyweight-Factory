using Flyweight_y_Factory.Exceptions;
using Flyweight_y_Factory.Factory.Products;

using Flyweight_y_Factory.Flyweight.Flyweight;


namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez
{
    class Caballo : Pieza
    {

        public Caballo(char nombrePieza) : base(nombrePieza)
        {

        }


        public override void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY)
        {
            if (movimientoSeleccionadoX > piezaSeleccionadaX && movimientoSeleccionadoY > piezaSeleccionadaY)
                if (piezaSeleccionadaX + 1 == movimientoSeleccionadoX && piezaSeleccionadaY + 2 == movimientoSeleccionadoY ||
                    piezaSeleccionadaX + 2 == movimientoSeleccionadoX && piezaSeleccionadaY + 1 == movimientoSeleccionadoY)
                {
                    if (Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] != null && Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] == Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY])
                        throw new MismoColorException();
                    else
                    {
                        Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] = Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY];

                        Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY] = null;

                    }
                }
                else

                    throw new MovimientoInvalidoException();
            if (movimientoSeleccionadoX < piezaSeleccionadaX && movimientoSeleccionadoY < piezaSeleccionadaY)
                if (piezaSeleccionadaX - 1 == movimientoSeleccionadoX && piezaSeleccionadaY - 2 == movimientoSeleccionadoY ||
                    piezaSeleccionadaX - 2 == movimientoSeleccionadoX && piezaSeleccionadaY - 1 == movimientoSeleccionadoY)
                {
                    if (Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] != null && Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] == Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY])
                        throw new MismoColorException();
                    else
                    {
                        Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] = Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY];
   
                        Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY] = null;

                    }
                }
                else

                    throw new MovimientoInvalidoException();
            if (movimientoSeleccionadoX < piezaSeleccionadaX && movimientoSeleccionadoY > piezaSeleccionadaY || movimientoSeleccionadoX > piezaSeleccionadaX && movimientoSeleccionadoY < piezaSeleccionadaY)
                if (piezaSeleccionadaX - 1 == movimientoSeleccionadoX && piezaSeleccionadaY + 2 == movimientoSeleccionadoY ||
                    piezaSeleccionadaX - 2 == movimientoSeleccionadoX && piezaSeleccionadaY + 1 == movimientoSeleccionadoY ||
                    piezaSeleccionadaX + 1 == movimientoSeleccionadoX && piezaSeleccionadaY - 2 == movimientoSeleccionadoY ||
                    piezaSeleccionadaX + 2 == movimientoSeleccionadoX && piezaSeleccionadaY - 1 == movimientoSeleccionadoY)
                {
                    if (Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] != null && Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY].jugador == Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY].jugador)
                        throw new MovimientoInvalidoException();
                    else
                    {
                        Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] = Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY];
   
                        Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY] = null;
    
                    }
                }
                else

                    throw new MovimientoInvalidoException();
            else

                throw new MovimientoInvalidoException();

        }
    }

}
