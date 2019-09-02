using System;


namespace cats_and_dogs
{
    public class Singleton
    {
        private static Singleton single;
        int move;

        protected Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (single == null)
                    single = new Singleton();
                return single;
            }
        }

        public delegate void Notice();
        public event Notice PassNotice;

        public void Pass()
        {
            move++;
            if (move == 1)              { Console.WriteLine($"прошeл {move} день"); }
            if (move > 1 && move <= 4)  { Console.WriteLine($"прошло {move} дня"); }
            if (move > 4)               { Console.WriteLine($"прошло {move} дней"); }
            PassNotice?.Invoke();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("");
        }

    }
}
