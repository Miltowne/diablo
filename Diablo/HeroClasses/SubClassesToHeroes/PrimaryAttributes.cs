using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses.SubClassesToHeroes
{
    public struct PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public int[] GetAllAttributes()
        {
            return new int[] { Strength, Dexterity, Intelligence};
        }

        public PrimaryAttributes(int _strength, int _dexterity, int _intelligence)
        {
            Strength = _strength;
            Dexterity = _dexterity;
            Intelligence = _intelligence;
        }

        public static PrimaryAttributes operator +(PrimaryAttributes oldValue, PrimaryAttributes newValue)
        {
            return new PrimaryAttributes(oldValue.Strength + newValue.Strength, oldValue.Dexterity + newValue.Dexterity, oldValue.Intelligence + newValue.Intelligence);
        }
        public static PrimaryAttributes operator -(PrimaryAttributes oldValue, PrimaryAttributes newValue)
        {
            return new PrimaryAttributes(oldValue.Strength - newValue.Strength, oldValue.Dexterity - newValue.Dexterity, oldValue.Intelligence - newValue.Intelligence);
        }

    }
}
