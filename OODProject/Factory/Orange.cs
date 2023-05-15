using OODProject.Observer;

namespace OODProject.Factory
{
    internal class Orange : Drink
    {
        readonly static double price = 8;
        static int amount =5;
        static List<ISuplier> supliers = new List<ISuplier>();
        public Orange()
        {
            amount -= 1;
            Notify();

        }
        public override double GetPrice()
        {
            return price;
        }

        public static int GetAmount()
        {
            return amount;
        }
        public static void Attach(ISuplier suplier)
        {
            supliers.Add(suplier);
        }

        public static void Detach(ISuplier suplier)
        {
            supliers.Remove(suplier);
        }
        public static void Notify()
        {
            foreach (var suplier in supliers)
            {
                suplier.Update(typeof(Orange));
            }
        }
    }
}
