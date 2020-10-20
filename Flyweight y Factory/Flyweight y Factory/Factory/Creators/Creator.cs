using Flyweight_y_Factory.Factory.Products;
using Flyweight_y_Factory.Flyweight.Flyweight;
using Flyweight_y_Factory.Flyweight.FlyweightFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Factory.Creators
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();

  
    }
}
