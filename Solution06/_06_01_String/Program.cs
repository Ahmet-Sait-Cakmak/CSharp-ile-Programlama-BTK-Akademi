// string tanimlama
string message = "Merhaba";
Console.WriteLine("\nIlk mesaj: " + message);

// immutablity
string newMessage = message + " Dunya"; 
Console.WriteLine("\nYeni mesaj: " + newMessage);
Console.WriteLine("Eski mesaj: " + message);

// dizi benzeri islemler
Console.WriteLine("\nmessage isimli stringin ilk karakteri: " + message[0]);
Console.WriteLine("message isimli stringin son karakteri: " + message[message.Length - 1]);

// Donguler
Console.WriteLine("\nmessage isimli stringin tum karakterleri:");
Console.WriteLine("");

foreach (char c in message)
{
    Console.WriteLine(c);
}

// String metotlari
Console.WriteLine("\nmessage isimli stringin karakter sayisi: " + message.Length);
Console.WriteLine("message isimli stringin buyuk harfe yazilisi: " + message.ToUpper());
Console.WriteLine("message isimli stringin icerisinde 'Dunya' var mi? " + message.Contains("Dunya"));