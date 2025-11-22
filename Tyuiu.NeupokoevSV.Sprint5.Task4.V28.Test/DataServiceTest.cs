using Tyuiu.NeupokoevSV.Sprint5.Task4.V28.Lib;
namespace Tyuiu.NeupokoevSV.Sprint5.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\semyon\AppData\Local\Temp\InPutDataFileTask4V28.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
