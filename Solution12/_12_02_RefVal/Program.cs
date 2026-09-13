System.Console.WriteLine("\n=== Deger ve Referans Tip Farki ===\n");

var v1 = new ValPoint(10, 20);

var v2 = v1; // deger tipli kopyalama!

v2.x = 50;

System.Console.WriteLine(v1);
System.Console.WriteLine(v2);

var r1 = new RefPoint(10, 20);

var r2 = r1;

r2.x = 50;

System.Console.WriteLine(r1);
System.Console.WriteLine(r2);

Console.ReadKey();