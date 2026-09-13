using System.Collections.ObjectModel;
using System.Collections.Specialized;

class StudentManager
{
    public ObservableCollection<Student> students { get; } = new ObservableCollection<Student>();

    public StudentManager()
    {
        // Abonelik
        students.CollectionChanged += OnStudentsChanged;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public bool RemoveStudentById(int id)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].ID.Equals(id))
            {
                students.RemoveAt(i);

                return true;
            }
        }

        System.Console.WriteLine($"\nID'si {id} olan bir ogrenci bulunamadi.\n");

        return false;
    }

    public void PrintAll()
    {
        System.Console.WriteLine("\n=== Ogrenci Listesi ===\n");

        foreach (var s in students)
            System.Console.WriteLine(s);
    }

    private void OnStudentsChanged(object ? sender, NotifyCollectionChangedEventArgs e)
    {
        System.Console.WriteLine(e.Action);

        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
            
                if (e.NewItems is not null)
                {
                    foreach (Student s in e.NewItems)
                    {
                        System.Console.WriteLine($"[+] Eklendi: {s}");
                    }
                }

                break;


             case NotifyCollectionChangedAction.Remove:

                if (e.OldItems is not null)
                {
                    foreach (Student s in e.OldItems)
                    {
                        System.Console.WriteLine($"[-] Silindi: {s}");
                    }
                }

                break;
            

            default:
                System.Console.WriteLine("Reset!");
                break;
        }
    }
}