using System;

namespace _08_02_Inheritance;

public class FileHandler
{
    public String FilePath { get; set; }

    public FileHandler(string filePath)
    {
        FilePath = filePath;
    }

    public void WriteToFile(String content)
    {
        File.WriteAllText(FilePath, content);
        System.Console.WriteLine($"Dosyaya yazma islemi basarili oldu.");
    }

    public string ReadFromFile()
    {
        if (File.Exists(FilePath))
        {
            return File.ReadAllText(FilePath);
        }
        else
        {
            return "Dosya bulunamadi.";
        }
    }
}