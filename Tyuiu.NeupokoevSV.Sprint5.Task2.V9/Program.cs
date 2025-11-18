using Tyuiu.NeupokoevSV.Sprint5.Task2.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] ints = new int[3, 3] { { 6, 8, 3 }, { 2, 6, 8 }, { 1, 7, 1 } };
        int rows = ints.GetUpperBound(0) + 1;
        int cols = ints.Length / rows;
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int  i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write($"{ints[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(ints);
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}