using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            City JohnsonCity = new City()
            {
                Name = "Johnson City",
                Mayor = "Jenny Brock",
                Year = 1856
            };

            // List<Building> buildings = new List<Building>();

            Building KevinsHouse = new Building("237 Street Dr")
            {
                Stories = 3,
                Width = 45,
                Depth = 40
            };

            KevinsHouse.Construct();
            KevinsHouse.Purchase("Kevin Mast");
            JohnsonCity.AddBuilding(KevinsHouse);

            Building LindseysBuilding = new Building("512 8th Avenue")
            {
                Stories = 2,
                Width = 90,
                Depth = 150
            };
            LindseysBuilding.Construct();
            LindseysBuilding.Purchase("Lindsey King");
            JohnsonCity.AddBuilding(LindseysBuilding);

            Building RonsHouse = new Building("223 Stone Dr")
            {
                Stories = 3,
                Width = 110,
                Depth = 100
            };
            RonsHouse.Construct();
            RonsHouse.Purchase("Ron Rice");
            JohnsonCity.AddBuilding(RonsHouse);

            Console.WriteLine($"{JohnsonCity.Name}'s List of Buildings");
            foreach (Building building in JohnsonCity.GetBuildings())
            {
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("---------------");
                Console.WriteLine($"Designed by: {building.GetDesigner()}");
                Console.WriteLine($"Constructed on {building.GetDateBuilt()}");
                Console.WriteLine($"Owned by {building.BuildingOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine();
            }
        }
    }
}