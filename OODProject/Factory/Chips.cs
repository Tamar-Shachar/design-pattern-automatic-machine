namespace OODProject.Factory;

internal class Chips : Snack
{
    readonly static double price = 5;
     static int amount =80;
    public Chips()
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
