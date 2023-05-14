using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODProject.Builder.Decorator
{
    internal class HotCup:HotDrink
    {
        
        static int amount = 80;
        public HotCup()
        {
            amount -= 1;
        }
        
    }
}
