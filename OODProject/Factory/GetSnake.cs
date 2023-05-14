namespace OODProject.Factory;

internal class GetSnake : Creator
{
    public override Product GetProduct(string product)
    {
        switch (product)
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
