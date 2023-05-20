namespace OODProject.Decorator;

internal class Sugar : Ingredient
{
    public Sugar(HotDrink wrappee) : base(wrappee)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
