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

        private Dictionary<char, IPieza> _piezas =
          new Dictionary<char, IPieza>();

        public IPieza GetPieza(char key)
        {

            IPieza piezas = null;
            if (_piezas.ContainsKey(key))
            {
                piezas = _piezas[key];
            }
            else

            {
                switch (key)
                {
                    case 'P': piezas = new Peon(); break;
                    case 'R': piezas = new Rey(); break;
                    case 'r': piezas = new Reina(); break;
                    case 'C': piezas = new Caballo(); break;
                    case 'A': piezas = new Alfil(); break;
                    case 'T': piezas = new Torre(); break;
                    case 'D': piezas = new Dama(); break;
                }
                _piezas.Add(key, piezas);
            }
            return piezas;
        }
    }

}
