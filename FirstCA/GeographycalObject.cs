using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCA
{
    internal abstract class GeographycalObject
    {
        private string _name = "Unknown";
        private double _x;
        private double _y;
        private string _description = "Description is empty";
        public string Name { get { return _name; } set { if (!string.IsNullOrEmpty(value)) _name = value; } }
        public double X { get { return _x; } set { if (value < -90 || value > 90) _x = 0; else _x = value; } }
        public double Y { get { return _y; } set { if (value < -180 || value > 180) _y = 0; else _y = value; } }
        public string Description { get { return _description; } set { if (!string.IsNullOrEmpty(value)) _description = value; } }


        public virtual void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Location - x: {X}; y: {Y}");
            Console.WriteLine(Description);
        }
    }
}
