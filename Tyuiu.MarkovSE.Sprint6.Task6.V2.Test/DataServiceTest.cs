using Tyuiu.MarkovSE.Sprint6.Task6.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint6.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V2.txt";
            string wait = "da ijiH M upBSzre YGVyY";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}