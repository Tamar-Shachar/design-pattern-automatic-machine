namespace OODProject.Observer;

internal class TaskSchedulerA
{
    private static TaskSchedulerA _instance;
    private List<System.Threading.Timer> timers = new List<System.Threading.Timer>();

    private TaskSchedulerA() { }

    //public TaskSchedulerA Instance = new TaskSchedulerA();
    public static TaskSchedulerA Instance => _instance ?? (_instance = new TaskSchedulerA());

    public void ScheduleTask(int hour, int min, double intervalInHour, Action task)
    {
        DateTime now = DateTime.Now;
        DateTime firstRun = new DateTime(now.Year, now.Month, now.Day, hour, min, 0, 0);
        if (now > firstRun)
        {
            firstRun = firstRun.AddDays(1);
        }

        TimeSpan timeToGo = firstRun - now;
        if (timeToGo <= TimeSpan.Zero)
        {
            timeToGo = TimeSpan.Zero;
        }

        var timer = new System.Threading.Timer(x =>
        {
            task.Invoke();
        }, null, timeToGo, TimeSpan.FromHours(intervalInHour));

        timers.Add(timer);
    }
}

