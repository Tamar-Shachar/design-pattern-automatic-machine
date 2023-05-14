namespace OODProject.Factory;

internal class Soda : Drink
{
    readonly static double price = 5.5;
    static int amount = 6;
    public Soda()
    {
        amount -= 1;
    }
    public override double GetPrice()
    {
        return price;
    }
}
