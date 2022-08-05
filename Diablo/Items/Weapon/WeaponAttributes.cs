using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public struct WeaponAttribute
    {
        public int Damage { private get; set; }
        public double AttackSpeed { private get; set; }

        public int Dps
        {
            get { return Convert.ToInt32(Convert.ToDouble(Damage) * AttackSpeed); }
        }

    }
}
