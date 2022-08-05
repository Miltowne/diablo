using Diablo.HeroClasses.SubClassesToHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses
{
    public abstract class Hero
    {

        public string Name { get; set; }




        public int Level { get; set; }


        protected Attributes attributes = new Attributes(1, 1, 1);

        public Hero()
        {
            Level = 1;
        }

        public Hero(string _name)
        {
            Name = _name;
            Level = 1;
        }

        public virtual void LevelUp()
        {
            this.Level++;
        }

        public int[] getAttributes()
        {
            return new int[] { attributes.Strength, attributes.Dexterity, attributes.Intelligence };
        }

    }
}
