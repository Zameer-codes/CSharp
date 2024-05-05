namespace CSharp.Modules.DependencyInjection
{
    public class ConsoleLogger:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Dependency Injection pattern => Console Logger");
        }
    }
}
