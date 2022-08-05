using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses.SubClassesToHeroes
{
    public struct Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }


        public Attributes(int _strength, int _dexterity, int _intelligence)
        {
            Strength = _strength;
            Dexterity = _dexterity;
            Intelligence = _intelligence;
        }

        public static Attributes operator +(Attributes oldValue, Attributes newValue)
        {
            return new Attributes(oldValue.Strength + newValue.Strength, oldValue.Dexterity + newValue.Dexterity, oldValue.Intelligence + newValue.Intelligence);
        }

    }
}
