using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.HeroClasses
{
    public abstract class Hero
    {
        public string Name {

            get { return Name; }

            set { Name = value; }
        }

        public Hero(string _name)
        {
            Name = _name;
        }
    }
}
