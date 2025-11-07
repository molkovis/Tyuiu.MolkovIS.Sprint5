using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, (Math.Round(-1.4 * Math.Pow(x,3) + 2.3 * Math.Pow(x,2) + 0.6 * x,3)).ToString());
            return path;
        }
    }
}
