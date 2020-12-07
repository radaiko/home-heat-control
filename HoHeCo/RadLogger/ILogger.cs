namespace RadLogger
{
    public interface ILogger
    {
        void Log(EType type, string message);

        void LogError(string message);

        void LogInfo(string message);
    }
}