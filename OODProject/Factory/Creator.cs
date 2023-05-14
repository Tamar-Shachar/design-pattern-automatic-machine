namespace OODProject.Factory;

internal abstract class Creator
{
    public abstract Product GetProduct(params string[] products);

}
