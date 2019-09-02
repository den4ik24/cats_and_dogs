using System;
namespace cats_and_dogs.Animals
{
    class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine(Name + " say " + "Waw-Waw");
        }
    }
}
