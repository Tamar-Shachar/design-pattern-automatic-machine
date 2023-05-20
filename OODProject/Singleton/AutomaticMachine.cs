using OODProject.Decorator;
using OODProject.ChainOfResponsibility;
using OODProject.Factory;

namespace OODProject.Singleton;

internal class AutomaticMachine
{

    #region singleton
    //private AutomaticMachine()
    //{

    //}
    //private static AutomaticMachine instance;
    //static object locker = new();
    //public static AutomaticMachine GetInstance()
    //{
    //    if (instance == null)
    //    {
    //        lock (locker)
    //        {
    //            instance = new AutomaticMachine();
    //        }
    //    }
    //    return instance;
    //}
    #endregion
    public void StartShpping(string type, params string[] products)
    {
        Creator creator = new GetSnack();
        switch (type)
        {
            case nameof(Snack):
                creator = new GetSnack();
                break;
            case nameof(Drink):
                creator = new GetDrink();
                break;
            case nameof(HotDrink):
                creator = new GetHotCup();
                break;
            default:
                break;
        }
        var item = creator.GetProduct(products);
        Payment h1 = new Payment();
        Warp h2 = new Warp();
        Packing h3 = new Packing();
        Report h4 = new Report();
        h1.SetNext(h2);
        h2.SetNext(h3);
        h3.SetNext(h4);
        h4.SetNext(null);
        h1.Handel(item);
       
    }
}
