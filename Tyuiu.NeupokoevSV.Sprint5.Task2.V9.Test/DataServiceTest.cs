using Tyuiu.NeupokoevSV.Sprint5.Task2.V9.Lib;
namespace Tyuiu.NeupokoevSV.Sprint5.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
