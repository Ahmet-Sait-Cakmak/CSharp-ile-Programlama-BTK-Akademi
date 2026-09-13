internal class City 
{
    public City(int _ID, string _Name) 
    {
        ID = _ID;

        Name = _Name;
    }

    public int ID { get; }

    public string Name { get; }

    public override string ToString() => $"{ID,-5} {Name,-20}";       
}

