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
        /// <summary>
        /// Instead of [TestInitialize], creates instances of class warrior and a few Class.Weapon for re-use testing
        /// </summary>
        public DiabloTClassTests() : base(WeaponType.WEAPON_AXE, ArmourType.ARMOUR_PLATE)
        {
            // Do "global" initialization here; Called before every test method.
        }

        /// <summary>
        /// Tests should speak for themselves, Fact and Theory tests
        /// </summary>
        [Fact]
        public void Warrior_CreateNewWarrior_ShouldNotBeNull()
        {
            // Arrange
            Warrior warrior = new Warrior();
            //Act
            // Assert
            Assert.NotNull(warrior);
        }
        [Fact]
        public void Name_NameWarriorOnInit_ShouldBeNamedPaul()
        {
            // Arrange
            Warrior warrior = new Warrior("Paul");
            // Act
            string actual = warrior.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Level_LevelUpWarrior_ShouldReturnLevelTwo()
        {
            // Arrange
            warriorTest.LevelUp();
            // Act
            int actual = warriorTest.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Attributes_GetBaseAttributesOnInit_ShouldReturnFiveTwoOne()
        {
            // Arrange
            // Act
            double[] actual = warriorTest.BasePrimaryAttributes.GetAllAttributes();
            double[] expected = new double[] { 5, 2, 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void PickUpItem_PickUpItem_ShouldContainItemName()
        {
            // Arrange
            warriorTest.PickUpItem(levelOneAxe);
            // Act
            // Assert
            Assert.Contains(levelOneAxe.ItemName,warriorTest.Stats);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => warriorTest.PickUpItem(levelFourAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => warriorTest.PickUpItem(daggerTest);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelArmour_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => warriorTest.PickUpItem(levelFourBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => warriorTest.PickUpItem(headInClothTest);
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
        [Fact]
        public void CharacterDamage_GetArmour_ReturnNewDamageWithArmour()
        {
            // Arrange
            warriorTest.PickUpItem(highStrengthHEADInPlate);
            double expected = 1.05;
            // Act
            double actual = warriorTest.CharacterDamage();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_ReturnOnlyNewWeapon()
        {
            // Arrange
            warriorTest.PickUpItem(testWeapon);
            warriorTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = warriorTest.Stats;
            // Assert
            Assert.Contains(testWeaponTwo.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_NotContainFirstWeapon()
        {
            // Arrange
            warriorTest.PickUpItem(testWeapon);
            warriorTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = warriorTest.Stats;
            // Assert
            Assert.DoesNotContain(testWeapon.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewArmour_NotContainFirstArmour()
        {
            // Arrange
            warriorTest.PickUpItem(testArmourBody);
            warriorTest.PickUpItem(testArmourBodyTwo);
            // Act
            string textData = warriorTest.Stats;
            // Assert
            Assert.DoesNotContain(testArmourBody.ItemName, textData);
        }
        [Fact]
        public void HeroAttribute_NewLevel_ShouldReturnHigherAttributes()
        {
            // Arrange
            warriorTest.LevelUp();
            // Act
            double[] actual = warriorTest.BasePrimaryAttributes.GetAllAttributes();
            double[] expected = new double[] { 5 + 3, 2 + 2, 1 + 1 };
            // Assert
            Assert.Equal(actual, expected);
        }

        //public void 

        //[Theory]
        //[MemberData(warriorTest.Stats)]
        //[InlineData(warriorTest.TotalPrimaryAttributes, new double[] { 1, 2, 3 })]
        //[InlineData(Mage mage = new Mage();)]
        //public void WarriorBaseAttribute_Create(Hero hero, double[] attr)
        //{
        //    // Arrange
        //    Warrior warrior = new Warrior();
        //    // Act
        //    // Assert
        //    Assert.Equal(warrior.TotalPrimaryAttributes.Strength, 5);
        //}





        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}