using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public class Weapon : Item, IEquipable
    {
        /// <summary>
        /// Weapon is created with weapon attributes
        /// the attributes are Damage, AttackSpeed and Dps
        /// </summary>
        public WeaponAttributes WeaponAttributes { get; set; }

        /// <summary>
        /// The weapon type of the weapon of type enum
        /// </summary>
        public WeaponType WeaponType { get; set; }



    }
}
