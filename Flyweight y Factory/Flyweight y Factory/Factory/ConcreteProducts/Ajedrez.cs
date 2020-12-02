
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
    class Ajedrez : Product
    {

        public override void CrearTablero()
        {

            PiezaFactory factory = new PiezaFactory();

            Pieza peon = factory.GetPieza(key:'P');
            Pieza alfil = factory.GetPieza('A');
            Pieza caballo = factory.GetPieza('C');
            Pieza rey = factory.GetPieza('R');
            Pieza reina = factory.GetPieza('r');
            Pieza torre = factory.GetPieza('T');

            Jugador blanco = new Jugador(color:'B');
            Jugador negro = new Jugador('N');

            JugadorPieza peonBlanco = new JugadorPieza(jugador: blanco, pieza: peon);
            JugadorPieza peonNegro = new JugadorPieza(negro, peon);

            JugadorPieza alfilBlanco = new JugadorPieza(blanco, alfil);
            JugadorPieza alfilNegro = new JugadorPieza(negro, alfil);

            JugadorPieza caballoBlanco = new JugadorPieza( blanco, caballo);
            JugadorPieza caballoNegro = new JugadorPieza(negro, caballo);

            JugadorPieza reyBlanco = new JugadorPieza(blanco, reina);
            JugadorPieza reyNegro = new JugadorPieza(negro, reina);

            JugadorPieza reinaBlanco = new JugadorPieza( blanco, rey);
            JugadorPieza reinaNegro = new JugadorPieza(negro, rey);

            JugadorPieza torreBlanco = new JugadorPieza(blanco,torre);
            JugadorPieza torreNegro = new JugadorPieza(negro, torre);

            tablero[0, 1] = peonBlanco;
            tablero[1, 1] = peonBlanco;
            tablero[2, 1] = peonBlanco;
            tablero[3, 1] = peonBlanco;
            tablero[4, 1] = peonBlanco;
            tablero[5, 1] = peonBlanco;
            tablero[6, 1] = peonBlanco;
            tablero[7, 1] = peonBlanco;

            tablero[0, 6] = peonNegro;
            tablero[1, 6] = peonNegro;
            tablero[2, 6] = peonNegro;
            tablero[3, 6] = peonNegro;
            tablero[4, 6] = peonNegro;
            tablero[5, 6] = peonNegro;
            tablero[6, 6] = peonNegro;
            tablero[7, 6] = peonNegro;

            tablero[0, 0] = torreBlanco;
            tablero[7, 0] = torreBlanco;

            tablero[0, 7] = torreNegro;
            tablero[7, 7] = torreNegro;

            tablero[1, 0] = alfilBlanco;
            tablero[6, 0] = alfilBlanco;

            tablero[1, 7] = alfilNegro;
            tablero[6, 7] = alfilNegro;

            tablero[2, 0] = caballoBlanco;
            tablero[5, 0] = caballoBlanco;

            tablero[2, 7] = caballoNegro;
            tablero[5, 7] = caballoNegro;

            tablero[3, 0] = reyBlanco;
            tablero[4, 7] = reyNegro;

            tablero[4, 0] = reinaBlanco;
            tablero[3, 7] = reinaNegro;

        }
    }
}
