namespace OODProject.Builder.Decorator;

internal class Shoko : Ingredient
{
    public Shoko(HotDrink wrappee) : base(wrappee)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
