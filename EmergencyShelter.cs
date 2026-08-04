using System;

namespace DisasterReliefSystem;

public class EmergencyShelter
{
    public string ShelterId { get; set; }
    public string LocationName { get; set; }
    public int CasualtyCount { get; set; }
    public double WaterReserveHours { get; set; }

    
    public EmergencyShelter() 
    {
        ShelterId = "";
        LocationName = "";
        CasualtyCount = 0;
        WaterReserveHours = 0.0;
    }

    
    public EmergencyShelter(string shelterId, string locationName, int casualtyCount, double waterReserveHours)
    {
        ShelterId = shelterId;
        LocationName = locationName;
        CasualtyCount = casualtyCount;
        WaterReserveHours = waterReserveHours;
    }

    
    public string GetShelterId() => ShelterId;
    public string GetLocationName() => LocationName;
    public int GetCasualtyCount() => CasualtyCount;
    public double GetWaterReserveHours() => WaterReserveHours;

    
    public double CalculatePriorityScore()
    {
        double hoursLeft = WaterReserveHours;
        if (hoursLeft <= 0.1) hoursLeft = 0.1; // Prevent division by zero
        return (CasualtyCount * 3.0) / hoursLeft;
    }

    public void ConsumeResourcesPerTick()
    {
        WaterReserveHours -= 1.0;
        if (WaterReserveHours < 0) WaterReserveHours = 0;
    }
}