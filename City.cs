using System;
using System.Collections.Generic;
namespace Planner
{
    public class City
    {
        // Private fields. Fields are very similar to properties, but are by convention private
        // and they don't have a getter and setter
        private List<Building> _buildings = new List<Building>();

        // Public properties
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }

        // Methods
        public void AddBuilding(Building building)
        {
            _buildings.Add(building);
        }
        public List<Building> GetBuildings()
        {
            return _buildings;
        }
    }

}