using Tyuiu.KenihAN.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KenihAN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Леша";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Леша", res);
        }
    }
}