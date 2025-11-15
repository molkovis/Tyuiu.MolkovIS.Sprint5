using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            List<int> integerValues = new List<int>();

            foreach (string s in strings)
            {
                if (int.TryParse(s, out int number))
                {
                    integerValues.Add(number);
                }
            }

            var multiplesOfTen = integerValues.Where(num => num % 10 == 0);

            int maxResult = multiplesOfTen.Max();
            return maxResult;
        }

    }
}

