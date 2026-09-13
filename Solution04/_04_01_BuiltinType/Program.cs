// Kur bilgileri ve tarih
var dollarRate = 40.7m;
decimal euroRate = 47.50m;
decimal goldRate = 4400m;
DateTime rateDate = DateTime.Now;

Console.WriteLine("TL miktarini giriniz: ");
decimal amountInTl = Convert.ToDecimal(Console.ReadLine());

// Menu
Console.WriteLine("\nDonusturme Secenekleri:");
Console.WriteLine("1 - USD");
Console.WriteLine("2 - EUR");
Console.WriteLine("3 - ALTIN (gram)");

Console.WriteLine("\nSeciminizi yapiniz (1-3): ");
int choice = Convert.ToInt32(Console.ReadLine());

decimal result = 0m;
string currencyName = "";

switch (choice)
{
    case 1:
        result = amountInTl / dollarRate;
        currencyName = "USD";
        break;
    case 2:
        result = amountInTl / euroRate;
        currencyName = "EUR";
        break;
    case 3:
        result = amountInTl / goldRate;
        currencyName = "ALTIN (gram)";
        break;
    default:
        Console.WriteLine("Gecersiz secim!");
        return;
}

Console.WriteLine($"\nTarih: {rateDate}");
Console.WriteLine($"Girilen TL miktari: {amountInTl} TL");
Console.WriteLine($"Donusum sonucu: {result:F2} {currencyName}");

Console.WriteLine("\n---Kurlar---");
Console.WriteLine($"Dolar: {dollarRate:F2} TL");
Console.WriteLine($"EUR: {euroRate:F2} TL");
Console.WriteLine($"ALTIN (gram): {goldRate:F2} TL");