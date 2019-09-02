using System;

namespace cats_and_dogs.Animals
{
    class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine(Name + " say " + "Myaw-Myaw");
        }

        public string CatName { get; set; }
    }
}
