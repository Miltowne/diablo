using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses.SubClassesToHeroes
{
    public struct PrimaryAttributes
    {
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }

        public double[] GetAllAttributes()
        {
            return new double[] { Strength, Dexterity, Intelligence};
        }

        public PrimaryAttributes(double _strength, double _dexterity, double _intelligence)
        {
            Strength = _strength;
            Dexterity = _dexterity;
            Intelligence = _intelligence;
        }

        public static PrimaryAttributes operator +(PrimaryAttributes oldValue, PrimaryAttributes newValue)
        {
            return new PrimaryAttributes(oldValue.Strength + newValue.Strength, oldValue.Dexterity + newValue.Dexterity, oldValue.Intelligence + newValue.Intelligence);
        }

    }
}
