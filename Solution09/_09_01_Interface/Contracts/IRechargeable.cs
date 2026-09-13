namespace Contracts;
public interface IRechargeable 
{ 
    // yapisal ozellik
    int BatteryLevel { get; }

    // davranissal ozellik
    void Recharge(int amount);
}


