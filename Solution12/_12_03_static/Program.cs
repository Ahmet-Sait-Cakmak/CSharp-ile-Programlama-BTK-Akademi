namespace _12_03_static;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine($"PI: {MathHelper.PI}");

        System.Console.WriteLine($"5'in karesi: {MathHelper.Square(5)}");

        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        System.Console.WriteLine($"Toplam sayac sayisi: {Counter.Count}");
    }
}


