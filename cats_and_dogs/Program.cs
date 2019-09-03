using System;
using System.Collections.Generic;

namespace cats_and_dogs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Введите кого вы хотите добавить на пастбище:
                               Для выбора Овцы нажмите - ""S"" - (sheep)
                               Для выбора Волка нажмите ""W"" - (wolf)");
            Console.WriteLine("");

            ConsoleKeyInfo key;

            Pastuh pastuh = new Pastuh();
            PastuhPastbishe pastuhPastbishe = new PastuhPastbishe();
            pastuhPastbishe.AddWolf += pastuh.Attention;
            pastuh.Come += pastuhPastbishe.PastuhCome;

            Fork fork = new Fork();
            LightSaber lightSaber = new LightSaber();
            Dagger dagger = new Dagger();
            Flamethrower flamethrower = new Flamethrower();
            MiniGun miniGun = new MiniGun();
            HeavyMortars heavyMortars = new HeavyMortars();

            VulnerabilityCloseWeapon vulnerabilityCloseWeapon = new VulnerabilityCloseWeapon();
            VulnerabilityLongRageWeapon vulnerabilityLongRageWeapon = new VulnerabilityLongRageWeapon();

            PastuhWithWeapon<Fork> pastuhFork = new PastuhWithWeapon<Fork>
            {
                Combat = fork
            };
            PastuhWithWeapon<LightSaber> pastuhLightSaber = new PastuhWithWeapon<LightSaber>
            {
                Combat = lightSaber
            };
            PastuhWithWeapon<Dagger> pastuhDagger = new PastuhWithWeapon<Dagger>
            {
                Combat = dagger
            };
            PastuhWithWeapon<Flamethrower> pastuhFlamethrower = new PastuhWithWeapon<Flamethrower>
            {
                Combat = flamethrower
            };
            PastuhWithWeapon<MiniGun> pastuhMiniGun = new PastuhWithWeapon<MiniGun>
            {
                Combat = miniGun
            };
            PastuhWithWeapon<HeavyMortars> pastuhHeavyMortars = new PastuhWithWeapon<HeavyMortars>
            {
                Combat = heavyMortars
            };


            CyberWolf<VulnerabilityCloseWeapon> cyberWolfVulnerabilityCloseWeapon = new CyberWolf<VulnerabilityCloseWeapon>
            {
                Vulnerability = vulnerabilityCloseWeapon
            };
            CyberWolf<VulnerabilityLongRageWeapon> cyberWolfVulnerabilityLongWeapon = new CyberWolf<VulnerabilityLongRageWeapon>
            {
                Vulnerability = vulnerabilityLongRageWeapon
            };

            do
            {
                var random = new Random();

                var sheepsName = new List<string> { "Чернявка ", "Звездочка ", "Бяшка ", "Кучерявая " };
                var wolfsName = new List<string> { "Серый ", "Грозный ", "Акелла ", "Ракша ", "Рваный ", "Кривой " };

                int SheepNameIndex = random.Next(sheepsName.Count);
                int WolfNameIndex = random.Next(wolfsName.Count);

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.W)
                {
                    pastuhPastbishe.Add(new Wolf { Name = wolfsName[WolfNameIndex] });
                }

                if (key.Key == ConsoleKey.S)
                {
                    pastuhPastbishe.Add(new Sheep { Name = sheepsName[SheepNameIndex] });
                }

                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S)
                {
                    
                    Singleton.Instance.Pass();
                }
            }
            while (key.Key != ConsoleKey.Escape);

        }

    }
}
