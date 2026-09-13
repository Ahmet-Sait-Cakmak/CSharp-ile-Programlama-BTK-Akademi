// bir diziyi initialize etme
int[] numbers = { 5, 10, 15, -3, 20, 25 };

// while dongusu yardimiyla dizideki pozitif tam sayilari ekrana yazdirma
 System.Console.WriteLine($"Numbers dizisindeki pozitif tam sayilar:\n");

int i = 0;

while (i < numbers.Length)
{
    if (numbers[i] < 0)
    {
        i++;
        continue;
    }

     System.Console.WriteLine($"{numbers[i]}");
     i++;
}

Console.ReadKey();
