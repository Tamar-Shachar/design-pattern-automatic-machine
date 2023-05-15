using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal class Tea : Ingredient
    {
        public Tea(HotDrink wrappee) : base(wrappee)
        {
        }
        public string GetName()
        {
            return base.GetName() + " " + nameof(this.GetType);
        }
    }
}
