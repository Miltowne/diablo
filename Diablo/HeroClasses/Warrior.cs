using Diablo.HeroClasses.SubClassesToHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses
{
    public class Warrior : Hero
    {


        public Warrior() 
        {
            attributes = new Attributes(5,2,1);
        }
        public Warrior(string _name) : base(_name) { }


        public override void LevelUp()
        {
            base.LevelUp();

        }
    }
}
