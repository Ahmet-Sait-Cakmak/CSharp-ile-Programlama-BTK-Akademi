// Kullanicidan vize notunu alma
Console.WriteLine("Lutfen vize notunuzu giriniz: ");
double midtermScore = Convert.ToDouble(Console.ReadLine());

// Kullanicidan final notunu alma
Console.WriteLine("Lutfen final notunuzu giriniz: ");
double finalScore = Convert.ToDouble(Console.ReadLine());

// Kullanicinin nihai notunu hesaplama ve nihai notu ekrana yazdirma
var finalGrade = (midtermScore * 0.4) + (finalScore * 0.6);
Console.WriteLine($"Nihai notunuz: {finalGrade}");

// Kullanicinin gecip gecmedigini ekrana yazdirma
if (finalGrade >= 50)
{
    Console.WriteLine("Gectiniz!");
}
else
{
    Console.WriteLine("Kaldiniz.");
}
