using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public struct WeaponAttributes
    {
        /// <summary>
        /// Dps - Damage Per Second, is the combined damage and attackspeed of the weapon
        /// </summary>
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }

        public double Dps => Math.Round(Damage * AttackSpeed, 1);
    }
}
