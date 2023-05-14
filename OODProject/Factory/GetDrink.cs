namespace OODProject.Factory;

internal class GetDrink : Creator
{
    public override Product GetProduct(string product)
    {
        switch (product)
        {
            case nameof(Orange):
                return new Orange();
            case nameof(Soda):
                return new Soda();
            case nameof(Cola):
                return new Cola();
            default:
                return null;
        }
    }
}
