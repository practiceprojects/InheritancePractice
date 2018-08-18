using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Mammals : Species
    {
        public Mammals(double Height, double Weight, string Name, string Habitat, bool HasTail)
        {
            this.Height = Height;
            this.Weight = Weight;
            this.Name = Name;
            this.Habitat = Habitat;
            this.HasTail = HasTail;
        }

        public override double GetWeight(double num)
        {
            num = num + Weight;
            return num;
        }
    }
}
