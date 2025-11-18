using Tyuiu.NeupokoevSV.Sprint5.Task1.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = -5; 
        int y = 5;
        string res = ds.SaveToFileTextData(x, y);
        Console.WriteLine($"Файл: {res}");
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}