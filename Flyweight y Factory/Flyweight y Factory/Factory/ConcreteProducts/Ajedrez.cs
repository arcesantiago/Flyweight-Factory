
using Flyweight_y_Factory.Factory.Products;
using Flyweight_y_Factory.Flyweight.Flyweight;
using Flyweight_y_Factory.Flyweight.FlyweightFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Factory.ConcreteProducts
{
    class Ajedrez : Product
    {

        public override void CrearTablero()
        {

            PiezaFactory factory = new PiezaFactory();

            IPieza peon = factory.GetPieza('P');
            IPieza alfil = factory.GetPieza('A');
            IPieza caballo = factory.GetPieza('C');
            IPieza rey = factory.GetPieza('R');
            IPieza reina = factory.GetPieza('r');
            IPieza torre = factory.GetPieza('T');

            tablero[0, 1] = peon;
            tablero[1, 1] = peon;
            tablero[2, 1] = peon;
            tablero[3, 1] = peon;
            tablero[4, 1] = peon;
            tablero[5, 1] = peon;
            tablero[6, 1] = peon;
            tablero[7, 1] = peon;

            tablero[0, 6] = peon;
            tablero[1, 6] = peon;
            tablero[2, 6] = peon;
            tablero[3, 6] = peon;
            tablero[4, 6] = peon;
            tablero[5, 6] = peon;
            tablero[6, 6] = peon;
            tablero[7, 6] = peon;

            tablero[0, 0] = torre;
            tablero[7, 0] = torre;

            tablero[0, 7] = torre;
            tablero[7, 7] = torre;

            tablero[1, 0] = caballo;
            tablero[6, 0] = caballo;

            tablero[1, 7] = caballo;
            tablero[6, 7] = caballo;

            tablero[2, 0] = alfil;
            tablero[5, 0] = alfil;

            tablero[2, 7] = alfil;
            tablero[5, 7] = alfil;

            tablero[3, 0] = reina;
            tablero[4, 7] = reina;

            tablero[4, 0] = rey;
            tablero[3, 7] = rey;

            jugadores[0, 1] = blanco;
            jugadores[1, 1] = blanco;
            jugadores[2, 1] = blanco;
            jugadores[3, 1] = blanco;
            jugadores[4, 1] = blanco;
            jugadores[5, 1] = blanco;
            jugadores[6, 1] = blanco;
            jugadores[7, 1] = blanco;

            jugadores[0, 6] = negro;
            jugadores[1, 6] = negro;
            jugadores[2, 6] = negro;
            jugadores[3, 6] = negro;
            jugadores[4, 6] = negro;
            jugadores[5, 6] = negro;
            jugadores[6, 6] = negro;
            jugadores[7, 6] = negro;

            jugadores[0, 0] = blanco;
            jugadores[7, 0] = blanco;

            jugadores[0, 7] = negro;
            jugadores[7, 7] = negro;

            jugadores[1, 0] = blanco;
            jugadores[6, 0] = blanco;

            jugadores[1, 7] = negro;
            jugadores[6, 7] = negro;

            jugadores[2, 0] = blanco;
            jugadores[5, 0] = blanco;

            jugadores[2, 7] = negro;
            jugadores[5, 7] = negro;

            jugadores[3, 0] = blanco;
            jugadores[4, 7] = negro;

            jugadores[4, 0] = blanco;
            jugadores[3, 7] = negro;

        }
    }
}
