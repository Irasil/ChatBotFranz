using FranzBot;
using FranzLibrary;
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
        /// Das erwartete Return der Methode Load() in der Classe XML_Storage();
        /// </summary>
        [Fact]
        public void TestLoadXML()
        {
            // Arrange
            string _input = "Hey";
            string end = "List.xml";
            XML_Storage storage = new XML_Storage();

            //Act
            var result = storage.Load(_input, end);

            //Assert

            Assert.Equal("Hallo", result);
        }

        /// <summary>
        /// Das erwartete Return der Methode Load() in der CSV_TXT_Storage
        /// </summary>
        [Fact]
        public void TestLoadCSV_TXT()
        {
            // Arrange
            string _input = "Hey";
            string end = "List.csv";
            CSV_TXT_Storage storage = new CSV_TXT_Storage();

            //Act
            var result = storage.Load(_input, end);

            //Assert
            Assert.Equal("Hallo", result);
        }


        /// <summary>
        /// Das erwartete Return der Methode Loader() in der Classe Stroarge
        /// </summary>
        [Fact]
        public void TestLoader()
        {
            //Avarage
            string _input = "Hey";
            string end = "List.xml";
            //CSV_TXT_Storage storageCSV = new CSV_TXT_Storage();
            XML_Storage storageXML = new XML_Storage();
            Storage strXML = new Storage(storageXML);

            //Act
            var result = strXML.Loader(_input, end);

            //Assert
            Assert.Equal("Hallo", result.ToString());

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
            XML_Storage storageXML = new XML_Storage();

            //Act
            var result = message.getAnswer(_input, end, storageXML);

            //Assert
            Assert.Equal("Guten Tag", result.ToString());

        }
    }
}