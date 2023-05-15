namespace OODProject.TamplateMethod;

internal class SaveTxtReport : SaveReport
{

    static string PATH = "..\\..\\..\\report.txt";
    public static void WriteReport()
    {
        File.AppendAllText(PATH, Report);
    }
}
