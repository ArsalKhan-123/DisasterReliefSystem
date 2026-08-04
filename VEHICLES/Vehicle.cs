using System;
using DisasterReliefSystem.SUPPLIES;
namespace DisasterReliefSystem.VEHICLES;

public abstract class Vehicle
{
    private string vehicleId;
    private double maxWeightCapacity;
    private double maxVolumeCapacity;
    
    private SupplyItem[] cargoBay;
    private int loadedItemCount;

    public Vehicle(string vehicleId, double maxWeightCapacity, double maxVolumeCapacity, int maxItemCount)
    {
        this.vehicleId = vehicleId;
        this.maxWeightCapacity = maxWeightCapacity;
        this.maxVolumeCapacity = maxVolumeCapacity;
        this.cargoBay = new SupplyItem[maxItemCount];
        this.loadedItemCount = 0;
    }

    public string GetVehicleId() { return vehicleId; }

    public double GetCurrentWeight()
    {
        double totalWeight = 0.0;
        for (int i = 0; i < loadedItemCount; i++)
        {
            totalWeight += cargoBay[i].GetWeightKg();
        }
        return totalWeight;
    }

    public double GetCurrentVolume()
    {
        double totalVolume = 0.0;
        for (int i = 0; i < loadedItemCount; i++)
        {
            totalVolume += cargoBay[i].GetVolumeM3();
        }
        return totalVolume;
    }

    public bool LoadSupply(SupplyItem item)
    {
        if (loadedItemCount >= cargoBay.Length) return false;
        if (GetCurrentWeight() + item.GetWeightKg() > maxWeightCapacity) return false;
        if (GetCurrentVolume() + item.GetVolumeM3() > maxVolumeCapacity) return false;

        cargoBay[loadedItemCount] = item;
        loadedItemCount++;
        return true;
    }

    bool CanTraverseTerrain(int terrainSeverityCode);
}