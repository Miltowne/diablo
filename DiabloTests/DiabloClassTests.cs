using Diablo.HeroClasses;
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
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            warriorTest = new Warrior();
            rogueTest = new Rogue();
            mageTest = new Mage();
            rangerTest = new Ranger();
            weaponTest = new Weapon();
        }

        [Fact]
        public void Create_New_Mage()
        {
            // Arrange
            Mage mage = new Mage(); // Cannot initialize yet
            //Act

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
            Ranger ranger = new Ranger();


            // Act
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


            // Act
            rogue.LevelUp();
            int actual = rogue.Level;
            int expected = 2;
            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Level_Up_New_Mage()
        {
            // Arrange
            Mage mage = new Mage();



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
        public void Total_Damage_On_Character_With_Weapon()
        {
            // Arrange
            warriorTest.addItem(weapon);
            // Act
            double expected = (1 * 5 * 0,1) + weaponTest.Damage * weaponTest.Attackspeed;
            // Assert
            Assert.Equal(actual, expected);
        }

    }
}