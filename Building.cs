using System;

namespace Planner
{
    public class Building
    {
        // Private fields. Fields are very similar to properties, but are by convention private
        // and they don't have a getter and setter
        private int _milesDriven;

        private string _designer = "Jayson Rice";
        private string _address;
        private string _owner;

        private DateTime _dateConstructed;

        private int _milesAtLastService;

        // Public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        // Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }

        public int GetMaintenanceAtMileage()
        {
            return _milesAtLastService + 5_000;
        }

        // Constructor Method
        public Building(string address)
        {
            _address = address;
        }

    }
}