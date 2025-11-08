using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolkovIS.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double result;

            using(BinaryWriter writer = new BinaryWriter(File.Open(path,FileMode.OpenOrCreate)))
            {
                result = (4 * Math.Pow(number , 3)) / (Math.Pow(number, 3) - 1);
                writer.Write(BitConverter.GetBytes(result));
            }
            return result;
        }
    }
}
