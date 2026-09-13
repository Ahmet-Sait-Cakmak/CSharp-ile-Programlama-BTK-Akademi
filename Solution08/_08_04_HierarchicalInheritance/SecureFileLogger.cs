namespace Log;

public class SecureFileLogger : FileLogger
{
    public SecureFileLogger(String message, String path) : base(message, path)
    {
    }

    public override void Log()
    {
        char[] chars = logMessage.ToCharArray();
        Array.Reverse(chars);
        String encrypted = new String(chars);

        File.AppendAllText(filePath, encrypted + Environment.NewLine);  
        System.Console.WriteLine($"Sifrelenmis log yazildi: {filePath}");
    }
}