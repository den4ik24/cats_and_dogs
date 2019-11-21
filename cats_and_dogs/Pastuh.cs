using System;
using System.Collections.Generic;

namespace cats_and_dogs
{
    public class Pastuh
    {

        int step;
        public List <string> pastuhName = new List<string> { "Пал Палыч", "Тимофей Емельянович", "Федор Димитриевич", "Олег Николаевич" };
        public Random random = new Random();
        string N;

        public void Attention()
        {
            int pastuhNameIndex = random.Next(pastuhName.Count);
            N =  pastuhName[pastuhNameIndex];
            Console.WriteLine();
            Console.WriteLine($@"Берегитесь ""Санитары леса""! Пастух {N} спешит на помощь.");
            Console.WriteLine();
            Singleton.Instance.PassNotice += Go;  
        }

        public delegate void MethodContainer();
        public event MethodContainer GoPastuh;
        
        public void Go()
        {
            step++;

            if (step == 2)
            {
                GoPastuh?.Invoke();
                BattleRoar();

                Singleton.Instance.PassNotice -= Go;
                step = 0;
            }
            if (step > 0)
            {
                Console.WriteLine($"Пастух прибудет через {step} ход");
            }
        }
//не участвует
        protected virtual void BattleRoar()
        {
            Console.WriteLine($@"Пастух {N} прибыл на пастбище - ""Пятачок, неси ружье! "" ");
            Console.WriteLine();
        }
    }
}
