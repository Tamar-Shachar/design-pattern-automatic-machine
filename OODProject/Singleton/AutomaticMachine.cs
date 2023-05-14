namespace OODProject.Singleton;

internal class AutomaticMachine
{
    private AutomaticMachine()
    {

    }
    private static AutomaticMachine instance;
    static object locker = new();
    public static AutomaticMachine GetInstance()
    {
        if (instance == null)
        {
            lock (locker)
            {
                instance = new AutomaticMachine();
            }
        }
        return instance;
    }
    public void StartShpping()
    {

    }
}
