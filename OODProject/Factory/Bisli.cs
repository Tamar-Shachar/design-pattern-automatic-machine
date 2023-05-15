using OODProject.Observer;

namespace OODProject.Factory;

internal class Bisli : Snack
{
    readonly static double price = 4.5;
    static int amount=5;
    static List<ISuplier> supliers = new List<ISuplier>();
    private string name;

    public Bisli()
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
        foreach (var suplier in supliers)
        {
            suplier.Update(typeof(Bisli));
        }
    }
    public string GetName()
    {
        return base.GetName() + " " + nameof(this.GetType);
    }

}
