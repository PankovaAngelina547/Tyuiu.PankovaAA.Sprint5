using System.IO;
using Tyuiu.PankovaAA.Sprint5.Task0.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ACER\OneDrive\Desktop\Tyuiu.PankovaAA.Sprint5\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
