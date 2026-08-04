using System;
using DisasterReliefSystem.SUPPLIES;
using DisasterReliefSystem.VEHICLES;

namespace DisasterReliefSystem;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "shelters.json";
        DispatchEngine engine = new DispatchEngine(10);

        engine.LoadFromFile(filePath);

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== DISASTER RELIEF DISPATCH SYSTEM ===");
            Console.WriteLine("1. View Priority Dispatch List");
            Console.WriteLine("2. Add New Emergency Shelter");
            Console.WriteLine("3. Save & Exit");
            Console.Write("Select an option (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    engine.SortSheltersByPriority();
                    engine.DisplayPriorityList();
                    break;

                case "2":
                    Console.Write("Enter Shelter ID (e.g. S4): ");
                    string id = Console.ReadLine() ?? "";

                    Console.Write("Enter Location Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Enter Casualty Count: ");
                    string casualtyInput = Console.ReadLine() ?? "0";
                    int casualties = int.TryParse(casualtyInput, out int cVal) ? cVal : 0;

                    Console.Write("Enter Water Reserve Hours: ");
                    string waterInput = Console.ReadLine() ?? "0";
                    double water = double.TryParse(waterInput, out double wVal) ? wVal : 0.0;

                  
                    engine.AddShelter(new EmergencyShelter(id, name, casualties, water));
                    Console.WriteLine("[Success] New shelter added to system!");
                    break;

                case "3":
                    engine.SaveToFile(filePath);
                    Console.WriteLine("Data saved. Exiting...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}