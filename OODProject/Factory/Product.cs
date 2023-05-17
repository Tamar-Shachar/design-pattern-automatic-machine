using OODProject.Observer;

namespace OODProject.Factory
{
    internal /*abstract*/ class Product : IItem
    {

        public static void Attach(ISuplier suplier)
        {

        }

        public static void Detach(ISuplier suplier)
        {

        }

        public static int GetAmount()
        {
            return 0;
        }

        public virtual double GetPrice()
        {
            return 0;
        }

        public void Notify()
        {

        }
        public override string ToString()
        {
            return $" {(this.GetType().Name)}";
        }
    }
}
