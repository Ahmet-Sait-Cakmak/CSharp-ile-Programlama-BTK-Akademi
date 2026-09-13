using _08_01_OOPBasics;

int[] oddNumbers = { 11, 3, 5, 7, 11, 9};
int[] evenNumbers = { 20, 40, 16, 8, 56, 60};

var number1 = new Number(oddNumbers);
// var min = number.FindMin();
// var max = number.FindMax();
var index1 = number1.Find(50);

System.Console.WriteLine($"\nMinimum deger: {number1.Min}");
System.Console.WriteLine($"Maximum deger: {number1.Max}");
System.Console.WriteLine($"Aranan degerin indeksi: {index1}");

var number2 = new Number(evenNumbers);
var index2 = number2.Find(16);

System.Console.WriteLine($"\nMinimum deger: {number2.Min}");
System.Console.WriteLine($"Maximum deger: {number2.Max}");
System.Console.WriteLine($"Aranan degerin indeksi: {index2}");


Console.ReadKey();