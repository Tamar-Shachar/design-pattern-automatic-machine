using OODProject.Observer;

namespace OODProject.Factory
{
    internal /*abstract*/ class Product : IItem
    {
        public virtual int GetAmount()
        {
            return 0;
        }

        public virtual double GetPrice()
        {
            return 0;
        }
    }
}
