try
{
    Console.WriteLine("Bolunmek uzere bir tam sayi giriniz: ");
    int dividend = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bolmek uzere bir tam sayi giriniz: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = Divide(dividend, divisor);
}
catch (FormatException)
{
    Console.WriteLine("Tam sayi disinda bir deger girdiniz.\n");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\nBolen sayi icin sifir girdiniz. Bolen sayi sifir olamaz!\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Beklenmeyen bir hata olustu: {ex.Message}.\n");
}
finally 
{
    Console.WriteLine("Program sona eriyor...\n");
}

int Divide(int dividend, int divisor)
{
    if (dividend.Equals(0)) 
    {
        throw new DivideByZeroException("Bolen sayi sifir olamaz!\n");
    }

    return dividend / divisor;
}