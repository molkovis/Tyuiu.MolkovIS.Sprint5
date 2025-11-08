using Tyuiu.MolkovIS.Sprint5.Task1.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите начало");
        int startValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конец");
        int stopValue = Convert.ToInt32(Console.ReadLine());
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = dataService.SaveToFileTextData(startValue,stopValue);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}