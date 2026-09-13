class StudentManager
{
    private Dictionary<int, Student> students;

    public StudentManager()
    {
        students = new Dictionary<int, Student>();
    }

    public void AddStudent(Student student) 
    {
        // id kontrolu: key tekrar edemez!
        if (!students.ContainsKey(student.ID))
        {
            students.Add(student.ID, student);

            System.Console.WriteLine($"{student.name} basariyla eklendi.");
        }
        else
        {
            System.Console.WriteLine($"{student.ID} numarali ogrenci zaten mevcut.");
        }
    }

    public void RemoveStudent(int id) 
    {
        if (students.Remove(id))
            System.Console.WriteLine($"{id} numarali ogrenci silindi.");
        else
            System.Console.WriteLine($"Numarasi {id} olan bir ogrenci zaten yok.");

    }
    
    public void FindStudent(int id) 
    {
        // TryGetValue ile ogrenciyi arayacagiz
        if (students.TryGetValue(id, out Student student))
            System.Console.WriteLine($"{student} bulundu.");
        else
            System.Console.WriteLine($"Numarasi {id} olan bir ogrenci bulunamadi.");

    }

    public void PrintAll() 
    {
        System.Console.WriteLine("\n=== Ogrenci Listesi ===\n");

        foreach (var s in students.Values)
        {
            System.Console.WriteLine(s);
        }
    }
}