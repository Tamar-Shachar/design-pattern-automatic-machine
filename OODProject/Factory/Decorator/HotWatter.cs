namespace OODProject.Builder.Decorator;

internal class HotWatter : Ingredient
{
    public HotWatter(HotDrink wrappee) : base(wrappee)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
