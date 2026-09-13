try
{
    int a = 10;
    int b = 0;

    var result = a / b;

}
catch(FileNotFoundException f)
{
    throw new Exception($"Bir hata olustu: {f.Message}\n");
}
catch (DivideByZeroException z)
{
    throw new Exception("Sifira bolme hatasi!\n");
}
catch (Exception ex)
{
    throw new Exception($"Bir hata olustu: {ex.Message}\n");
}
finally 
{
    Console.WriteLine("\nProgram sona eriyor...\n");
}

Console.ReadKey();
