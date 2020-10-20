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
    class Rey : IPieza
    {
        public char nombrePieza { get; set; }

        public Rey()
        {
            this.nombrePieza = 'R';
        }

        public void Mover(int[] piezaSeleccionada, int[] movimientoSeleccionado)
        {
            if (movimientoSeleccionado[0] > piezaSeleccionada[0] && piezaSeleccionada[0] + 1 != movimientoSeleccionado[0])
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionado[1] > piezaSeleccionada[1] && piezaSeleccionada[1] + 1 != movimientoSeleccionado[1])
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionado[0] < piezaSeleccionada[0] && piezaSeleccionada[0] - 1 != movimientoSeleccionado[0])
                throw new MovimientoInvalidoException();
            if (movimientoSeleccionado[1] < piezaSeleccionada[1] && piezaSeleccionada[1] - 1 != movimientoSeleccionado[1])
                throw new MovimientoInvalidoException();
            else if (Product.tablero[movimientoSeleccionado[0], movimientoSeleccionado[1]] != null && Product.jugadores[movimientoSeleccionado[0], movimientoSeleccionado[1]] == Product.jugadores[piezaSeleccionada[0], piezaSeleccionada[1]])
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
