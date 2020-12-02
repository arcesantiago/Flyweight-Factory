using Flyweight_y_Factory.Exceptions;
using Flyweight_y_Factory.Factory.Products;

using Flyweight_y_Factory.Flyweight.Flyweight;


namespace Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez
{
    class Peon : Pieza
    {

        public Peon(char nombrePieza) : base(nombrePieza)
        {

        }


        public override void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY)
        {
            bool condicionpieza;

            if (Product.tablero[piezaSeleccionadaX, piezaSeleccionadaY].jugador.color == 'B')
                condicionpieza = piezaSeleccionadaY + 1 != movimientoSeleccionadoY;
            else
                condicionpieza = piezaSeleccionadaY - 1 != movimientoSeleccionadoY;

            if (movimientoSeleccionadoX != piezaSeleccionadaX || condicionpieza)
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
