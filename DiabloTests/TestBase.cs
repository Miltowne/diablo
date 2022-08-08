using Diablo.HeroClasses;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTests
{
    public abstract class TestsBase : IDisposable
    {
        protected Warrior warriorTest;
        protected Weapon levelFiveAxe;
        protected Weapon testWeapon;
        protected Armour testArmourBody;
        protected Armour highStrengthHEADInPlate;
        protected Weapon levelOneAxe;
        protected Armour levelOneBody;
        protected Weapon levelFourAxe;
        protected Armour levelFourBody;
        protected Weapon daggerTest;
        protected Armour headInClothTest;
        protected Weapon testWeaponTwo;
        protected Armour testArmourBodyTwo;
        protected Armour testArmourHead;
        protected Weapon oneDamageWeapon;

        public TestsBase(WeaponType weaponType, ArmourType armourType)
        {
            warriorTest = new Warrior();
            testWeapon = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = weaponType,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };
            testWeaponTwo = new Weapon()
            {
                ItemName = "Common flail",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = weaponType,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            testArmourBody = new Armour()
            {
                ItemName = "Common plate body armor with style",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = armourType,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            testArmourBodyTwo = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = armourType,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            highStrengthHEADInPlate = new Armour()
            {
                ItemName = "Rare plate body armor of strength",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 40 }
            };
            headInClothTest = new Armour()
            {
                ItemName = "Rare plate body armor of strength",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_CLOTH,
                Attributes = new PrimaryAttributes() { Strength = 400 }
            };
            levelOneAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            levelFourAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 4,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = weaponType,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            daggerTest = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_DAGGER,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            levelOneBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            levelFourBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 4,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = armourType,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
        }
        public TestsBase()
        {
            testWeapon = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };
            testWeaponTwo = new Weapon()
            {
                ItemName = "Common flail",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_DAGGER,
                WeaponAttributes = new WeaponAttributes() { Damage = 11, AttackSpeed = 0.7 }
            };
            testArmourBody = new Armour()
            {
                ItemName = "Common plate body armor with style",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_CLOTH,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            testArmourHead = new Armour()
            {
                ItemName = "Common plate head armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
           
        }
        public void Dispose()
        {
        }
    }


}
