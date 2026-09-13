using System.Collections;

internal class StudentManager
{
    private ArrayList students;

    public StudentManager()
    {
        students = new ArrayList();
    }

    public StudentManager(Student s) : this()
    {
        if (s is not null)
        {
             students.Add(s);
        }
           
    }

    public StudentManager(IEnumerable<Student> studentList) : this()
    {
        foreach (var item in studentList)
        {
            students.Add(item);
        }
    }

    public void Add(Student s)
    {
        if (s is null)
        {
            System.Console.WriteLine("Gecersiz ögrenci!");

            return;
        }

        students.Add(s);
    }

    public void PrintAll()
    {
        System.Console.WriteLine("\n=== Ogrenciler ===\n");

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i] is Student st)
            {
                System.Console.WriteLine($"{st}");
            }
        }

        System.Console.WriteLine();
    }
}
