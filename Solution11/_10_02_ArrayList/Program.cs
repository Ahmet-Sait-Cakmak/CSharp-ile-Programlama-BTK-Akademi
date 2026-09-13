// Tanimlama
using System.Collections;

var students = new ArrayList();


// Ekleme
students.Add("Ali");
students.Add("Ayse");
students.Add("Mehmet");
students.Add("Zeynep");

Console.WriteLine("=== Baslangic Listesi ===\n");

PrintList(students);


// Silme
students.Remove("Mehmet");
students.RemoveAt(0);

Console.WriteLine("\n=== Silme Sonrasi Liste ===\n");

PrintList(students);


// Guncelleme
students[0] = "Fatma";

Console.WriteLine("\n=== Guncelleme Sonrasi Liste ===\n");

PrintList(students);


// Araya Ekleme
students.Insert(1, "Kemal");

Console.WriteLine("\n=== Araya Ekleme Sonrasi Liste ===\n");

PrintList(students);


Console.ReadKey();


static void PrintList(ArrayList list) 
{
    for (int i = 0; i < list.Count; i++) 
    {
        Console.WriteLine($"{i}. indekteki eleman: {list[i]}");
    }

    Console.WriteLine();
}
