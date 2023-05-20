namespace OODProject.Decorator;

internal class Milk : Ingredient
{
    public Milk(HotDrink wrappee) : base(wrappee)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
