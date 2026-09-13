using Contracts;

namespace Models;

public class Phone : IRechargeable
{
    public string Model { get; }
    private int batteryLevel; // ic durumu yonetmek icin tanimladigimiz degisken | field
    public int BatteryLevel => batteryLevel;

    public Phone(string model, int initialBatteryLevel = 50)
    {
        Model = model;

        batteryLevel = Math.Clamp(initialBatteryLevel, 0, 100);
    }

    public void Recharge(int amount)
    {
        batteryLevel = Math.Clamp(batteryLevel + amount, 0, 100);

        Console.WriteLine($"[Phone] {Model} sarj edildi. Sarj seviyesi: %{batteryLevel}");
    }
}


