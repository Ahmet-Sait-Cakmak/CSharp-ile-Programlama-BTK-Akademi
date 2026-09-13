object data = "Merhaba";

if (data is string)
{
    Console.WriteLine("data degiskeninin veri tipi string'dir.");
}
else if (data is int)
{
    Console.WriteLine("data degiskeninin veri tipi int'dir.");
}
else
{
    Console.WriteLine("data degiskeninin veri tipi string veya int degildir.");
}

int a = 50;
data = a; // int degeri object'e atama (boxing)

if (data is string)
{
    Console.WriteLine("\ndata degiskeninin yeni veri tipi string'dir.");
}
else if (data is int)
{
    Console.WriteLine("\ndata degiskeninin yeni veri tipi int'dir.");
}
else
{
    Console.WriteLine("\ndata degiskeninin yeni veri tipi string veya int degildir.");
}

int b = (int)data; // object'ten int'e donusturme (unboxing)
Console.WriteLine($"\nb degiskeninin degeri: {b}");
