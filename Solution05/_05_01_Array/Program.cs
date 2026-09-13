// dizi tanimlama
int[] numbers = new int[5];

// deger atama
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

System.Console.WriteLine("\nDizi elemanlari:");

for (int i = 0; i < numbers.Length; i++) 
{
    System.Console.WriteLine($"numbers[{i}] = {numbers[i]}");
}

System.Console.WriteLine("\nDizi elemanlari (ters sirada):");
for (int i = numbers.Length - 1; i >= 0 ; i--)
{
    System.Console.WriteLine($"numbers[{i}] = {numbers[i]}"); 
}

Console.ReadKey();