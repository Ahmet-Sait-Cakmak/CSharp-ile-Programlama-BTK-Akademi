using Behaviour.Models;

var employees = new Employee[]
{
    new Employee(1, "Ahmet", 30000m),
    new Employee(2, "Fatma", 45000m),
    new Employee(3, "Zeynep", 50000m),
    new Employee(4, "Ali", 30000),
    new Employee(5, "Nida", 60000)
};

Array.Sort(employees);

foreach (var employee in employees) 
{
    Console.WriteLine(employee);
}

Console.ReadKey();
