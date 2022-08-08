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
        /// <summary>
        /// Initialize class instances with base stats and Weapon / Armour type that the character can wield
        /// </summary>
        public Warrior()
        {
            BasePrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            TotalPrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_SWORD, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_AXE };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_MAIL, ArmourType.ARMOUR_PLATE };
        }
        /// <summary>
        /// Initialize class instances with base stats  and Weapon / Armour type that the character can wield
        /// Able to add Name to character
        /// </summary>
        /// <param name="_name"></param>
        public Warrior(string _name) : base(_name)
        {
            BasePrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            TotalPrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            CharacterWeaponTypes = new List<WeaponType>() { WeaponType.WEAPON_SWORD, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_AXE };
            CharacterArmourTypes = new List<ArmourType>() { ArmourType.ARMOUR_MAIL, ArmourType.ARMOUR_PLATE };
        }
        /// <summary>
        /// overrides Hero Class "LevelUp" but adds the new attributes to Base and Total Attributes
        /// </summary>
        public override void LevelUp()
        {
            BasePrimaryAttributes += new PrimaryAttributes(3, 2, 1);
            TotalPrimaryAttributes += new PrimaryAttributes(3, 2, 1);
            base.LevelUp();
        }
        /// <summary>
        /// overrides the Hero class "PickUpItem", can only pick up items 
        /// that are the right WeapopnTypes that the character can wield, and isn't higher Level than character
        /// </summary>
        /// <param name="item"></param>
        /// <returns>string with the information that the item is equipped</returns>
        /// <exception cref="InvalidWeaponException"></exception>
        /// <exception cref="InvalidArmourException"></exception>
        /// <exception cref="InvalidItemException"></exception>
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
                else  throw new InvalidWeaponException();
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
