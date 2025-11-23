using Tyuiu.NeupokoevSV.Sprint5.Task5.V13.Lib;
namespace Tyuiu.NeupokoevSV.Sprint5.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\semyon\AppData\Local\Temp\InPutDataFileTask5V13.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
