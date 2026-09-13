using System.Collections;
using System.Runtime.CompilerServices;

namespace ArrayListWithOOP;


public class StudentManager
{
    private ArrayList students;


    public StudentManager()
    {
        students = new ArrayList();
    }

    public void Add(String name)
    {
        students.Add(name);

        Console.WriteLine($"{name} listeye eklendi.");
    }

    public void Remove(String name)
    {
        students.Remove(name);

        Console.WriteLine($"{name} listeden silindi.");
    }

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < students.Count)
        {
            Console.WriteLine($"{students[index]} listeden silindi.");

            students.RemoveAt(index);
        }
        else
            Console.WriteLine("Gecersiz bir index girdiniz!");
    }

    public void UpDate(int index, String name)
    {
        students[index] = name;
    }

    public void Insert(int index, String name)
    {
        students.Insert(index, name);
    }

    public void PrintAll()
    {
        Console.WriteLine("\n=== Ogrenci Listesi ===\n");

        foreach (var item in students)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

    }
}
