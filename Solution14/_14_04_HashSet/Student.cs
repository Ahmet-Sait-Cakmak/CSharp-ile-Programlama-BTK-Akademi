class Student
{
    public Student(int _ID, string _name)
    {
        ID = _ID;
        name = _name;
    }

    public int ID { get; private set; }

    public String name { get; private set; }

    public override bool Equals(object? obj)
    {
        if (obj is Student student1)
        {
            return ID == student1.ID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ID.GetHashCode();
    }

    public override string ToString() => $"{ID} {name}";


}