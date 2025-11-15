using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");

            int maxNumber = 0;
            bool isFirst = false;


            foreach (string value in strings)
            {
                if (int.TryParse(value, out int currentNumber))
                {
                    if (currentNumber % 10 == 0 && currentNumber != 0)
                    {
                        if (!isFirst)
                        {
                            maxNumber = currentNumber;
                            isFirst = true;
                        }
                        else if (currentNumber > maxNumber)
                        {
                            maxNumber = currentNumber;
                        }
                    }
                }
            }
            return maxNumber;
        }

    }
}

