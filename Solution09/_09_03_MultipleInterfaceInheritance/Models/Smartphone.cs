using MultipleInterfaceInheritance.Contracts;

namespace MultipleInterfaceInheritance.Models;

public class Smartphone : IRechargeable, IConnectable
{
    public String Model { get; set; }

    public Smartphone(string model)
    {
        Model = model;
    }

    public void Connect()
    {
        Console.WriteLine($"{Model}'e baglaniliyor.");
    }

    public void Recharge()
    {
        Console.WriteLine($"{Model} sarj ediliyor.");
    }
}
