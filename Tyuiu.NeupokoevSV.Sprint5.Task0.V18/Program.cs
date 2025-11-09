using Tyuiu.NeupokoevSV.Sprint5.Task0.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3; Console.WriteLine($"x = {x}");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: {res}");
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}