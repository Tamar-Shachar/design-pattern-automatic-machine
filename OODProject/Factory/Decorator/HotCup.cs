using OODProject.Observer;

namespace OODProject.Decorator;

internal class HotCup : HotDrink
{

    static int amount = 80;
    static List<ISuplier> supliers = new List<ISuplier>();
    public HotCup()
    {
        amount -= 1;
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
            suplier.Update(typeof(HotCup));
        }
    }
    public override string ToString()
    {
        return $" {(this.GetType().Name)}";
    }
}

