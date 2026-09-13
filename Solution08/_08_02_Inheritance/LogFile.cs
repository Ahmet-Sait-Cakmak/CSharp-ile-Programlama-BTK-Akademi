using System;

namespace _08_02_Inheritance;

public class LogFile : FileHandler
{
    public LogFile(string filePath) : base(filePath)
    {
    }

    // Log ekleme
    public void AppendLog(string logMessage)
    {
        using (StreamWriter sw = File.AppendText(FilePath))
        {
            sw.WriteLine($"{DateTime.Now} : {logMessage}");
        }

        System.Console.WriteLine($"Log dosyaya eklendi.");
    }
}