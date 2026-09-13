using System.Collections;

// Object
var arrayList = new ArrayList()
{
    1, 2, 3, 4, "Fatma", true, new DateTime()
};

int sum = 0;

foreach (var item in arrayList) 
{
    if (item is int num) 
    {
        sum += num;
    }
}

foreach (var item in arrayList) 
{
    Console.WriteLine(item);
}

Console.ReadKey();