using OODProject.Factory;

namespace OODProject.Decorator;

internal abstract class HotDrink : Product
{
    static double price = 10;
    public override double GetPrice()
    {
        return price;
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
