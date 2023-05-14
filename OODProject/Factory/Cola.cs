namespace OODProject.Factory;

internal class Cola : Drink
{
    readonly static double price = 5;
    static int amount = 80;
    public Cola()
    {
        amount -= 1;
    }
    public override double GetPrice()
    {
        return price;
    }
}
