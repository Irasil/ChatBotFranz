using FranzBot;

namespace TestProject1
{
    /// <summary>
    /// Unit Test des ChatBotFranz
    /// </summary>
    public class UnitTest1
    {   
        /// <summary>
        /// Das erwartete Return des Methode Load()
        /// </summary>
        private const string Expected = "Hallo";
        /// <summary>
        /// Load() unit Test
        /// </summary>
        [Fact]
        public void Test1()
        {
            string _input = "Hey";
            string end = "List.csv";
            FranzBot.Storage storage = new Storage();
            var result = storage.Load1(_input, end);
            Assert.Equal(Expected, result);
        }
    }
}