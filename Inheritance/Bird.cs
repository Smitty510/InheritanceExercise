using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            LandSeaAir = "Air";
            Legs = 2;
            HasTail = true;
            EyeColor = "black";
        }

        public string FeatherColor { get; set; }

        public double BeakLength { get; set; }

        public bool MakesNest { get; set; }

        public bool CanSing { get; set; }

        




    }
}
