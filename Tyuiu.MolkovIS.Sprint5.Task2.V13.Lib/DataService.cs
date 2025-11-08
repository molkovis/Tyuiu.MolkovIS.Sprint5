using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task2V13
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            //Преобраз матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                }

            }

            string path = Path.Combine(Path.GetTempPath(),
                "OutPutFileTask2.csv");

            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        string row = "";
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            row += matrix[i, j];
                            if (j < matrix.GetLength(1) - 1)
                                row += ";";
                        }
                        writer.WriteLine(row);
                    }
                }
            }
            return path;
        }
    }
}
