using Flyweight_y_Factory.Factory.ConcreteCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AjedrezCreator ajedrez = new AjedrezCreator();

            var a = ajedrez.FactoryMethod();

            a.CrearTablero();

            a.Jugar();

        }
    }
}
