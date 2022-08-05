using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items.Weapon
{
    public class Weapon : Item
    {
        public WeaponAttribute WeaponAttributes { get; set; }

        public WeaponType WeaponType { get; set; }
        //public Weapon(
        //    string ItemName,
        //    int ItemLevel,
        //    Slot ItemSlot,
        //    WeaponType WeaponType,
        //    WeaponAttribute WeaponAttribute
        //    ) : base(ItemName, ItemLevel, ItemSlot)
        //{
        //    WeaponAttributes = WeaponAttribute;
        //    WeaponType = WeaponType;

        //}
    }
}
