class Customer 
{
    public int ID { get; }

    public String FullName { get; }

    public Customer(int _ID, string _fullName)
    {
        ID = _ID;

        FullName = _fullName;
    }

    public override string ToString() => $"{FullName,-20} #{ID}";
    
        
    

    

}

