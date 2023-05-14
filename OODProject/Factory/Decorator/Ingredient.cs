using OODProject.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal class Ingredient:HotDrink
    {
        private HotDrink wrappee;
        public Ingredient(HotDrink wrappee)
        {
            this.wrappee = wrappee;
        }

    }
}
