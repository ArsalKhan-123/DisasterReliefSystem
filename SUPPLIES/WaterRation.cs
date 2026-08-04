using System;
namespace DisasterReliefSystem.SUPPLIES;

public class WaterRation : SupplyItem
{
    private double liters;

    public WaterRation(double liters) 
        : base("Water Ration Pack", liters * 1.0, liters * 0.001)
    {
        this.liters = liters;
    }

    public override double CalculateUrgencyValue()
    {
        return 85.0;
    }
}