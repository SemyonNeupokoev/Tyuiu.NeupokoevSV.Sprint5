using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NeupokoevSV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine(); // Читаем всю строку
                if (line == null) return 0;

                string[] numbers = line.Split(' ');
                double res = 0;
                int a = 0;

                foreach (string numStr in numbers)
                {
                    res += Convert.ToDouble(numStr.Replace('.', ','));
                    a++;
                }

                return Math.Round(res / a, 3);
            }
        }
    }
}
