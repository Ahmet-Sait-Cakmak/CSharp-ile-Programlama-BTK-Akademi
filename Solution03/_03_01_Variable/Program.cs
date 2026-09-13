// tam sayi turunde bir degisken tanimlama ve ona deger atama
int age = 25;
Console.WriteLine($"Yas: {age}");

// double turunde sabit bir degisken tanimlama ve ona deger atama
const double piValue = 3.14;
Console.WriteLine($"Pi sayisi: {piValue}");

// string turunde bir degisken tanimlama ve ona deger atama
var city = "Samsun";
Console.WriteLine($"Sehir: {city}");

// tam sayi atanmis degiskenin degerini degistirme
age += 1;
Console.WriteLine($"Yeni yas: {age}");

// Tarih ve saat turunde bir degisken tanimlama ve ona deger atama
DateTime currentDate = DateTime.Now; // == var currentDate = DateTime.Now;
Console.WriteLine($"Mevcut tarih ve saat: {currentDate}");

Console.ReadKey();
