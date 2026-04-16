


public class FileLogger(string _filePath) : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText(_filePath, $"[LOG] {message} \n");
    }
}
