using Tyuiu.PankovaAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }

       
    }
}
        
