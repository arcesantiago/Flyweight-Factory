using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Exceptions
{
    class MovimientosException : Exception
    {
        public override string Message
        {
            get
            {
                return "Ingrese una fila y columna valida!";
            }
        }
    }

    class MovimientoInvalidoException : Exception
    {
        public override string Message
        {
            get
            {
                return "No es una movida valida para esta pieza";
            }
        }
    }

    class MismoColorException : Exception
    {
        public override string Message
        {
            get
            {
                return "No se pueden comer piezas del mismo color";
            }
        }
    }

    class ObstaculoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Otra pieza en el camino";
            }
        }
    }
}
