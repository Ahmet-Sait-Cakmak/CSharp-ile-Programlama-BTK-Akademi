class Number {

    // ctor
    // Yapici metod -> Referans

    private int _singleNumber = 3;  // field (alan)

    private String? _description;

    public Number()
    {
        System.Console.WriteLine("Number sinifindan bir ornek (intance) uretildi.");
        System.Console.WriteLine($"Number: {_singleNumber:N0}");
    }

    public Number(int singleNumber, string description, int count = -1)
    {
        SingleNumber = singleNumber;
        Description = description;
        Count = count;
    }

    public int SingleNumber  // Full Property
    {
        get 
        { 
            return _singleNumber; 
        }

        set 
        {
             if (value < 0) 
                _singleNumber = 0;
             else
                _singleNumber = value; 
        }
    }

    public String? Description
    {
        get { return _description; }
        set { _description = value; }
    }
    
    public int Count { get; set; } // Auto Property
}
