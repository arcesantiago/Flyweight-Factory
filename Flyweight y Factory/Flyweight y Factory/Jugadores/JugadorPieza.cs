using Flyweight_y_Factory.Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Jugadores
{
    class JugadorPieza
    {
        public Jugador jugador;
        public Pieza pieza;
        public JugadorPieza(Jugador jugador, Pieza pieza)
        {
            this.jugador = jugador;
            this.pieza = pieza;
        }
    }
}
