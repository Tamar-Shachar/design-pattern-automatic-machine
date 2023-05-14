namespace OODProject.Factory;

internal class GetSnack : Creator
{
    public override Product GetProduct(params string[] products)
    {
        switch (products[0])
        {
            case nameof(Bisli):
                return new Bisli();
            case nameof(Chips):
                return new Chips();
            case nameof(Bamba):
                return new Bamba();
            default:
                return null;
        }
    }
}
