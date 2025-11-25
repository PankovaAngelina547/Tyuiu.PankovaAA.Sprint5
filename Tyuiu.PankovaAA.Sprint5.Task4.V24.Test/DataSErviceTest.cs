using Tyuiu.PankovaAA.Sprint5.Task4.V24.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task4.V24.Test
{
    [TestClass]
    public sealed class DataSErviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
       
