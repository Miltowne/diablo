using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public class Weapon : Item, IEquipable
    {
        public WeaponAttributes WeaponAttributes { get; set; }

        public WeaponType WeaponType { get; set; }



    }
}
