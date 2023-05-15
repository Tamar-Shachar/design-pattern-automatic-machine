using OODProject.Observer;

namespace OODProject.Decoretor;

internal class Additions : IItem
{
    private IItem item;
    public Additions(IItem item)
    {
        this.item = item;
    }
    public int GetAmount()
    {
        throw new NotImplementedException();
    }
}
