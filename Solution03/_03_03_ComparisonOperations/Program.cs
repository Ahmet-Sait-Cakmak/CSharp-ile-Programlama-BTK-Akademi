namespace _03_03_ComparisonOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci tam sayiyi giriniz: ");
            int? a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ikinci tam sayiyi giriniz: ");
            int? b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} != {b} : {a != b}");
            Console.WriteLine($"{a} > {b} : {a > b}");
            Console.WriteLine($"{a} < {b} : {a < b}");
            Console.WriteLine($"{a} >= {b} : {a >= b}");
            Console.WriteLine($"{a} <= {b} : {a <= b}");
            Console.WriteLine($"{a} == {b} : {a == b}");

            Console.ReadKey();
        }
    }
}
