int? age = null;        // int veri tipinde nullable bir değişken tanımlanıyor ve başlangıçta null olarak atanıyor.
var name = "Ali";     // string veri tipinde bir değişken tanımlanıyor ve "Ali" değeri atanıyor.

Console.WriteLine("age degiskeninin tipi: " + age?.GetType());
Console.WriteLine("name degiskenin turu: " + name?.GetType());

string? nullable = null; // string veri tipinde nullable bir değişken tanımlanıyor ve başlangıçta null olarak atanıyor.
Console.WriteLine("Buyuk harf: " + nullable?.ToUpper());
Console.WriteLine("Kullanici adi: " + (nullable ?? "Belirtilmemis"));
Console.WriteLine("Yas: " + (age ?? -1));

Console.ReadKey(); 