using Diablo.Helpers;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
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
            BasePrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            TotalPrimaryAttributes = new PrimaryAttributes(5, 2, 1);

        }
        public Warrior(string _name) : base(_name) { }


        public override void LevelUp()
        {
            base.LevelUp();

        }

        public override void PickUpWeapon(Weapon weapon)
        {
            if (weapon.WeaponType == WeaponType.WEAPON_AXE || weapon.WeaponType == WeaponType.WEAPON_HAMMER || weapon.WeaponType == WeaponType.WEAPON_SWORD)
            {
                if (weapon.ItemLevel <= Level)
                {
                    base.PickUpWeapon(weapon);

                }
            }
            else
            {

                throw new InvalidWeaponException();
            }
        }
        public override void PickUpArmour(Armour armour)
        {
            if (armour.ArmourType == ArmourType.ARMOUR_MAIL || armour.ArmourType == ArmourType.ARMOUR_PLATE)
            {
                if (armour.ItemLevel <= Level)
                {
                    base.PickUpArmour(armour);
                }
            }
            else
            {
                throw new InvalidArmourException();

            }
        }
    }
}
