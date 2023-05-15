namespace OODProject.Observer;

internal interface IItem
{

    static int GetAmount() { return 0; }
    static void Attach(ISuplier suplier) { }
    static void Detach(ISuplier suplier) { }
    static void Notify() { }
    static string GetName() { return ""; }
}
