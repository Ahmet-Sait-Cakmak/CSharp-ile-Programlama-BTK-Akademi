namespace Model;

using Errors;

internal class Person
{
    public int age;

    public Person(int _age, string? _name)
    {
        Age = _age;
        name = _name;
    }

    public String? name { get; set; } = string.Empty;

    public int Age 
    {
        get 
        {
            return age;
        }
        set 
        {
            if (value < 20 || value > 90) 
            {
                throw new InvalidAgeException("Girilen yas 0 ile 90 arasinda olmalidir.\n");
            }

            age = value;
        }
    }

    public void PrintInfo() 
    {
        Console.WriteLine($"Girilen isim: {name, -10}, Girilen yas: {age, -5}");
    }
}
