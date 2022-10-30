using Microsoft.VisualStudio.TestPlatform.TestHost;
using ProgrammerAdventures;
using System.Reflection.PortableExecutable;

namespace ProfessionTests
{
    [TestClass]
    public class ProfessionTests
    {
        [TestMethod]
        public void TestDruid()
        {
            // Arrange
            string profession = "druid";
            var creator = new CharacterCreator();

            // Act
            var playerCharacter = creator.CharacterCreation(profession);

            // Assert
            string result = "Druid";
            Assert.AreEqual(result, playerCharacter.profession);
        }

        [TestMethod]
        public void TestKnight()
        {
            // Arrange
            string profession = "knight";
            var creator = new CharacterCreator();

            // Act
            var playerCharacter = creator.CharacterCreation(profession);

            // Assert
            string result = "Knight";
            Assert.AreEqual(result, playerCharacter.profession);
        }
    }
}