using System;
namespace DisasterReliefSystem.VEHICLES;

public class SupplyTruck : Vehicle
{
    public SupplyTruck(string vehicleId) 
        : base(vehicleId, 2500.0, 15.0, 100) { }

    public override bool CanTraverseTerrain(int terrainSeverityCode)
    {
        // Trucks can only pass clear roads
        return terrainSeverityCode == 1; 
    }
}