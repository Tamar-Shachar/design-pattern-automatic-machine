namespace OODProject.Decoretor;

internal class GiftWarp : Additions
{
    private static int amount;
    public GiftWarp()
    {
        amount -= 1;
    }

    public int GetAmount()
    {
        return amount;
    }
}
