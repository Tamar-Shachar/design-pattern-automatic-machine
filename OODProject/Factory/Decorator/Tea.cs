namespace OODProject.Decorator;
internal class Tea : Ingredient
{
    public Tea(HotDrink wrappee) : base(wrappee)
    {

    }
    public override string ToString()
    {
        return base.ToString() + $" {(this.GetType().Name)}";
    }
}
