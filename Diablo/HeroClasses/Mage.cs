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
    public class Mage : Hero
    {
        public Mage()
        {
            BasePrimaryAttributes = new PrimaryAttributes(1,1,8);
            TotalPrimaryAttributes = new PrimaryAttributes(1,1,8);
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_CLOTH };
        }
        public Mage(string _name) : base(_name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(1,1,8);
            TotalPrimaryAttributes = new PrimaryAttributes(1,1,8);
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_CLOTH };
        }
        public override void LevelUp()
        {
            BasePrimaryAttributes += new PrimaryAttributes(1,1,5);
            TotalPrimaryAttributes += new PrimaryAttributes(1,1,5);
            base.LevelUp();
        }
        public override string PickUpItem(IEquipable item)
        {
            Type type = item.GetType();
            if (type.Name == typeof(Weapon).Name)
            {
                if (CharacterWeaponTypes.Contains((item as Weapon)!.WeaponType) && (item as Weapon)!.ItemLevel <= Level)
                {
                    base.PickUpItem(item);
                    return "New weapon equipped!";
                }
                else throw new InvalidWeaponException();
            }
            else if (type.Name == typeof(Armour).Name)
            {
                if (CharacterArmourTypes.Contains((item as Armour)!.ArmourType) && (item as Armour)!.ItemLevel <= Level)
                {
                    base.PickUpItem(item);
                    return "New armour equipped!";
                }
                else throw new InvalidArmourException();
            }
            else throw new InvalidItemException();
        }

    }
}
