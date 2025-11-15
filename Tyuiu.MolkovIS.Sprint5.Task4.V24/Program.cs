using Tyuiu.MolkovIS.Sprint5.Task4.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";

        DataService dataService = new DataService();

        double res = dataService.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}