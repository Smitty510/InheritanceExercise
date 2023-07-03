using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            LandSeaAir = "Land";
            Legs = 4;
            HasTail = true;
            EyeColor = "yellow";
        }

        public bool IsEndothermic { get; set; }

        public bool HasScales { get; set; }

        public bool HasDrySkin { get; set; }

        public bool LaysEggs { get; set; }










    }

}




