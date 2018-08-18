using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Species
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public bool HasTail { get; set; }


        public virtual void GetInfo()
        {
            Console.WriteLine("{0} weighs {1} pounds and is {2} inches tall and lives in {3}.", Name, Weight, Height, Habitat);
        }

        public double Sum()
        {
            double sum;
            sum = Weight + Height;
            return sum;
        }

        public virtual double GetWeight(double num)
        {
            return Weight;
        } 

    }

}
