using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace DiabloTests
{
    public class DiabloItemTests : TestsBase
    {

        public DiabloItemTests()
        {

        }
        [Fact]
        public void Weapon_CreateNewWeapon_NotNull()
        {
            // Arrange
            Weapon weapon = new Weapon()
            {
                WeaponAttributes = new WeaponAttributes(),
                WeaponType = WeaponType.WEAPON_DAGGER
            };
            //Act

            // Assert
            Assert.NotNull(weapon);
        }
        [Fact]
        public void Dps_GetWeaponDps_ShouldBeExpectedValue()
        {
            // Arrange
            double actual = testWeapon.WeaponAttributes.Dps;
            double expected = 9.6;
            //Act
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_SetDamagOnInit_ShouldHaveWeaponDamage()
        {
            // Arrange
            Weapon weapon = new Weapon() 
            { 
                WeaponAttributes = new WeaponAttributes() {Damage = 7, AttackSpeed = 1.1 }
            };
            double actual = weapon.WeaponAttributes.Damage;
            double expected = 7;
            // Act
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AttackSpeed_SetDAttackSpeedOnInit_ShouldHaveWeaponAttackSpeed()
        {
            // Arrange
            Weapon weapon = new Weapon()
            {
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            // Act
            double actual = weapon.WeaponAttributes.AttackSpeed;
            double expected = 1.1;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armour_CreateNewArmour_NotNull()
        {
            // Arrange
            Armour armour = new Armour()
            {
                Attributes = new PrimaryAttributes() { Strength = 1, Dexterity = 3, Intelligence = 5 }
            };
            // Act
            int[] actual = armour.Attributes.GetAllAttributes();
            int[] expected = new int[] { 1,3,5 };
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
