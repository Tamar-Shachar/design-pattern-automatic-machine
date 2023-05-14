namespace OODProject.Decoretor;

internal class Bag : Additions
{
    private static int amount;
    public Bag()
    {
        amount -= 1;
    }

    public int GetAmount()
    {
        return amount;
    }
}
