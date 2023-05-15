using OODProject.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal abstract class HotDrink:Product
    {
        static double price = 10;
        public override double GetPrice()
        {
            return price;
        }

    }
}
