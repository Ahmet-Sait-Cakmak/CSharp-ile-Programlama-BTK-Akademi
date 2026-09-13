// Arayüz tür
using Contracts;
using Models;

IRechargeable[] devices = new IRechargeable[] 
{
    new Phone("Pixy 7", 30),
    new Laptop("Ultrabook 14", 65)
};

Console.WriteLine("=== Baslangic Batarya Seviyeleri ===\n");

foreach (var device in devices)
{
    Console.WriteLine($"{device.GetType().Name}" +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-', 25));
}

Console.WriteLine("\n=== Tum cihazlari sarz et ===\n");

foreach (var device in devices) 
{
    device.Recharge(25);
}

Console.WriteLine("\n\n=== Sarj Edildikten Sonraki Batarya Seviyeleri ===\n");

foreach (var device in devices)
{
    Console.WriteLine($"{device.GetType().Name}" +
        $"\n{(device is Phone p ? p.Model : ((Laptop)device).Model)}" +
        $"\nBatarya Seviyesi: %{device.BatteryLevel}");

    Console.WriteLine(new String('-', 25));
}

Console.ReadKey();