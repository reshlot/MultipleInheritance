using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsConnected { get; set; }
        public int BatteryLevel { get; set; }

        public Smartphone(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public bool Connect()
        {
            // Connect implementation logic
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            // Charge implementation logic
            BatteryLevel += minutes;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
        }

        public string Display()
        {
            // Display implementation logic
            return $"{Brand} {Model} -> Battery Level: {BatteryLevel}%\n";
        }
    }
}
