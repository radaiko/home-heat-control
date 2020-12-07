namespace RadLogger
{
    public interface ILogger
    {
        void Log(EType type, string message);
    }
}