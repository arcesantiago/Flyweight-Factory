using Flyweight_y_Factory.Factory.ConcreteProducts;
using Flyweight_y_Factory.Factory.Creators;
using Flyweight_y_Factory.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_y_Factory.Factory.ConcreteCreators
{
    class AjedrezCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Ajedrez();
        }
    }
}
