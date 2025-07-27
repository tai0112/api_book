using HiNetProjectApi.Services.IServices;

namespace HiNetProjectApi.Services
{
    public class LogService : ILogService
    {
        private readonly ILogger _logger;
        public LogService(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger("AppLogger");
        }
        public void Error(string ex, string message, params object[] args)
        {
            _logger.LogError(ex, message, args);
        }

        public void Info(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void Warn(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }
    }
}
