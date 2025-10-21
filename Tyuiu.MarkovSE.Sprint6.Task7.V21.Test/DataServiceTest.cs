using Tyuiu.MarkovSE.Sprint6.Task7.V21.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            double y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
            var wait = 1.62;
            Assert.AreEqual(wait, y);
        }
    }
}