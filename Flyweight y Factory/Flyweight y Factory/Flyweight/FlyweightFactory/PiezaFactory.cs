using Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Ajedrez;
using Flyweight_y_Factory.Flyweight.ConcreteFlyweight.Damas;
using Flyweight_y_Factory.Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Flyweight.FlyweightFactory
{
    class PiezaFactory
    {

        private readonly Dictionary<char, Pieza> _piezas;

        public PiezaFactory()
        {
            _piezas = new Dictionary<char, Pieza>();
        }

        public Pieza GetPieza(char key)
        {

            Pieza piezas = null;

            if (_piezas.ContainsKey(key))
            {
                piezas = _piezas[key];
            }
            else
            {
                switch (key)
                {
                    case 'P': piezas = new Peon(key); break;
                    case 'R': piezas = new Rey(key); break;
                    case 'r': piezas = new Reina(key); break;
                    case 'C': piezas = new Caballo(key); break;
                    case 'A': piezas = new Alfil(key); break;
                    case 'T': piezas = new Torre(key); break;

                    case 'D': piezas = new Dama(key); break;
                }
                _piezas.Add(key, piezas);
            }
            return piezas;
        }
    }

}
