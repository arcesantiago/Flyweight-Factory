using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Flyweight.Flyweight
{
    interface IPieza
    {

              char nombrePieza { get; set; }

              void Mover(int[] piezaSeleccionada, int[] movimientoSeleccionado);
        }
    
}
