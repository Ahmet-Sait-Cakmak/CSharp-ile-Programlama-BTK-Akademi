// bir diziyi initialize etme
int[] numbers = { 10, 20, 30, 40, 50 };

// foreach dongusu yardimiyla dizideki elemanlarin toplamini hesaplama
int sum = 0;
foreach (var num in numbers)
{
    sum += num;
}

// dizideki eleamanlarin ortalamasini hesaplama ve ekrana yazdirma
double average = (double)sum / numbers.Length;

System.Console.WriteLine($"Dizi elemanlarinin ortalamasi: {average:F2}");