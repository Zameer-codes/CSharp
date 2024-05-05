namespace CSharp.Modules.DependencyInjection
{
    public class ClientLogger
    {
        private readonly ILogging _logger;
        public ClientLogger(ILogging logger)
        {
            _logger = logger;
        }
        public void LogMessage()
        {
            _logger.Log();
        }
    }
}
