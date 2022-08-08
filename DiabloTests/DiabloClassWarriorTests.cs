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
    public class DiabloTClassWarriorTests : TestsBase
    {
        /// <summary>
        /// Instead of [TestInitialize], creates instances of class warrior and a few Class.Weapon for re-use testing
        /// </summary>
        public DiabloTClassWarriorTests() : base(WeaponType.WEAPON_AXE, ArmourType.ARMOUR_PLATE)
        {
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
            int[] actual = warriorTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 5, 2, 1 };
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
            double expected = 7.7;
            // Act
            double actual = warriorTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CharacterDamage_GetArmour_ReturnNewDamageWithArmour()
        {
            // Arrange
            warriorTest.PickUpItem(highStrengthHEADInPlate);
            double expected = 1 * (1 + (5 / 100));
            // Act
            double actual = warriorTest.Dps;
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
            int[] actual = warriorTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 5 + 3, 2 + 2, 1 + 1 };
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void HeroTotalAttribute_GiveArmour_TotalAttributesChanged()
        {
            // Arrange
            int[] before = warriorTest.TotalPrimaryAttributes.GetAllAttributes();
            warriorTest.PickUpItem(testArmourBody);
            int[] after = warriorTest.TotalPrimaryAttributes.GetAllAttributes();
            // Act
            // Assert
            Assert.NotEqual(before, after);
        }
        [Fact]
        public void PickUpItem_PicksUpArmour_ReturnStringNewArmourEquipped()
        {
            // Arrange
            // Act
            string actual = warriorTest.PickUpItem(testArmourBody);
            string expected = "New armour equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_PicksUpWeapon_ReturnStringNewWeaponEquipped()
        {
            // Arrange
            // Act
            string actual = warriorTest.PickUpItem(testWeapon);
            string expected = "New weapon equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_AddWeapon_NewDamage()
        {
            // Arrange
            warriorTest.PickUpItem(testWeaponTwo);
            // Act
            double actual = warriorTest.Dps;
            double expected = (7 * 1.1) * (1 + (5 / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);
        }
        [Fact]
        public void Dps_NoWeaponOrArmourEquipped_ShouldReturnOne()
        {
            // Arrange
            // Act
            double actual = warriorTest.Dps;
            double expected = 1 * (1 + (5 / 100));
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_WeaponAnArmourEquipped_ShouldReturnNewDamage()
        {
            // Arrange
            // Act
            warriorTest.PickUpItem(testWeapon); // 12 dmg 0.8 atkspd
            warriorTest.PickUpItem(testArmourBody); // str = 1
            double actual = warriorTest.Dps;
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
            Assert.NotEmpty(warriorTest.CharacterWeaponTypes);
        }

        [Fact]
        public void CharacterArmourTypes_CreatedOnInit_ReturnArmourTypes()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEmpty(warriorTest.CharacterArmourTypes);
        }



        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}