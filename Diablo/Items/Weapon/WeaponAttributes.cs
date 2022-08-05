using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public struct WeaponAttributes
    {
        public double Damage { private get; set; }
        public double AttackSpeed { private get; set; }

        public double Dps
        {
            get { return Math.Round(Damage * AttackSpeed, 2); }
        }

    }
}
