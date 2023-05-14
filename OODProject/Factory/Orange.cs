namespace OODProject.Factory
{
    internal class Orange : Drink
    {
        readonly static double price = 8;
        static int amount =59;
        public Orange()
        {
            amount -= 1;

        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
