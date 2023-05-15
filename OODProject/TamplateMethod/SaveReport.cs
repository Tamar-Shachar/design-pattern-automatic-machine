using OODProject.Observer;

namespace OODProject.TamplateMethod;

internal abstract class SaveReport
{
    protected static string Report;// { get; set; }
    public static void AddReport(IItem item)
    {
        Report += $"item: {item.GetType().GetMethod("GetName").Invoke(item, null).ToString()}.\n" +
            $"\tprice: {item.GetType().GetMethod("GetPrice").Invoke(null, null).ToString()}";
    }
    public static void WriteReport() { }
    
}
