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
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_SWORD, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_AXE };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_MAIL, ArmourType.ARMOUR_PLATE };
        }
        public Warrior(string _name) : base(_name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            TotalPrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_SWORD, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_AXE };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_MAIL, ArmourType.ARMOUR_PLATE };
        }
        public override void LevelUp()
        {
            BasePrimaryAttributes += new PrimaryAttributes(3, 2, 1);
            TotalPrimaryAttributes += new PrimaryAttributes(3, 2, 1);
            base.LevelUp();
        }
        public override void PickUpItem(IEquipable item)
        {
            Type type = item.GetType();
            if (type.Name == typeof(Weapon).Name)
            {
                if (CharacterWeaponTypes.Contains((item as Weapon)!.WeaponType) && (item as Weapon)!.ItemLevel <= Level)
                {
                    base.PickUpItem(item);
                }
                else  throw new InvalidWeaponException();
            }
            else if (type.Name == typeof(Armour).Name)
            {
                if (CharacterArmourTypes.Contains((item as Armour)!.ArmourType) && (item as Armour)!.ItemLevel <= Level) base.PickUpItem(item);
                else throw new InvalidArmourException();
            }
            else throw new InvalidItemException();
        }
    }
}
