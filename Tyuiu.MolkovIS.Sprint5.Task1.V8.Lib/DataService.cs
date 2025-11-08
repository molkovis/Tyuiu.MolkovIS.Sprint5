using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y;
            string stry;

            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(4 - 2 * i + (2 + Math.Cos(i)) / (2 * i - 2), 2);
                if (Double.IsInfinity(y))
                    stry = "0";
                else
                    stry = Convert.ToString(y);

                using(FileStream file = new FileStream(path, FileMode.Append))
                {
                    using(StreamWriter writer = new StreamWriter(file))
                    {
                        writer.WriteLine(stry);
                    }
                }
            }
            return path;
        }
    }
}

