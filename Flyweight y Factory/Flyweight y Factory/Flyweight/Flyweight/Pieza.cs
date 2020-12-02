using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Flyweight.Flyweight
{
    abstract class Pieza
    {
        public char nombrePieza;
        protected Pieza(char nombrePieza)
        {
            this.nombrePieza = nombrePieza;
        }

        public abstract void Mover(int piezaSeleccionadaX, int piezaSeleccionadaY, int movimientoSeleccionadoX, int movimientoSeleccionadoY);

    }
}
