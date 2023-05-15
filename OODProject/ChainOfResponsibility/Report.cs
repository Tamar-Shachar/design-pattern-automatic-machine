using OODProject.Observer;
using OODProject.TamplateMethod;

namespace OODProject.ChainOfResponsibility;

internal class Report : BaseHandler
{
   
    public override async Task<IItem> Handel(IItem item)
    {
        ReportTxtSaver.AddReport(item);
        return null;
    }
}
