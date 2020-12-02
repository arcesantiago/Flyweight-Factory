using Flyweight_y_Factory.Factory.Products;
using Flyweight_y_Factory.Flyweight.Flyweight;
using Flyweight_y_Factory.Flyweight.FlyweightFactory;
using Flyweight_y_Factory.Jugadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Factory.ConcreteProducts
{
    class Damas : Product
    {
        public override void CrearTablero()
        {
            PiezaFactory factory = new PiezaFactory();

            Pieza dama = factory.GetPieza('D');

            Jugador blanco = new Jugador('B');
            Jugador negro = new Jugador('N');

            JugadorPieza peonBlanco = new JugadorPieza(jugador: blanco, pieza: dama);
            JugadorPieza peonNegro = new JugadorPieza(negro, dama);

            //a implementar
        }
    }
}
