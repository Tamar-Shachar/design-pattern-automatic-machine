﻿using OODProject.Observer;

namespace OODProject.Factory;

internal class Cola : Drink
{
    readonly static double price = 5;
    static int amount = 80;
    static List<ISuplier> supliers = new List<ISuplier>();
    public Cola()
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
            suplier.Update(typeof(Cola));
        }

    }
    public string GetName()
    {
        return base.GetName() + " " + nameof(this.GetType);
    }
}
