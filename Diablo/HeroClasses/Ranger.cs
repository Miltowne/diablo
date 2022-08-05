using Diablo.HeroClasses.SubClassesToHeroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses
{
    public class Ranger : Hero
    {
        public Ranger()
        {
            BasePrimaryAttributes = new PrimaryAttributes(2, 6, 1);
        }

        public Ranger(string _name) : base(_name) { }

        public override void LevelUp()
        {
            base.LevelUp();

        }
    }
}
