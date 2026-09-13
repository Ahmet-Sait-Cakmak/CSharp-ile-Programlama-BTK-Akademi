using _08_02_Inheritance;

LogFile logFile = new LogFile("log.txt");

// ust sinif (base class) ozelliklerinin kullanimi
logFile.WriteToFile("Baslangic log kaydi.");
System.Console.WriteLine("Dosya icerigi:");
System.Console.WriteLine(logFile.ReadFromFile());

// alt sinif (derived class) ozelliklerinin kullanimi
logFile.AppendLog("Kullanici sisteme giris yapti.");
logFile.AppendLog("Veri guncelleme islemi gerceklestirildi.");

System.Console.WriteLine("Son Dosya icerigi:");
System.Console.WriteLine(logFile.ReadFromFile());

Console.ReadKey();
