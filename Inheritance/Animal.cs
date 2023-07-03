using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        { }
        public string LandSeaAir { get; set; }
       
        public int Legs { get; set; }
       
        public bool HasTail { get; set; }
       
        public string EyeColor { get; set; }
    }

}

