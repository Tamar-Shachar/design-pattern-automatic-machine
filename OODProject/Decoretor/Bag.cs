using OODProject.Observer;

namespace OODProject.Decoretor;

internal class Bag : Additions
{
    private static int amount;
    public Bag(IItem item):base(item)
    {
        amount -= 1;
    }

    public int GetAmount()
    {
        return amount;
    }
}
