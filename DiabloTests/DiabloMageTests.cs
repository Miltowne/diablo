using Diablo.Helpers;
using Diablo.HeroClasses;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace DiabloTests
{
    public class DiabloTMageTests
    {
        //these are used on several tests
        private Warrior warriorTest;
        private Rogue rogueTest;
        private Mage mageTest;
        private Ranger rangerTest;
        private Weapon weaponTest;
        private Weapon levelFiveAxe;
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            warriorTest = new Warrior();
            rogueTest = new Rogue();
            mageTest = new Mage();
            rangerTest = new Ranger();
            weaponTest = new Weapon();


            Weapon levelFiveAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 5,
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
        public void Create_New_Mage()
        {
            // Arrange
            Mage mage = new Mage(); // Cannot initialize yet
            // Act
            // Assert
            Assert.NotNull(mage);
        }
        [Fact]
        public void Name_Warrior_New_On_Init()
        {
            // Arrange
            Warrior warrior1 = new Warrior("Paul");
            // Act
            string actual = warrior1.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Level_Up_New_Warrior()
        {
            // Arrange
            Warrior warrior = new Warrior();
            // Act
            //warrior.StringBuilder() // Character name: "jens" 
            warrior.LevelUp();
            int actual = warrior.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Level_Up_New_Rogue()
        {
            // Arrange
            Rogue rogue = new Rogue();
            int before = rogue.Level;
            // Act
            rogue.LevelUp();
            int after = rogue.Level;
            // Assert
            Assert.NotEqual(before, after);
        }
        [Fact]
        public void Level_Up_New_Mage()
        {
            // Arrange
            Mage mage = new Mage();
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };


            // Act
            mage.LevelUp();
            int actual = mage.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Level_Up_New_Ranger()
        {
            // Arrange
            Ranger ranger = new Ranger();


            // Act
            ranger.LevelUp();
            int actual = ranger.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Get_Attributes_From_Warrior()
        {
            // Arrange
            Warrior warrior = new Warrior();
            // Act
            int[] actual = warrior.getAttributes();
            int[] expected = new int[] { 5, 2, 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Get_Attributes_From_Mage()
        {
            // Arrange
            // Act
            int[] actual = mageTest.getAttributes();
            int[] expected = new int[] { 2, 6, 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Throw_Exception_InvalidWeaponException()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<InvalidWeaponException>(() =>warriorTest.PickUpWeapon(levelFiveAxe));
        }

    }
}