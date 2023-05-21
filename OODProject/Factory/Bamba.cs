using OODProject.Observer;

namespace OODProject.Factory;

internal class Bamba : Snack
{
    static int amount = 30;
    readonly static double price = 7.6;
    static List<ISuplier> supliers = new List<ISuplier>();
    public Bamba()
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
                suplier.Update(typeof(Bamba));
            }
        }
    }

}
