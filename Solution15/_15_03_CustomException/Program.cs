using Errors;

try
{
    Console.WriteLine("Yasinizi giriniz: ");

    int age = int.Parse(Console.ReadLine());

    if (age < 0 || age > 120)
    {
        throw new InvalidAgeException("Girilen yas 0 ile 120 arasinda olmalidir!\n");
    }

    Console.WriteLine($"Girilen yas: {age}");
}
catch (InvalidAgeException ex)
{
    Console.WriteLine($"Hata: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
}

Console.ReadKey();


