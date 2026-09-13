using Contracts;

namespace Models;

public class Laptop : IRechargeable 
{
    public String Model { get; } // Okunabilir

    private int batteryLevel; // ic durumu yonetmek icin tanimladigimiz degisken | field

    public int BatteryLevel => batteryLevel;

    public Laptop(string model, int initialBatteryLevel = 40) 
    {
        Model = model;
        
        batteryLevel = Math.Clamp(initialBatteryLevel, 0, 100);
    }

    public void Recharge(int amount)
    {
        batteryLevel = Math.Clamp(batteryLevel + amount, 0, 100);

        Console.WriteLine($"[Laptop] {Model} sarj edildi. Seviye %{batteryLevel}");

    }
 }


