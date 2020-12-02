using Flyweight_y_Factory.Exceptions;
using Flyweight_y_Factory.Factory.Products;

using Flyweight_y_Factory.Flyweight.Flyweight;


namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez
{
    class Rey : Pieza
    {
        public Rey(char nombrePieza) : base(nombrePieza)
        {

        }

        public override void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY)
        {
            if (movimientoSeleccionadoX > piezaSeleccionadaX && piezaSeleccionadaX + 1 != movimientoSeleccionadoX)
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionadoY > piezaSeleccionadaY && piezaSeleccionadaY + 1 != movimientoSeleccionadoY)
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionadoX < piezaSeleccionadaX && piezaSeleccionadaX - 1 != movimientoSeleccionadoX)
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionadoY < piezaSeleccionadaY && piezaSeleccionadaY - 1 != movimientoSeleccionadoY)
                throw new MovimientoInvalidoException();
            else if (Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] != null && Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY].jugador == Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY].jugador)
                throw new MismoColorException();
            else
            {
                Product.tablero[movimientoSeleccionadoX, movimientoSeleccionadoY] = Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY];
                Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY] = null;
            }
        }
    }

}
