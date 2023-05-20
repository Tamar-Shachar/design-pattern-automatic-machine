namespace OODProject.Decorator;

internal abstract class Ingredient : HotDrink
{
    protected HotDrink wrappee;
    public Ingredient(HotDrink wrappee)
    {
        this.wrappee = wrappee;
    }
    public override string ToString()
    {
        return $"{wrappee.ToString()}";
    }
}
