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
    public class DiabloTClassTests
    {
        //these are used on several tests
        private Warrior warriorTest;
        private Rogue rogueTest;
        private Mage mageTest;
        private Ranger rangerTest;
        private Weapon weaponTest;
        private Weapon levelFiveAxe;
        private Weapon testBow;
        private Armour testPlateBody;
        private Weapon levelOneAxe;
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            warriorTest = new Warrior();
            rogueTest = new Rogue();
            mageTest = new Mage();
            rangerTest = new Ranger();
            weaponTest = new Weapon();


            levelFiveAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 5,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            levelOneAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 5,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
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
                ItemLevel = 1,
                ItemSlot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
        }
        [Fact]
        public void Create_New_Warrior()
        {
            // Arrange
            Warrior warrior = new Warrior();
            //Act
            // Assert
            Assert.NotNull(warrior);
        }

        [Fact]
        public void Name_New_Warrior_On_Init()
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
            Ranger ranger = new Ranger();


            // Act
            warrior.LevelUp();
            int actual = warrior.Level;
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
            double[] actual = warrior.BasePrimaryAttributes.GetAllAttributes();
            double[] expected = new double[] { 5, 2, 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Pick_Up_Weapon_Warrior()
        {
            // Arrange
            // Act
            warriorTest.PickUpItem(levelOneAxe);
            warriorTest.
            // Assert
            //Assert.
        }
        //[Fact]
        //public void Throw_Exception_InvalidWeaponException()
        //{
        //    // Arrange
        //    // Act
        //    Action act = () => warriorTest.PickUpItem(levelFiveAxe);
        //    // Assert
        //    Assert.Throws<InvalidWeaponException>(act);
        //}
        //[Fact]
        //public void Throw_Exception_InvalidArmourExceprion()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    Assert.Throws<InvalidArmourException>(() => warriorTest.PickUpItem(levelFivePlate));
        //}

    }
}