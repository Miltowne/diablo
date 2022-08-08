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

    
    public class DiabloTClassRogueTests : TestsBase
    {
        /// <summary>
        /// Instead of [TestInitialize], creates instances of class rogue and a few Class.Weapon for re-use testing
        /// </summary>
        public DiabloTClassRogueTests() : base(WeaponType.WEAPON_DAGGER, ArmourType.ARMOUR_LEATHER)
        {
        }

        /// <summary>
        /// Tests should speak for themselves, Fact and Theory tests
        /// </summary>
        [Fact]
        public void Rogue_CreateNewRogue_ShouldNotBeNull()
        {
            // Arrange
            Rogue rogue = new Rogue();
            //Act
            // Assert
            Assert.NotNull(rogue);
        }
        [Fact]
        public void Name_NameRogueOnInit_ShouldBeNamedPaul()
        {
            // Arrange
            Rogue rogue = new Rogue("Paul");
            // Act
            string actual = rogue.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Level_LevelUpRogue_ShouldReturnLevelTwo()
        {
            // Arrange
            rogueTest.LevelUp();
            // Act
            int actual = rogueTest.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Attributes_GetBaseAttributesOnInit_ShouldReturnFiveTwoOne()
        {
            // Arrange
            // Act
            int[] actual = rogueTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 2,6,1 };
            // Assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void PickUpItem_PickUpItem_ShouldContainItemName()
        {
            // Arrange
            rogueTest.PickUpItem(testWeapon);
            // Act
            // Assert
            Assert.Contains(testWeapon.ItemName,rogueTest.Stats);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelWeapon_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => rogueTest.PickUpItem(levelFourAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            // Act
            Action act = () => rogueTest.PickUpItem(levelOneAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void PickUpItem_PickToHighLevelArmour_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => rogueTest.PickUpItem(levelFourBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void PickUpItem_PickToWrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            // Act
            Action act = () => rogueTest.PickUpItem(headInClothTest);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void CharacterDamage_GetWeapon_ReturnNewDamageWithWeapon()
        {
            // Arrange
            rogueTest.PickUpItem(daggerTest);
            double expected = 7.7;
            // Act
            double actual = rogueTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CharacterDamage_GetArmour_ReturnNewDamageWithArmour()
        {
            // Arrange
            rogueTest.PickUpItem(highDexHEADInPlate);
            double expected = 1 * (1 + (5 / 100));
            // Act
            double actual = rogueTest.Dps;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_ReturnOnlyNewWeapon()
        {
            // Arrange
            rogueTest.PickUpItem(testWeapon);
            rogueTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = rogueTest.Stats;
            // Assert
            Assert.Contains(testWeaponTwo.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewWeapon_NotContainFirstWeapon()
        {
            // Arrange
            rogueTest.PickUpItem(testWeapon);
            rogueTest.PickUpItem(testWeaponTwo);
            // Act
            string textData = rogueTest.Stats;
            // Assert
            Assert.DoesNotContain(testWeapon.ItemName, textData);
        }
        [Fact]
        public void PickUpItem_UpdateWithNewArmour_NotContainFirstArmour()
        {
            // Arrange
            rogueTest.PickUpItem(testArmourBody);
            rogueTest.PickUpItem(testArmourBodyTwo);
            // Act
            string textData = rogueTest.Stats;
            // Assert
            Assert.DoesNotContain(testArmourBody.ItemName, textData);
        }
        [Fact]
        public void HeroAttribute_NewLevel_ShouldReturnHigherAttributes()
        {
            // Arrange
            rogueTest.LevelUp();
            // Act
            int[] actual = rogueTest.BasePrimaryAttributes.GetAllAttributes();
            int[] expected = new int[] { 3,10,2 };
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void HeroTotalAttribute_GiveArmour_TotalAttributesChanged()
        {
            // Arrange
            int[] before = rogueTest.TotalPrimaryAttributes.GetAllAttributes();
            rogueTest.PickUpItem(testArmourBody);
            int[] after = rogueTest.TotalPrimaryAttributes.GetAllAttributes();
            // Act
            // Assert
            Assert.NotEqual(before, after);
        }
        [Fact]
        public void PickUpItem_PicksUpArmour_ReturnStringNewArmourEquipped()
        {
            // Arrange
            // Act
            string actual = rogueTest.PickUpItem(testArmourBody);
            string expected = "New armour equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PickUpItem_PicksUpWeapon_ReturnStringNewWeaponEquipped()
        {
            // Arrange
            // Act
            string actual = rogueTest.PickUpItem(testWeapon);
            string expected = "New weapon equipped!";
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_AddWeapon_NewDamage()
        {
            // Arrange
            rogueTest.PickUpItem(testWeaponTwo);
            // Act
            double actual = rogueTest.Dps;
            double expected = (7 * 1.1) * (1 + (5 / 100));
            // Assert
            Assert.Equal(Math.Round(expected, 2), actual);
        }
        [Fact]
        public void Dps_NoWeaponOrArmourEquipped_ShouldReturnOne()
        {
            // Arrange
            // Act
            double actual = rogueTest.Dps;
            double expected = 1 * (1 + (5 / 100));
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Dps_WeaponAnArmourEquipped_ShouldReturnNewDamage()
        {
            // Arrange
            // Act
            rogueTest.PickUpItem(testWeapon); // 12 dmg 0.8 atkspd
            rogueTest.PickUpItem(testArmourBody); // str = 1
            double actual = rogueTest.Dps;
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
            Assert.NotEmpty(rogueTest.CharacterWeaponTypes);
        }

        [Fact]
        public void CharacterArmourTypes_CreatedOnInit_ReturnArmourTypes()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEmpty(rogueTest.CharacterArmourTypes);
        }



        //MethodYouAreTesting_ConditionsItsBeingTestedUnder_ExpectedBehaviour().
    }
}