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

    
    public class DiabloTClassMageTests : TestsBase
    {
        //these are used on several tests
        /// <summary>
        /// Instead of [TestInitialize], creates instances of class Mage and a few Class.Weapon for re-use testing
        /// </summary>
        public DiabloTClassMageTests() : base(WeaponType.WEAPON_STAFF, ArmourType.ARMOUR_CLOTH)
        {
            // Do "global" initialization here; Called before every test method.
        }

        /// <summary>
        /// Tests should speak for themselves, Fact and Theory tests
        /// </summary>
        [Fact]
        public void Mage_CreateNewMage_ShouldNotBeNull()
        {
            // Arrange
            Mage Mage = new Mage();
            //Act
            // Assert
            Assert.NotNull(Mage);
        }
        [Fact]
        public void Name_NameMageOnInit_ShouldBeNamedPaul()
        {
            // Arrange
            Mage Mage = new Mage("Paul");
            // Act
            string actual = Mage.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Level_LevelUpMage_ShouldReturnLevelTwo()
        {
            // Arrange
            mageTest.LevelUp();
            // Act
            int actual = mageTest.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Attributes_GetBaseAttributesOnInit_ShouldReturnFiveTwoOne()
        {
            // Arrange
            // Act
            int[] actual = mageTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 5, 2, 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void PickUpItem_PickUpItem_ShouldContainItemName()
        {
            // Arrange
            mageTest.PickUpItem(levelOneAxe);
            // Act
            // Assert
            Assert.Contains(levelOneAxe.ItemName, mageTest.Stats);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => mageTest.PickUpItem(levelFourAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => mageTest.PickUpItem(daggerTest);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelArmour_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => mageTest.PickUpItem(levelFourBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => mageTest.PickUpItem(headInClothTest);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void CharacterDamage_GetWeapon_ReturnNewDamageWithWeapon()
        {
            // Arrange
            mageTest.PickUpItem(levelOneAxe);
            double expected = 7.7;
            // Act
            double actual = mageTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CharacterDamage_GetArmour_ReturnNewDamageWithArmour()
        {
            // Arrange
            mageTest.PickUpItem(highStrengthHEADInPlate);
            double expected = 1 * (1 + (5 / 100));
            // Act
            double actual = mageTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_ReturnOnlyNewWeapon()
        {
            // Arrange
            mageTest.PickUpItem(testWeapon);
            mageTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = mageTest.Stats;
            // Assert
            Assert.Contains(testWeaponTwo.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_NotContainFirstWeapon()
        {
            // Arrange
            mageTest.PickUpItem(testWeapon);
            mageTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = mageTest.Stats;
            // Assert
            Assert.DoesNotContain(testWeapon.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewArmour_NotContainFirstArmour()
        {
            // Arrange
            mageTest.PickUpItem(testArmourBody);
            mageTest.PickUpItem(testArmourBodyTwo);
            // Act
            string textData = mageTest.Stats;
            // Assert
            Assert.DoesNotContain(testArmourBody.ItemName, textData);
        }
        [Fact]
        public void HeroAttribute_NewLevel_ShouldReturnHigherAttributes()
        {
            // Arrange
            mageTest.LevelUp();
            // Act
            int[] actual = mageTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 5 + 3, 2 + 2, 1 + 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void HeroTotalAttribute_GiveArmour_TotalAttributesChanged()
        {
            // Arrange
            int[] before = mageTest.TotalPrimaryAttributes.GetAllAttributes();
            mageTest.PickUpItem(testArmourBody);
            int[] after = mageTest.TotalPrimaryAttributes.GetAllAttributes();
            // Act
            // Assert
            Assert.NotEqual(before, after);
        }
        [Fact]
        public void PickUpItem_PicksUpArmour_ReturnStringNewArmourEquipped()
        {
            // Arrange
            // Act
            string actual = mageTest.PickUpItem(testArmourBody);
            string expected = "New armour equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_PicksUpWeapon_ReturnStringNewWeaponEquipped()
        {
            // Arrange
            // Act
            string actual = mageTest.PickUpItem(testWeapon);
            string expected = "New weapon equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_AddWeapon_NewDamage()
        {
            // Arrange
            mageTest.PickUpItem(testWeaponTwo);
            // Act
            double actual = mageTest.Dps;
            double expected = (7 * 1.1) * (1 + (5 / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);
        }
        [Fact]
        public void Dps_NoWeaponOrArmourEquipped_ShouldReturnOne()
        {
            // Arrange
            // Act
            double actual = mageTest.Dps;
            double expected = 1 * (1 + (5 / 100));
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_WeaponAnArmourEquipped_ShouldReturnNewDamage()
        {
            // Arrange
            // Act
            mageTest.PickUpItem(testWeapon); // 12 dmg 0.8 atkspd
            mageTest.PickUpItem(testArmourBody); // str = 1
            double actual = mageTest.Dps;
            double expected = (12 * 0.8) * (1 + ((6 + 1) / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);

        }





        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}