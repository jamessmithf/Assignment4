using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstCA
{
    class Mountain : GeographycalObject
    {
        private double _peak;
        public double Peak { get { return _peak; } set { if (value < 0 ) _peak = 0; } } // meters
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The highest point of the {Name} is {Peak} meters");
        }
    }
}
