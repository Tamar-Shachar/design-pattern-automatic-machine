using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal class Shoko : Ingredient
    {
        public Shoko(HotDrink wrappee) : base(wrappee)
        {
        }
        public string GetName()
        {
            return base.GetName() + " " + nameof(this.GetType);
        }
    }
}
