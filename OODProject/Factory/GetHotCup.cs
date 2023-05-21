using OODProject.Decorator;

namespace OODProject.Factory;

internal class GetHotCup : Creator
{
    public override Product GetProduct(params string[] products)
    {
        HotDrink cup = new HotCup();
        foreach (var item in products)
        {
            switch (item)
            {
                case nameof(Shoko):
                    cup = new Shoko(cup);
                    break;
                case nameof(Coffee):
                    cup = new Coffee(cup);
                    break;
                case nameof(Milk):
                    cup = new Milk(cup);
                    break;
                case nameof(HotWatter):
                    cup = new HotWatter(cup);
                    break;
                case nameof(Sugar):
                    cup = new Sugar(cup);
                    break;
                case nameof(Tea):
                    cup = new Tea(cup);
                    break;
                default:
                    break;
            }
        }
        return cup;
    }
}
