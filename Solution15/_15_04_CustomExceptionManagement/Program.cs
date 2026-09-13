using Model;

using Errors;

try
{
    Console.WriteLine("Lutfen bir isim giriniz: ");

    string name = Console.ReadLine();


    Console.WriteLine("Lutfen bir yas giriniz: ");

    int age = int.Parse(Console.ReadLine());


    var person1 = new Person(age, name);

    person1.PrintInfo();

    Console.ReadKey();
}
catch (InvalidAgeException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Beklenmeyen hata: " + ex.Message);
}
finally 
{
    Console.WriteLine("\nProgram sonlandi.\n");
}
