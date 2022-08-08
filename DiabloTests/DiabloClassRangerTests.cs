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

    
    public class DiabloTClassRangerTests : TestsBase
    {
        /// <summary>
        /// Instead of [TestInitialize], creates instances of class ranger and a few Class.Weapon for re-use testing
        /// </summary>
        public DiabloTClassRangerTests() : base(WeaponType.WEAPON_BOW, ArmourType.ARMOUR_LEATHER)
        {
        }

        /// <summary>
        /// Tests should speak for themselves, Fact and Theory tests
        /// </summary>
        [Fact]
        public void Ranger_CreateNewRanger_ShouldNotBeNull()
        {
            // Arrange
            Ranger ranger = new Ranger();
            //Act
            // Assert
            Assert.NotNull(ranger);
        }
        [Fact]
        public void Name_NameRangerOnInit_ShouldBeNamedPaul()
        {
            // Arrange
            Ranger ranger = new Ranger("Paul");
            // Act
            string actual = ranger.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Level_LevelUpRanger_ShouldReturnLevelTwo()
        {
            // Arrange
            rangerTest.LevelUp();
            // Act
            int actual = rangerTest.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Attributes_GetBaseAttributesOnInit_ShouldReturnFiveTwoOne()
        {
            // Arrange
            // Act
            int[] actual = rangerTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 1,7,1 };
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_PickUpItem_ShouldContainItemName()
        {
            // Arrange
            rangerTest.PickUpItem(testWeapon);
            // Act
            // Assert
            Assert.Contains(testWeapon.ItemName, rangerTest.Stats);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => rangerTest.PickUpItem(levelFourAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => rangerTest.PickUpItem(daggerTest);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelArmour_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => rangerTest.PickUpItem(levelFourBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => rangerTest.PickUpItem(headInClothTest);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void CharacterDamage_GetWeapon_ReturnNewDamageWithWeapon()
        {
            // Arrange
            rangerTest.PickUpItem(testWeapon);
            double expected = 9.6;
            // Act
            double actual = rangerTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CharacterDamage_GetArmour_ReturnNewDamageWithArmour()
        {
            // Arrange
            rangerTest.PickUpItem(highDexHEADInPlate);
            double expected = 1 * (1 + (5 / 100));
            // Act
            double actual = rangerTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_ReturnOnlyNewWeapon()
        {
            // Arrange
            rangerTest.PickUpItem(testWeapon);
            rangerTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = rangerTest.Stats;
            // Assert
            Assert.Contains(testWeaponTwo.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_NotContainFirstWeapon()
        {
            // Arrange
            rangerTest.PickUpItem(testWeapon);
            rangerTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = rangerTest.Stats;
            // Assert
            Assert.DoesNotContain(testWeapon.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewArmour_NotContainFirstArmour()
        {
            // Arrange
            rangerTest.PickUpItem(testArmourBody);
            rangerTest.PickUpItem(testArmourBodyTwo);
            // Act
            string textData = rangerTest.Stats;
            // Assert
            Assert.DoesNotContain(testArmourBody.ItemName, textData);
        }
        [Fact]
        public void HeroAttribute_NewLevel_ShouldReturnHigherAttributes()
        {
            // Arrange
            rangerTest.LevelUp();
            // Act
            int[] actual = rangerTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 2,12,2 };
            // Assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void HeroTotalAttribute_GiveArmour_TotalAttributesChanged()
        {
            // Arrange
            int[] before = rangerTest.TotalPrimaryAttributes.GetAllAttributes();
            rangerTest.PickUpItem(testArmourBody);
            int[] after = rangerTest.TotalPrimaryAttributes.GetAllAttributes();
            // Act
            // Assert
            Assert.NotEqual(before, after);
        }
        [Fact]
        public void PickUpItem_PicksUpArmour_ReturnStringNewArmourEquipped()
        {
            // Arrange
            // Act
            string actual = rangerTest.PickUpItem(testArmourBody);
            string expected = "New armour equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_PicksUpWeapon_ReturnStringNewWeaponEquipped()
        {
            // Arrange
            // Act
            string actual = rangerTest.PickUpItem(testWeapon);
            string expected = "New weapon equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_AddWeapon_NewDamage()
        {
            // Arrange
            rangerTest.PickUpItem(testWeaponTwo);
            // Act
            double actual = rangerTest.Dps;
            double expected = (7 * 1.1) * (1 + (5 / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);
        }
        [Fact]
        public void Dps_NoWeaponOrArmourEquipped_ShouldReturnOne()
        {
            // Arrange
            // Act
            double actual = rangerTest.Dps;
            double expected = 1 * (1 + (5 / 100));
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_WeaponAnArmourEquipped_ShouldReturnNewDamage()
        {
            // Arrange
            // Act
            rangerTest.PickUpItem(testWeapon); // 12 dmg 0.8 atkspd
            rangerTest.PickUpItem(testArmourBody); // str = 1
            double actual = rangerTest.Dps;
            double expected = (12 * 0.8) * (1 + ((6 + 1) / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);

        }
        [Fact]
        public void CharacterWeaponTypes_CreatedOnInit_ReturnWeaponTypes()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEmpty(rangerTest.CharacterWeaponTypes);
        }

        [Fact]
        public void CharacterArmourTypes_CreatedOnInit_ReturnArmourTypes()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEmpty(rangerTest.CharacterArmourTypes);
        }





        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}