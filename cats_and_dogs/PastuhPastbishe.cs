using System;


namespace cats_and_dogs
{
    public class PastuhPastbishe : Pastbishe
    {
        public delegate void MethodContainer();
        //делегат, хранящий в себе ссылку на метод
        public event MethodContainer AddWolf;
        //событие связываем с делегатом, потом запускаем это событие

        public override void Add(IPastbisheAnimal animal)
        {
            base.Add (animal);
            if (animal is Wolf)
            {
                AddWolf?.Invoke();
            }
        }
        //не исполняется
        public void WolvesCount()
        {
            var wolfSkin = "";
            if (Wolves.Count == 1|| Wolves.Count == 21)
            {
                wolfSkin = "волчья";
            }

            if (Wolves.Count > 1 && Wolves.Count < 21)
            {
                wolfSkin = "волчьих";
            }

            Console.WriteLine($"Теперь у пастуха есть {Wolves.Count} {wolfSkin} шкура");
            Wolves.Clear();

        }
    }
}
