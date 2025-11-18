using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NeupokoevSV.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                if (3 * x + 1.2 != 0)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, "0" + Environment.NewLine);
                }
            }
            return path;
        }
    }
}
