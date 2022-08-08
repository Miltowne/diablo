using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public struct WeaponAttributes
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }

        public double Dps => Math.Round(Damage * AttackSpeed, 2);
    }
}
