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
    class Damas : Product
    {
        public override void CrearTablero()
        {
            PiezaFactory factory = new PiezaFactory();

            IPieza dama = factory.GetPieza('D');

            //a implementar
        }
    }
}
