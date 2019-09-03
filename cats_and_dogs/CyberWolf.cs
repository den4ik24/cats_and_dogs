using System;
namespace cats_and_dogs
{
    public class CyberWolf<T> : Wolf where T : IVulnerability
    {
        public T Vulnerability;

        public void CyberWolfDamage()
        {
            Vulnerability.Damage();
        }
    }
}
