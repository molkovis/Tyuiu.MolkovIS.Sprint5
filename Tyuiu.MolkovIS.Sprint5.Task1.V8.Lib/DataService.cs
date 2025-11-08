using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = File.Exists(path);

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string stry;

            for (int i = startValue; i <= stopValue; i++)
            {
                y = 4 - i * 2 + (2 + Math.Cos(i)) / (2 * i - 2);
                stry = Convert.ToString(y);

                using(StreamWriter stream = new StreamWriter(path))
                {
                    stream.WriteLine(stry);
                }
            }
            return path;
        }
    }
}
