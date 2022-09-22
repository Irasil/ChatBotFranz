using FranzBot;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace FranzLibraryTestProject
{
    /// <summary>
    /// Unit Test des ChatBotFranz
    /// </summary>
    public class FranzLibraryTest
    {


        /// <summary>
        /// Das erwartete Return der Methode Load() in der Classe Storage
        /// </summary>
        [Fact]
        public void TestLoad()
        {
            // Arrange
            string _input = "Hey";
            string end = "List.xml";
            Storage storage = new Storage();

            //Act
            var result = storage.Load(_input, end);

            //Assert

            Assert.Equal("Hallo", result);
        }

        /// <summary>
        /// Das erwartete Return der Methode Load1() in der Classe Storage
        /// </summary>
        [Fact]
        public void TestLoad1()
        {
            // Arrange
            string _input = "Hey";
            string end = "List.csv";
            Storage storage = new Storage();

            //Act
            var result = storage.Load1(_input, end);

            //Assert
            Assert.Equal("Hallo", result);
        }

        /// <summary>
        /// Das erwartete Return der Methode Getanswer1() in der Classe BotEngine für die csv dateil
        /// </summary>
        [Fact]
        public void TestGetanswer1()
        {
            //Avarage
            string _input = "Hallo";
            string end = "List.csv";
            BotEngine message = new BotEngine();

            //Act
            var result = message.getAnswer1(_input, end);

            //Assert
            Assert.Equal("Guten Tag", result.ToString());

        }

        /// <summary>
        /// Das erwartete Return der Methode Getanswer() in der Classe BotEngine für die XML dateil
        /// </summary>
        [Fact]
        public void TestGetanswer()
        {
            //Avarage
            string _input = "Hallo";
            string end = "List.xml";
            BotEngine message = new BotEngine();

            //Act
            var result = message.getAnswer(_input, end);

            //Assert
            Assert.Equal("Guten Tag", result.ToString());

        }
    }
}