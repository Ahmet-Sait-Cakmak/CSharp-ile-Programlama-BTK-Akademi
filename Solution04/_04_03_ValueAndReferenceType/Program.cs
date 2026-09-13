// Deger tip

int num1 = 10;
int num2 = 20;

Console.WriteLine($"Metot cagrisi oncesi num1 = {num1} ve num2 = {num2}");
SwapNumbers(num1, num2);
Console.WriteLine($"Metot cagrisi sonrasinda num1 = {num1} ve num2 = {num2}");

static void SwapNumbers(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}

// Referans tip
int[] array = { 10, 20 };
Console.WriteLine($"\nMetot cagrisi oncesi array[0] = {array[0]} ve array[1] = {array[1]}");
SwapArray(array);
Console.WriteLine($"Metot cagrisi sonrasinda array[0] = {array[0]} ve array[1] = {array[1]}");

static void SwapArray(int[] arr)
{
    int temp = arr[0];
    arr[0] = arr[1];
    arr[1] = temp;
}
