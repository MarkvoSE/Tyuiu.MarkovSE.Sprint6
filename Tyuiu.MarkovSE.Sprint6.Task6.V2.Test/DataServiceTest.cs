using Tyuiu.MarkovSE.Sprint6.Task6.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService dataService = new DataService();
            string res = "da ijiH M upBSzre YGVyY";
            Assert.AreEqual(res, dataService.CollectTextFromFile(@"C:\Sprint6Task6\InPutDataFileTask6V2.txt"));
        }
    }
}