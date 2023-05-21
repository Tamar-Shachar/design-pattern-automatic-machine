using OODProject.Observer;

namespace OODProject.Factory;

internal class Chips : Snack
{
    readonly static double price = 5;
    static int amount = 80;
    static List<ISuplier> supliers = new List<ISuplier>();
    public Chips()
    {
        amount -= 1;
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
        if (amount < Product.minAmount)
        {
            foreach (var suplier in supliers)
            {
                suplier.Update(typeof(Chips));
            }
        }
    }
}
