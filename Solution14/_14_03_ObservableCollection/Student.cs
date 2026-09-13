class Student
{
    public Student(int _ID, string _name)
    {
        ID = _ID;
        name = _name;
    }

    public int ID { get; set; }

    public String name { get; set; }

    public override string ToString() => $"{ID} {name}";
}