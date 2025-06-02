namespace TestMVCCoreWebAPPCS.Models
{
    public class ConsoleLogger : IDataLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " is on " + DateTime.Now);
        }
    }
}
