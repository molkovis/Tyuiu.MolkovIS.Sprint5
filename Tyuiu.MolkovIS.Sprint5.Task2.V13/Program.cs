using Tyuiu.MolkovIS.Sprint5.Task2.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = {
            { 7, 6, 5 },
            { 7, 7, 8 },
            { 6, 6, 9 }
        };
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = dataService.SaveToFileTextData(matrix);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}