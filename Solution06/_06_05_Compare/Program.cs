// ornekler
var a = "İstanbul";
var b = "istanbul";
var c = "Istanbul";

System.Console.WriteLine("\n== vs Equals\n");
System.Console.WriteLine($"{a}=={b} ? {a == b}"); // İ != i

System.Console.WriteLine($"Equals({a},{b}, StringComparison.OrdinalIgnoreCase) ? " + 
$"{string.Equals(a,b, StringComparison.OrdinalIgnoreCase)}");

System.Console.WriteLine($"Equals({a},{b}, StringComparison.CurrentCultureIgnoreCase) ? " + 
$"{string.Equals(a,b, StringComparison.CurrentCultureIgnoreCase)}");

System.Console.WriteLine($"Equals({a},{c}, StringComparison.OrdinalIgnoreCase) ? " + 
$"{string.Equals(a,c, StringComparison.OrdinalIgnoreCase)}");

System.Console.WriteLine($"Equals({a},{c}, StringComparison.CurrentCultureIgnoreCase) ? " + 
$"{string.Equals(a,c, StringComparison.CurrentCultureIgnoreCase)}");

System.Console.WriteLine($"Equals({b},{c}, StringComparison.OrdinalIgnoreCase) ? " + 
$"{string.Equals(b,c, StringComparison.OrdinalIgnoreCase)}");

System.Console.WriteLine($"Equals({b},{c}, StringComparison.CurrentCultureIgnoreCase) ? " + 
$"{string.Equals(b,c, StringComparison.CurrentCultureIgnoreCase)}");

Console.ReadKey();

