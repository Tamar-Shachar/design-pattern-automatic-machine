using OODProject.Observer;

namespace OODProject.Decoretor;

internal class GiftWarp : Additions
{
    private static int amount;
    public GiftWarp(IItem item):base(item)
    {
        amount -= 1;
    }

    public int GetAmount()
    {
        return amount;
    }
}
