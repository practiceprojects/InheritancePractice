using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptiles dragonLizard = new Reptiles (72.6, 14, "Herman", "Spain", true);
            dragonLizard.GetInfo();

            Mammals wolf = new Mammals(36, 85, "Wolfie", "Austria", true);
            wolf.GetInfo();

            Console.WriteLine(dragonLizard.Sum());
            Console.WriteLine(wolf.Sum());
            Console.WriteLine(dragonLizard.GetWeight(0));
            Console.WriteLine(wolf.GetWeight(100));

        }

    }
}
