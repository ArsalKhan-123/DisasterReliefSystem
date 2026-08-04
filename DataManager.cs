using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DisasterReliefSystem;

public static class DataManager
{
    public static void SaveShelters(List<EmergencyShelter> shelters, string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        
        string jsonText = JsonSerializer.Serialize(shelters, options);
        File.WriteAllText(filePath, jsonText);

        Console.WriteLine($"[Data Saved] Shelters successfully written to {filePath}");
    }

        public static List<EmergencyShelter> LoadShelters(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"[Notice] File '{filePath}' not found. Returning an empty list.");
            return new List<EmergencyShelter>();
        }

        string jsonText = File.ReadAllText(filePath);
        List<EmergencyShelter>? shelters = JsonSerializer.Deserialize<List<EmergencyShelter>>(jsonText);

        Console.WriteLine($"[Data Loaded] Successfully read shelters from {filePath}");
        return shelters ?? new List<EmergencyShelter>();
    }
}