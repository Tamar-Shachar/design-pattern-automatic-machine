using OODProject.Observer;

namespace OODProject.Builder.Decorator;

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
    public string GetName()
    {
        return base.GetName() + " " + nameof(this.GetType);
    }
}

