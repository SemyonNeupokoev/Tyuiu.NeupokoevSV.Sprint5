using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NeupokoevSV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] numbers = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string numStr in numbers)
            {
                // Нормализуем разделитель и преобразуем в число
                string norm = numStr.Replace('.', ',');

                if (double.TryParse(norm, out double number))
                {
                    // Проверяем, находится ли число в диапазоне от -1.5 до 1.5
                    if (number >= -1.5 && number <= 1.5)
                    {
                        sum += number;
                        count++;
                    }
                }
            }
            double average = sum / count;

            return Math.Round(average, 3);
        }
    }
}
