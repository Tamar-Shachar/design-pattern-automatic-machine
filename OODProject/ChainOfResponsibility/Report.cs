using OODProject.Observer;
using OODProject.TamplateMethod;

namespace OODProject.ChainOfResponsibility;

internal class Report : BaseHandler
{
   
    public override async Task<IItem> Handel(IItem item)
    {
        Form form1 = Application.OpenForms["Form1"];
        Label label = new Label();
        label.Text = item.ToString();
        label.Location = new Point(700, 400);
        label.Width = 300;
        form1.Controls.Add(label);  
        ReportTxtSaver.AddReport(item);
        return null;
    }
}
