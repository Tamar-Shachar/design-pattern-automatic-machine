using OODProject.Observer;

namespace OODProject.Factory
{
    internal /*abstract*/ class Product : IItem
    {
        public virtual double GetPrice()
        {
            return 0;
        }
    }
}
