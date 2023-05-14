using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal class Sugar : Ingredient
    {
        public Sugar(HotDrink wrappee) : base(wrappee)
        {
        }
    }
}
