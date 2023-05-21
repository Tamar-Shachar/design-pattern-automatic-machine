using OODProject.Decorator;
using OODProject.ChainOfResponsibility;
using OODProject.Factory;
using OODProject.TamplateMethod;

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
    Payment h1;
    Warp h2;
    Packing h3;
    Report h4;
    public AutomaticMachine()
    {
        h1 = new Payment();
        h2 = new Warp();
        h3 = new Packing();
        h4 = new Report(new ReportTxtSaver());
        h1.SetNext(h2);
        h2.SetNext(h3);
        h3.SetNext(h4);
        h4.SetNext(null);
    }
    public async void StartShpping(string type, params string[] products)
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
        await h1.Handel(item);
        Application.Restart();
    }
}
