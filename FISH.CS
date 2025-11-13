using System;
using System.Collections.Generic;
using interfas;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfas
{
    // کلاس ماهی اینترفیس IAnimal را پیاده‌سازی می‌کند.
    public class Fish 
    {
        public void Walk()
        {
            Console.WriteLine("Fish is swimming by moving its fins.");
        }

        public void Eat()
        {
            Console.WriteLine("Fish is consuming flakes from the water surface.");
        }

        public void Sleep()
        {
          
            Console.WriteLine("Fish is resting motionlessly near a rock.");
        }
        public void MakeSound()
        {
            Console.WriteLine("(Fish does not make a recognizable sound)");
        }
    }
}
class FISH
    {
    }

