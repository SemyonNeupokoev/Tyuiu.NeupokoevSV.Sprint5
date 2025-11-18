using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NeupokoevSV.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double f = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            f = Math.Pow(f, 2);
            using (BinaryWriter write = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                write.Write(BitConverter.GetBytes(f));
            }
            return path;
        }
    }
}
