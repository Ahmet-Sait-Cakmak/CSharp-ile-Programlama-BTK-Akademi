var cities = new List<string> { 

    "izmir", 
    "İzmir", 
    "Isparta", 
    "isparta", 
    "Istanbul", 
    "istanbul", 
    "samsun", 
    "adana"
 };

System.Console.WriteLine(" ");

// Ordinal siralama
var ordinalSorted = new List<string>(cities);
ordinalSorted.Sort(StringComparer.Ordinal);

foreach (var item in ordinalSorted)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine($"\n{new string('-', 10)}");

// CurrentCultureIgnoreCase siralama
var currentCultureIgnoreCaseSorted = new List<string>(cities);
currentCultureIgnoreCaseSorted.Sort(StringComparer.CurrentCultureIgnoreCase);

foreach (var item in currentCultureIgnoreCaseSorted)
{
    System.Console.WriteLine(item);
}

Console.ReadKey();