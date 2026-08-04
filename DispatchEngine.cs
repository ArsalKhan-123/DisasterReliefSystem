using System;
using System.Collections.Generic;

namespace DisasterReliefSystem;

public class DispatchEngine
{
    private EmergencyShelter[] shelters;
    private int shelterCount;

    public DispatchEngine(int capacity)
    {
        shelters = new EmergencyShelter[capacity];
        shelterCount = 0;
    }

    public int GetShelterCount()
    {
        return shelterCount;
    }

    public bool AddShelter(EmergencyShelter shelter)
    {
        if (shelterCount < shelters.Length)
        {
            shelters[shelterCount] = shelter;
            shelterCount++;
            return true;
        }
        return false;
    }

    public void SortSheltersByPriority()
    {
        for (int i = 0; i < shelterCount - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < shelterCount; j++)
            {
                if (shelters[j].CalculatePriorityScore() > shelters[maxIndex].CalculatePriorityScore())
                {
                    maxIndex = j;
                }
            }

            EmergencyShelter temp = shelters[i];
            shelters[i] = shelters[maxIndex];
            shelters[maxIndex] = temp;
        }
    }

    public void DisplayPriorityList()
    {
        Console.WriteLine("\n========== PRIORITY DISPATCH LIST ==========");
        for (int i = 0; i < shelterCount; i++)
        {
            Console.WriteLine("[" + (i + 1) + "] Shelter: " + shelters[i].GetLocationName() +
                              " | Casualties: " + shelters[i].GetCasualtyCount() +
                              " | Water Left: " + shelters[i].GetWaterReserveHours() + "h" +
                              " | Priority Score: " + shelters[i].CalculatePriorityScore());
        }
        Console.WriteLine("============================================\n");
    }
    

    public void SaveToFile(string filePath)
    {
        List<EmergencyShelter> listToSave = new List<EmergencyShelter>();
        for (int i = 0; i < shelterCount; i++)
        {
            listToSave.Add(shelters[i]);
        }

        DataManager.SaveShelters(listToSave, filePath);
    }

    public void LoadFromFile(string filePath)
    {
        List<EmergencyShelter> loadedList = DataManager.LoadShelters(filePath);
        foreach (var shelter in loadedList)
        {
            AddShelter(shelter);
        }
    }
}