namespace _03_02_ArithmeticOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine($"a degiskeninin degeri: {a}");
            Console.WriteLine($"b degiskeninin degeri: {b}");

            // Toplama islemi
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");

            // Cikarma islemi
            Console.WriteLine($"{a} - {b} = {a - b}");

            // Carpma islemi
            int c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");

            // Bolme islemi
            int d = a / b;
            var e = (double)a / b;

            Console.WriteLine($"{a} / {b} = {d} = d");
            Console.WriteLine($"d degiskeninin tipi: {d.GetType()}");
            Console.WriteLine($"{a} / {b} = {e} = e");
            Console.WriteLine($"e degiskeninin tipi: {e.GetType()}");
            
          
            // Mod alma islemi
            int f = a % b;
            Console.WriteLine($"{a} % {b} = {f}");

            // Artirma islemi
            a++;
            Console.WriteLine($"a + 1 = {a}");

            // Azaltma islemi
            b--;
            Console.WriteLine($"b - 1 = {b}");

            Console.ReadKey();
        }
    }
}
