using System;
namespace DisasterReliefSystem.SUPPLIES;

public abstract class SupplyItem
{
    private string name;
    private double weightKg;
    private double volumeM3;

    public SupplyItem(string name, double weightKg, double volumeM3)
    {
        this.name = name;
        this.weightKg = weightKg;
        this.volumeM3 = volumeM3;
    }

    public string GetName() {
         return name;
     }
    public double GetWeightKg() { 
        return weightKg; 
    }
    public double GetVolumeM3() { 
        return volumeM3; 
    }

    public abstract double CalculateUrgencyValue();
}