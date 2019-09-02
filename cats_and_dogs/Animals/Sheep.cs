using System;
using cats_and_dogs.Animals;

namespace cats_and_dogs
{
    public class Sheep : Animal, IPastbisheAnimal
    {

        public override void Voice()
        {
            Console.WriteLine(Name + " say " + "Bbbeee-e-e");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}