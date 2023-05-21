using OODProject.Observer;

namespace OODProject.TamplateMethod;

internal abstract class ReportSaver
{
    static string PATH = "..\\..\\..\\tempReport.txt";
    public void AddReport(IItem item)
    {
        File.AppendAllText(PATH, $"{TimeOnly.FromDateTime(DateTime.Now)}: {item.ToString()}\n");
    }

    public string GetTempReport()
    {
        string rep = File.ReadAllText(PATH);
        File.Delete(PATH);
        return rep;
    }
    public abstract void WriteReport();

}
