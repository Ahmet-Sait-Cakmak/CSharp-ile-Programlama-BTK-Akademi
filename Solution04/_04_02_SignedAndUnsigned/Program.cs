// Isaretsiz byte
using System.Xml;

Console.WriteLine("Isaretsiz byte deger araligi: 0 - 255");
Console.WriteLine($"Isaretsiz byte'in minimum degeri: {byte.MinValue}");
Console.WriteLine($"Isaretsiz byte'in maximum degeri: {byte.MaxValue}");

// Isaretli byte == sbyte
Console.WriteLine("\nSbyte'in deger araligi: (-128) - 127");
Console.WriteLine($"Sbyte'in minimum degeri: {sbyte.MinValue}");
Console.WriteLine($"Sbyte'in maximum degeri: {sbyte.MaxValue}");

// Isaretsiz byte'da wrap-around
Console.WriteLine("");
byte unsignedValue = 255;
Console.WriteLine($"Baslangic degeri: {unsignedValue}");
unsignedValue++; // byte icin 255 + 1 == 256 mi yoksa 255 + 1 == 0 mi?
Console.WriteLine($"Tasma sonrasi deger: {unsignedValue}");

// Sbyte'da (isaretli byte'da) wrap-around
Console.WriteLine("");
sbyte signedValue = 127;
Console.WriteLine($"Baslangic degeri: {signedValue}");
signedValue++; // sbyte icin 127 + 1 == 128 mi yoksa 127 + 1 == -128 mi?
Console.WriteLine($"Tasma sonrasi deger: {signedValue}");

// Ikili gösterim (binary)
Console.WriteLine("\nBinary karsiliklar:");
Console.WriteLine($"Byte 255: {Convert.ToString(255,2)}");
Console.WriteLine($"Byte 15: {Convert.ToString(15, 2).PadLeft(8, '0')}");