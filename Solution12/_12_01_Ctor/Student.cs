internal class Student
{
    public int ID { get; }

    public String Name { get; }

    public Student()
    {
        ID = 0;

        Name = String.Empty;
    }

    public Student(int _ID, string _Name)
    {
        ID = _ID;
        Name = _Name ?? "Bilinmiyor";
    }

    public override string ToString() => $"ID: {ID, -5} Name: {Name, -20}";
}
