namespace CSharp.Modules.DependencyInjection
{
    public class FileLogger:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Dependency Injection pattern => File Logger");
        }
    }
}
