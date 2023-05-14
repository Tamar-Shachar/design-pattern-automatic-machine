namespace OODProject.Factory;

internal class Bisli : Snack
{
    readonly static double price = 4.5;
    static int amount=5;

    public Bisli()
    {
        amount -= 1;
    }
    public override double GetPrice()
    {
        return price;
    }
}
