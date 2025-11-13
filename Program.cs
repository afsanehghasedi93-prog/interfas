
using System;
using System.Collections.Generic;
using interfas;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfas
{
   public class program
    {
        public static void Main(string[] args)
        {
            List<ianimal> animals = new List<ianimal>
            {
new dog(),
            new Cat(),
new Bird(),
          new Fish(),
            } ;
            Console.WriteLine("animal shelter daily routine");
            foreach (ianimal animal in animals)
            {
                Console.WriteLine($"\n**processing:{animal.GetType().Name}**");
               ianimal.walk();
              ianimal.Eat();
               ianimal.MakeSound();
              ianimal.Sleep();
            }
            Console.WriteLine("\n---daily routine completed---");
            Console.ReadKey();
        }
    }
    
    
    }

