namespace HiNetProjectApi.Services.IServices
{
    public interface ILogService
    {
        void Info(string message, params object[] args);
        void Error(string ex, string message, params object[] args);
        void Warn(string message, params object[] args);
    }
}
