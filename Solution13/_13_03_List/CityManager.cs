internal class CityManager
{
    private readonly List<City> cityList;

    public CityManager() 
    {
        cityList = new List<City>();
    }

    public void AddCity(int id, string name)
    {
        cityList.Add(new City(id, name));
    }

    public void PrintAllCities() 
    {
        Console.WriteLine("=== Sehir Listesi ===\n");

        foreach (var item in cityList)
        {
            Console.WriteLine(item);
        }
    }
}
