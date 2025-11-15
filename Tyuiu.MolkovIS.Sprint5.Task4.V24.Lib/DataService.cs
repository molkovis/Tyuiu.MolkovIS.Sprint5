using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            double x = Double.Parse(text, NumberStyles.Float, CultureInfo.InvariantCulture);



            double res = (1.0 / (x * x) + 2.0) * Math.Sin(x);

            return Math.Round(res,3);
        }
    }
}
