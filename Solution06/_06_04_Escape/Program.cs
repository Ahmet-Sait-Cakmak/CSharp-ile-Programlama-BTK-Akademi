// Kacis Karakterleri
string report = "Log Raporu\n\t - Kullanici: admin\n\t - Islem: Yedekleme";
Console.WriteLine(report);

// dosya yollari
string path1 = "C:\\Users\\Admin\\Documents\\data.txt";
Console.WriteLine("\nKacis Karakteri ile yol: " + path1);

// verbatim
string path2 = @"C:\Users\Admin\Documents\data.txt";
Console.WriteLine("\nVerbatim ile yol: " + path2);

// JSON
string jsonEscaped = "{\"username\": \"admin\"}";
Console.WriteLine("\nJSON cikisi: " + jsonEscaped);

//JSON Verbatim
Console.WriteLine("\nJSON verbatim:");
string jsonVerbatim = @"{
    ""username"": ""admin"",
    ""status"": ""active""
}";
Console.WriteLine(jsonVerbatim);

Console.ReadKey();