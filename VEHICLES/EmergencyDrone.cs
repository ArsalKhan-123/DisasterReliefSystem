using System;
namespace DisasterReliefSystem.VEHICLES;

public class EmergencyDrone : Vehicle
{
    public EmergencyDrone(string vehicleId) 
        : base(vehicleId, 20.0, 0.1, 5) { }

    public override bool CanTraverseTerrain(int terrainSeverityCode)
    {
        // Drones fly over ground damage (Terrain code 1: Clear, 2: Flooded, 3: Destroyed)
        return terrainSeverityCode <= 2; 
    }
}