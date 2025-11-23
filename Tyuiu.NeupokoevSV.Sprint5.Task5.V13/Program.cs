using Tyuiu.NeupokoevSV.Sprint5.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V13.txt");

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("РЕЗУЛЬТАТ");
        Console.WriteLine("********************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}