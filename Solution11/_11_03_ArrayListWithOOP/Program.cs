using ArrayListWithOOP;
using System.Collections;

var manager = new StudentManager();

manager.Add("Ali");
manager.Add("Ayse");
manager.Add("Mehmet");
manager.Add("Zeynep");

manager.PrintAll();

// Silme
manager.Remove("Ayse");
manager.RemoveAt(0);
manager.PrintAll();

// Guncelleme
manager.UpDate(0, "Kemal");
manager.PrintAll();

// Araya ekleme
manager.Insert(1, "Gamze");
manager.PrintAll();

Console.ReadKey();