using OODProject.Builder.Decorator;

namespace OODProject.Factory;

internal class GetHotCup : Creator
{
    public override Product GetProduct(string product)
    {
        HotCup cup = new HotCup();
        while(product.Length != 0)
        {
            switch (product)
            {
                case
                default:
                    break;
            }
        }
    }
}
