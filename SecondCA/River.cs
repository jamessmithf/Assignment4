using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SecondCA
{
    class River : IGeograpyalObject
    {
        private string _name = "Unknown";
        private double _x;
        private double _y;
        private string _description = "Description is empty";
        private double _flowSpeed;
        private double _length;

        public string Name { get { return _name; } set { if (!string.IsNullOrEmpty(value)) _name = value; } }
        public double X { get { return _x; } set { if (value < -90 || value > 90) _x = 0; else _x = value; } }
        public double Y { get { return _y; } set { if (value < -180 || value > 180) _y = 0; else _y = value; } }
        public string Description { get { return _description; } set { if (!string.IsNullOrEmpty(value)) _description = value; } }
        public double FlowSpeed { get { return _flowSpeed; } set { if (value < 0 || value > 500) _flowSpeed = 0; else _flowSpeed = value; } }
        public double Length { get { return _length; } set { if (value < 20) _length = 20; else _length = value; } }

        public void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Location - x: {X}; y: {Y}");
            Console.WriteLine(Description);
            Console.WriteLine($"Flow speed of the river is {_flowSpeed} cm/s");
            Console.WriteLine($"{Name} total length is {Length} meters");
        }
    }
}
