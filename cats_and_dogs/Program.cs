﻿using System;
using System.Collections.Generic;

namespace cats_and_dogs
{
    class Program
    {
        //public delegate void MethodContainer();
        //public event MethodContainer ;
        private static readonly NewPastbishe newPastbishe = new NewPastbishe();

        static Wolf CrW;
        

        static void Main()
        {
            Console.WriteLine(@"Введите кого вы хотите добавить на пастбище:
                               Для выбора Овцы нажмите - ""S"" - (sheep)
                               Для выбора Волка нажмите ""W"" - (wolf)");
            Console.WriteLine("");

            ConsoleKeyInfo key; 
            //NewPastbishe newPastbishe = new NewPastbishe();

            newPastbishe.AddWolf += PastuhCame;
            

                var random = new Random();
            do
            {
                var sheepsName = new List<string> { "Чернявка ", "Звездочка ", "Бяшка ", "Кучерявая " };
                int SheepNameIndex = random.Next(sheepsName.Count);

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.W)
                {
                    CrW = CreateWolf();
                    newPastbishe.Add(CrW);
                }

                if (key.Key == ConsoleKey.S)
                {
                    newPastbishe.Add(new Sheep { Name = sheepsName[SheepNameIndex] });
                }

                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S)
                {

                    Singleton.Instance.Pass();
                }
            }
            while (key.Key != ConsoleKey.Escape);

        }

        static Wolf CreateWolf()
        {
            var random = new Random();
            string WolfName;

            var wolfsName = new List<string> { "Серый ", "Грозный ", "Акелла ", "Ракша ", "Рваный ", "Кривой " };
            int WolfNameIndex = random.Next(wolfsName.Count);
            int CyberWolfVuln = random.Next(2);
            WolfName = wolfsName[WolfNameIndex];

            if (CyberWolfVuln == 0)
            {
                Console.WriteLine("Показался волк с уязвимостью к ближнему оружию");
                return new CyberWolf<VulnerabilityCloseWeapon> { Name = WolfName };
            }

            if (CyberWolfVuln == 1)
            {
                Console.WriteLine("Показался волк с уязвимостью к дальнему оружию");
                return new CyberWolf<VulnerabilityLongRageWeapon> { Name = WolfName };
            }

            throw new IndexOutOfRangeException("Not possible");
        }

        static void PastuhCame()
        {

            Fork fork = new Fork();
            LightSaber lightSaber = new LightSaber();
            Dagger dagger = new Dagger();
            Flamethrower flamethrower = new Flamethrower();
            MiniGun miniGun = new MiniGun();
            HeavyMortars heavyMortars = new HeavyMortars();

            var random = new Random();
            Pastuh P;

            if (CrW is CyberWolf<VulnerabilityCloseWeapon>)
            {
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

                List<Pastuh> pastuhCloseWeapon = new List<Pastuh> { pastuhFork, pastuhLightSaber, pastuhDagger };
                int pastuhCloseWeaponIndex = random.Next(pastuhCloseWeapon.Count);
                P = pastuhCloseWeapon[pastuhCloseWeaponIndex];
                P.Attention();
                pastuhFork.GoPastuh += newPastbishe.WolvesCount;
                pastuhLightSaber.GoPastuh += newPastbishe.WolvesCount;
                pastuhDagger.GoPastuh += newPastbishe.WolvesCount;

            }

            if (CrW is CyberWolf<VulnerabilityLongRageWeapon>)
            {
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

                List<Pastuh> pastuhLongWeapon = new List<Pastuh> { pastuhFlamethrower, pastuhMiniGun, pastuhHeavyMortars };
                int pastuhLongWeaponIndex = random.Next(pastuhLongWeapon.Count);
                P = pastuhLongWeapon[pastuhLongWeaponIndex];
                P.Attention();
                pastuhFlamethrower.GoPastuh += newPastbishe.WolvesCount;
                pastuhMiniGun.GoPastuh += newPastbishe.WolvesCount;
                pastuhHeavyMortars.GoPastuh += newPastbishe.WolvesCount;
            }

        }

    }

}

