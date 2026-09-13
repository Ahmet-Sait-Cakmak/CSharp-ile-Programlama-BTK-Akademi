// Ornek
using System.Globalization;

string product = "USB-C Cable";
int quantity = 3;
decimal unitPrice = 149.90m;
var when = DateTime.Now;

// Fis (Farkli Kulturlere duyarli)
PrintReceipt(product, quantity, unitPrice, when, new CultureInfo("tr-TR"), "TR (tr-TR)");

Console.WriteLine("\n");

PrintReceipt(product, quantity, unitPrice, when, new CultureInfo("en-US"), "US (en-US)");
void PrintReceipt(string product, int quantity, decimal unitPrice, DateTime when, CultureInfo ci, string title)
{
    // total price
    decimal total = quantity * unitPrice;

    // tarih ve saat 
    Console.WriteLine(title);

    Console.WriteLine(new String('=', title.Length));

    Console.WriteLine($"Date: {when.ToString("d", ci)} " + $"Time: {when.ToString("t", ci)}");

    // tablo
    Console.WriteLine($"\n{"Product",-20}" + $"{"Quantity",10}" + $"{"Unit Price",15}" + $"{"Total",15}");

    Console.WriteLine(new String('-', 20 + 10 + 15 + 15));

    Console.WriteLine($"\n{product,-20}" + $"{quantity,10:N0}" + $"{unitPrice.ToString("C2", ci),15}" + $"{total.ToString("C2", ci),15}");

}

