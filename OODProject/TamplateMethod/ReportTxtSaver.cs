namespace OODProject.TamplateMethod;

internal class ReportTxtSaver : ReportSaver
{

    static string PATH = "..\\..\\..\\report.txt";
    public static void WriteReport()
    {
        File.AppendAllText(PATH, $"\n\t{DateTime.Now}\n");
        File.AppendAllText(PATH, Report);
    }
}
