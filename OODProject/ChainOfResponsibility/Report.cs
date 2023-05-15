using OODProject.Observer;
using OODProject.TamplateMethod;

namespace OODProject.ChainOfResponsibility;

internal class Report : BaseHandler
{
   
    public override async Task<IItem> Handel(IItem item)
    {
        SaveTxtReport.AddReport(item);
        SaveTxtReport.WriteReport();
        await Task.Delay(5000);
        return null;
    }
}
