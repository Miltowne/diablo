using Diablo.Helpers;
using Diablo.HeroClasses;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace DiabloTests
{

    
    public class DiabloTClassTests : TestsBase
    {
        //these are used on several tests
        //private Warrior warriorTest;
        private Weapon levelFiveAxe = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 5,
            ItemSlot = ItemSlot.SLOT_WEAPON,
            WeaponType = WeaponType.WEAPON_AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };
        private Weapon testBow = new Weapon()
        {
            ItemName = "Common bow",
            ItemLevel = 1,
            ItemSlot = ItemSlot.SLOT_WEAPON,
            WeaponType = WeaponType.WEAPON_BOW,
            WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
        };
        private Armour testPlateBody = new Armour()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 5,
            ItemSlot = ItemSlot.SLOT_BODY,
            ArmourType = ArmourType.ARMOUR_PLATE,
            Attributes = new PrimaryAttributes() { Strength = 1 }
        };
        private Armour highStrengthHEAD = new Armour()
        {
            ItemName = "Rare plate body armor of strength",
            ItemLevel = 1,
            ItemSlot = ItemSlot.SLOT_HEAD,
            ArmourType = ArmourType.ARMOUR_PLATE,
            Attributes = new PrimaryAttributes() { Strength = 400 }
        };
        private Weapon levelOneAxe = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 1,
            ItemSlot = ItemSlot.SLOT_WEAPON,
            WeaponType = WeaponType.WEAPON_AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };
        private Armour levelOneBody = new Armour()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = ItemSlot.SLOT_BODY,
            ArmourType = ArmourType.ARMOUR_PLATE,
            Attributes = new PrimaryAttributes() { Strength = 1 }
        };
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            // never gets called... dunno why
        }

        protected DiabloTClassTests() : base()
        {
            // Do "global" initialization here; Called before every test method.
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
            //warriorTest.
            // Assert
            Assert.True(warriorTest.GetInventory().ContainsKey(levelOneAxe.ItemSlot));
        }
        [Fact]
        public void Pick_Up_Weapon_And_Exist_In_Inventory()
        {
            // Arrange
            Warrior warrior = new Warrior();
            warriorTest.PickUpItem(levelOneAxe);
            // Act
            // Assert
            //Assert.True(warriorTest.GetCharacterInfo().ToString().Contains(levelOneAxe.ItemName));
            Assert.Contains(levelOneAxe.ItemName!.ToString(), warriorTest.GetCharacterInfo().ToString());

        }
        [Fact]
        public void Should_Throw_Exception_InvalidWeaponException()
        {
            // Arrange
            warriorTest = new Warrior();
            Weapon levelFourAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 4,
                ItemSlot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            // Act
            Action act = () => warriorTest.PickUpItem(levelFourAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);

        }
        [Fact]
        public void Should_Throw_Exception_InvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => warriorTest.PickUpItem(testPlateBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void CharacterDamage_GetWeapon_ReturnNewDamageWithWeapon()
        {
            // Arrange
            warriorTest.PickUpItem(levelOneAxe);
            double expected = 8.09;
            // Act
            double actual = warriorTest.CharacterDamage();
            // Assert
            Assert.Equal(expected, actual);
        }
        //[Fact]
        //public void CharacterDamage_GetWeapon_ReturnNewDamageWithArmour()
        //{
        //    // Arrange
        //    Warrior warrior = new Warrior();
        //    warrior.PickUpItem(highStrengthHEAD);


        //    double expected = 4;
        //    // Act
        //    double actual = warrior.CharacterDamage();
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}
        //[Fact]
        //public void PickUpItem_UpdateWithNewWeapon_ReturnOnlyNewWeapon()
        //{
        //    // Arrange
        //    Warrior warrior = new Warrior();
        //    Weapon levelOneAxe = new Weapon()
        //    {
        //        ItemName = "Common axe",
        //        ItemLevel = 1,
        //        ItemSlot = ItemSlot.SLOT_WEAPON,
        //        WeaponType = WeaponType.WEAPON_AXE,
        //        WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        //    }; 
        //    Weapon levelOneAxe2 = new Weapon()
        //    {
        //        ItemName = "Common axe",
        //        ItemLevel = 1,
        //        ItemSlot = ItemSlot.SLOT_WEAPON,
        //        WeaponType = WeaponType.WEAPON_AXE,
        //        WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        //    };
        //    warrior.PickUpItem(levelOneAxe);
        //    warrior.PickUpItem(levelOneAxe2);
        //    // Act
        //    var textData = warrior.GetCharacterInfo().ToString();
        //    // Assert
        //    Assert.Contains(textData, levelOneAxe2.ItemName);
        //}
        [Fact]
        public void HeroAttribute_NewLevel_ShouldReturnHigherAttributes()
        {
            // Arrange
            // Act
            // Assert
        }
        [Theory]
        public void a()
        {
            Warrior warrior = new Warrior();
            Assert.True(true);
            Assert.StrictEqual(1, 1);
        }




        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}