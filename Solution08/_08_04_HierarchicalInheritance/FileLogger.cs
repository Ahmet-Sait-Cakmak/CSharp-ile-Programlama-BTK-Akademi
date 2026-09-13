namespace Log;

public class FileLogger : Logger
{
    protected String filePath;
    public FileLogger(String message) : this(message, "log.txt")
    {
    }
    public FileLogger(String message, String path) : base(message)
    {
        filePath = path;
    }

    public override void Log()
    {
        File.AppendAllText(filePath, logMessage + Environment.NewLine);
        System.Console.WriteLine("Log mesaji dosyaya yazdirildi: " + filePath);
    }
}
