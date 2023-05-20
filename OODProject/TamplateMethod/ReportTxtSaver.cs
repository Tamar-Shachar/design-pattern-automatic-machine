using System.Diagnostics;

namespace OODProject.TamplateMethod;

internal class ReportTxtSaver : ReportSaver
{

    static string PATH = "..\\..\\..\\textReport.txt";
    public override void WriteReport()
    {
        File.AppendAllText(PATH, $"\n\t{DateTime.Now}\n");
        File.AppendAllText(PATH, GetTempReport());
    }
}
