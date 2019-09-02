using System;
using cats_and_dogs.Animals;


namespace cats_and_dogs
{
    public class Animal

    {
        public string Name { get; set; }
        public virtual void Voice()
        {
            Console.WriteLine("Animals have a Voice");
        }
    }

    
}
