using OODProject.Observer;
using System.Diagnostics;

namespace OODProject.TamplateMethod;

internal abstract class ReportSaver
{
    protected static string Report = "";
    public void AddReport(IItem item)
    {
        Report +=
            $"item: {item.ToString()}.\n";
        Debug.WriteLine(Report);
    }
    public abstract void WriteReport();
    
}
