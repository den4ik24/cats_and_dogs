using System;
using cats_and_dogs.Animals;

namespace cats_and_dogs
{
    public class Wolf : Animal, IPastbisheAnimal
    {

        public override void Voice()
        {
            Console.WriteLine(Name + " say " + "Wowooo");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}