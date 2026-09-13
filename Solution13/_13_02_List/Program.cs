var numbers = new List<int>()
{
    10, 20, 30, 40, 50, 60
};

numbers.Add(-5);

numbers.AddRange(new int[] { -5, -3, 5, 101, 15 });

int sum = 0;

foreach (int num in numbers) 
{
    sum += num;

    Console.WriteLine(num);
}

Console.WriteLine($"\nToplam: {sum}");

Console.ReadKey();
