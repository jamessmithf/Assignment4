using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCA
{
    class River : GeographycalObject
    {
        private double _flowSpeed;
        private double _length;
        public double FlowSpeed { get { return _flowSpeed; } set { if (value < 0 || value > 500) _flowSpeed = 0; else _flowSpeed = value; } }
        public double Length { get { return _length; } set { if (value < 20) _length = 20; else _length = value; } }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Flow speed of the river is {FlowSpeed} cm/s");
            Console.WriteLine($"{Name} total length is {Length} meters");
        }
    }
}
