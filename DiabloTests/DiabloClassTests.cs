using Diablo;
using Diablo.HeroClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace DiabloTests
{
    public class DiabloTClassTests
    {
            // these are needed on several tests
            Warrior warrior;
        [TestInitialize]
        public void TestInitialize() // initialize the classes before test methods use them
        {
            warrior = new Warrior("Paul");

        }

        [Fact]
        public void Create_New_Mage()
        {
            // Arrange
            //Mage mage = new Mage(); // Cannot initialize yet
            // Act
            
            // Assert
            Assert.NotNull(warrior);
        }
        public void Name_Warrior_New_On_Init()
        {
            // Arrange
            Warrior warrior = new Warrior("Paul");
            // Act
            string actual = warrior.Name;
            string expected = "Paul";
            // Assert
            Assert.Equal(actual, expected);
        }
        public void Level_Up_New_Warrior()
        {

        }
    }
}