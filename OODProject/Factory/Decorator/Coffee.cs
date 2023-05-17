namespace OODProject.Builder.Decorator;

internal class Coffee : Ingredient
{
    public Coffee(HotDrink wrappee) : base(wrappee)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
