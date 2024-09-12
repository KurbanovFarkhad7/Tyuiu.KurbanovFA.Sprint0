using Tyuiu.KurbanovFA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KurbanovFA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Фархад";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Фархад", res);
        }
    }
}