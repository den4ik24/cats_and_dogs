using System;

namespace cats_and_dogs
{
    public class PastuhWithWeapon<T> : Pastuh where T: IWeapon
    {
        public T Combat;

        public void PastuhSay()
        {
            Combat.Speech();
        }

        protected override void BattleRoar()
        {
            Combat.Speech();
        }
    }
}
