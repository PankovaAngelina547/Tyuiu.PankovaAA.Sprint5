using Tyuiu.PankovaAA.Sprint5.Task2.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();

            int[,] array = new int[3, 3]
            {
                { 3, 8, 4 },
                { -5, -4, -3 },
                { -9, 0, 2 }
            };

            string path = ds.SaveToFileTextData(array);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
    
