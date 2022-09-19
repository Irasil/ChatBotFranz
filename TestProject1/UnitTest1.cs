using FranzBot;

namespace TestProject1
{
    public class UnitTest1
    {
        private const string Expected = "Hallo";
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