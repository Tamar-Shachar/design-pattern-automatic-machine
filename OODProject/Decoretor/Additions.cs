using OODProject.Observer;

namespace OODProject.Decoretor;

internal abstract class Additions : IItem
{
    protected IItem item;
    public Additions(IItem item)
    {
        this.item = item;
    }
    public int GetAmount()
    {
        return 0;
    }
    public override string ToString()
    {
        return $"{item.ToString()}";
    }

}
