using MultipleInterfaceInheritance.Contracts;

using MultipleInterfaceInheritance.Models;


Smartphone phone = new Smartphone("Pixy 10");

phone.Recharge();

phone.Connect();


IRechargeable batteryRef = phone;
IConnectable netRef = phone;

batteryRef.Recharge();

netRef.Connect();

Console.ReadKey();
