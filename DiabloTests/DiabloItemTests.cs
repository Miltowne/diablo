using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace DiabloTests
{
    public class DiabloItemTests
    {
        //these are used on several tests
        private Weapon weaponTest;
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            Weapon testBow = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_BOW,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };


        }

        [Fact]
        public void Create_New_Weapon()
        {
            // Arrange
            Weapon weapon = new Weapon();
            //Act

            // Assert
            Assert.NotNull(weapon);
        }
        [Fact]
        public void Get_Damage_From_Weapon()
        {
            // Arrange
            Weapon weapon = new Weapon();
            //Act
            var actual = weapon.WeaponAttributes.Dps;
            // Assert
            Assert.NotNull(weapon);
        }
    }
}
