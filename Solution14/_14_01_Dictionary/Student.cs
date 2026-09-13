class Student 
{
    public int ID { get; set; }

    public String name { get; set; }

    public double GPA { get; set; }

    public Student(int _ID, string _name, double _GPA)
    {
        ID = _ID;
        name = _name;
        GPA = _GPA;
    }

    public override string ToString() => $"{ID, -5} {name, -20} {GPA}";
    
}