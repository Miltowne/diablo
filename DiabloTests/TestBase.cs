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
        protected Weapon testBow;
        protected Armour testPlateBody;
        protected Armour highStrengthHEAD;
        protected Weapon levelOneAxe;
        protected Armour levelOneBody;

        protected TestsBase()
        {
            warriorTest = new Warrior();
            testBow = new Weapon()
             {
                 ItemName = "Common bow",
                 ItemLevel = 1,
                 ItemSlot = ItemSlot.SLOT_WEAPON,
                 WeaponType = WeaponType.WEAPON_BOW,
                 WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
             };
            testPlateBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 5,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            highStrengthHEAD = new Armour()
            {
                ItemName = "Rare plate body armor of strength",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_PLATE,
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
            levelOneBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
        }
        public void Dispose()
        {
        }
        // Do "global" initialization here; Called before every test method.
    }


}
