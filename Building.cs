using System;

namespace Planner
{
    public class Building
    {
        // Private fields. Fields are very similar to properties, but are by convention private
        // and they don't have a getter and setter

        private string _designer = "Jayson Rice";
        private string _address;
        private string _owner;

        private DateTime _dateConstructed;

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
        public string BuildingOwner()
        {
            return _owner;
        }

        public string GetDesigner()
        {
            return _designer;
        }
        public string GetAddress()
        {
            return _address;
        }
        public DateTime GetDateBuilt()
        {
            return _dateConstructed;
        }
        // Constructor Method
        public Building(string address)
        {
            _address = address;
        }

    }
}