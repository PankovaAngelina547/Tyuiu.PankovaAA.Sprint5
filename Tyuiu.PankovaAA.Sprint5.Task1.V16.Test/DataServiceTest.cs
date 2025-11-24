using Tyuiu.PankovaAA.Sprint5.Task1.V16.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task1.V16.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
