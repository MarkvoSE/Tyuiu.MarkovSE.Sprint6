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
            string path = @"C:\Sprint6Task6\InPutDataFileTask6V2.txt";
            string str = "test";
            string res = dataService.CollectTextFromFile(str, path);
            string wait = "da ijiH M upBSzre YGVyY";
            Assert.AreEqual(wait, res);
        }
    }
}