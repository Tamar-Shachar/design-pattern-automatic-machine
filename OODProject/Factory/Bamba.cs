namespace OODProject.Factory;

internal class Bamba : Snack
{
    static int amount = 30;
    readonly static double price = 7.6;
    public Bamba()
    {
        amount -= 1;
    }
    public override double GetPrice()
    {
        return price;
    }
    public override int GetAmount()
    {
        return amount;
    }
}
