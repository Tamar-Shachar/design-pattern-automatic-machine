using OODProject.Observer;
using System.Diagnostics;

namespace OODProject.TamplateMethod;

internal abstract class ReportSaver
{
    protected static string Report = "";
    public static void AddReport(IItem item)
    {
        Report +=
            $"item: {item.ToString()}.\n";
        Debug.WriteLine(Report);
    }
    public static void WriteReport() { }
    
}
