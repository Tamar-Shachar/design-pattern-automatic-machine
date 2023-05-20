using OODProject.Observer;
using OODProject.TamplateMethod;

namespace OODProject.ChainOfResponsibility;

internal class Report : BaseHandler
{
    ReportTxtSaver reportTxtSaver = new ReportTxtSaver();
    public override async Task<IItem> Handel(IItem item)
    {
          
        MessageBox.Show(item.ToString(), "The items that you buy",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        reportTxtSaver.AddReport(item);
        return base.Handel(item) == null? null : base.Handel(item).Result;
    }
}
