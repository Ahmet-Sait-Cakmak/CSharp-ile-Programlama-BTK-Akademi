Number number1 = new Number(); // Referans | Physical

number1.SingleNumber = -10;
number1.Description = "Numaralar uzerinde islem yapmak uzere tasarlanmis sinifimiz.";
number1.Count = 0;

Number number2 = new Number() 
{
    SingleNumber = 20,
    Description = "20 sayisini ele alacagiz.",
    Count = 100
};

Number number3 = new Number(55, "55 sayisini dikkate al."); 


System.Console.WriteLine($"Number: {number1.SingleNumber}");
System.Console.WriteLine($"Count: {number1.Count}");

System.Console.WriteLine($"Number2: {number2.SingleNumber}");
System.Console.WriteLine($"Count2: {number2.Count}");

System.Console.WriteLine($"Number3: {number3.SingleNumber}");
System.Console.WriteLine($"Count3: {number3.Count}");

Console.ReadKey();