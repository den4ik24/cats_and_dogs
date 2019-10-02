using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cats_and_dogs
{
    public class Pastbishe
    {
        public List<Sheep> Sheeps = new List<Sheep>();
        public List<Wolf> Wolves = new List<Wolf>();
        
        public virtual void Add(IPastbisheAnimal animal)
        {
            AddSheep(animal);
            SheepTempCountMessage();
            AddWolf(animal);
            RemainedSheepMessage();
        }

        private void AddWolf(IPastbisheAnimal animal)
        {
            if (animal is Wolf)
            {
                var wOOOlf = (Wolf)animal;
                Wolves.Add(wOOOlf);

                WolfEaterMessage();
            }
        }

        private void AddSheep(IPastbisheAnimal animal)
        {
            
            if (animal is Sheep)
            {
                var shEEEp = (Sheep)animal;
                Sheeps.Add(shEEEp);
            }
        }

        private void SheepTempCountMessage()
        {
            StringBuilder temp = new StringBuilder();
            foreach (var ovca in Sheeps)
            {
                temp.Append(ovca);
            }

            if (Sheeps.Count == 1)
            {
                Console.WriteLine($"Овца {temp.ToString()} пасется на пастбище одна - одинешенька.");
            }


            if (Sheeps.Count > 1)
            {
                Console.WriteLine($"Овцы {temp.ToString()} пасутся на пастбище, количеством {Sheeps.Count} голов");
            }
            
        }


        private void WolfEaterMessage()
        {
            StringBuilder temp = new StringBuilder();
            foreach (var wolfy in Wolves)
            {
                temp.Append(wolfy);
            }

            if (Sheeps.Count > 0 && Wolves.Count == 1)
            {
                Console.WriteLine($"Один волк {temp.ToString()} зашел к овцам " +
                    $"и {Wolves.LastOrDefault()} сожрал 1 овцу по кличке {Sheeps.LastOrDefault()}");
                Sheeps.RemoveAt(Sheeps.Count - 1);
                return;
            }

            if (Sheeps.Count > 0 && Wolves.Count > 1 && Wolves.Count < 4)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-х волков, " +
                    $"и {Wolves.LastOrDefault()} сожрал 1 овцу по кличке {Sheeps.LastOrDefault()}");
                Sheeps.RemoveAt(Sheeps.Count - 1);
                return;
            }

            if (Sheeps.Count > 0 && Wolves.Count > 4 && Wolves.Count <20)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-и волков, " +
                    $"и {Wolves.LastOrDefault()} сожрал 1 овцу по кличке {Sheeps.LastOrDefault()}");
                Sheeps.RemoveAt(Sheeps.Count - 1);
            }

            if (Sheeps.Count > 0 && Wolves.Count > 20)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-о волка, " +
                    $"и {Wolves.LastOrDefault()} сожрал 1 овцу по кличке {Sheeps.LastOrDefault()}");
                Sheeps.RemoveAt(Sheeps.Count - 1);
            }

            if (Wolves.Count > Sheeps.Count)
            {
                Console.WriteLine("Кто-то может остаться голодным");
                Console.WriteLine();
            }

            NoSheepMessage(temp);
        }

        private void NoSheepMessage(StringBuilder temp)
        {
            if (Sheeps.Count == 0 && Wolves.Count == 1)
            {
                Console.WriteLine($"{Wolves.Count} волк {temp.ToString()} зашел к овцам, и облизнулся. \nВсех овец уже сожрали. ");
                Console.WriteLine();
            }

            if(Sheeps.Count == 0 && Wolves.Count > 1 && Wolves.Count <= 10)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-х волков, и облизнулись. \nВсех овец уже сожрали. ");
                Console.WriteLine();
            }

            if (Sheeps.Count == 0 && Wolves.Count > 10 && Wolves.Count <= 20)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-и волков, и облизнулись. \nВсех овец уже сожрали. ");
                Console.WriteLine();
            }

            if (Sheeps.Count == 0 && Wolves.Count > 20)
            {
                Console.WriteLine($"{temp.ToString()} зашли к овцам в количестве {Wolves.Count}-го волков, и облизнулись. \nВсех овец уже сожрали. ");
                Console.WriteLine();
            }
        }

        private void RemainedSheepMessage()
        {
            if (Sheeps.Count == 0)
            {
                Console.WriteLine("На пастбище не осталось не одной овцы ");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------");
                return;
            }

            var sheepName = "";
            if (Sheeps.Count == 1 || Sheeps.Count > 20)
            {
                sheepName = "овца";
            }

            if (Sheeps.Count >1 && Sheeps.Count < 4)
            {
                sheepName = "овцы";
            }

            if (Sheeps.Count > 4 && Sheeps.Count <= 20)
            {
                sheepName = "овец";
            }

            Console.WriteLine($"{Sheeps.Count} {sheepName} осталась на пастбище ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
        }

    }
}