using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolkovIS.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt");
            string text = File.ReadAllText(path);
            StringBuilder newText = new StringBuilder();
            foreach (char c in text)
            {
                if (c < 'A' || c > 'Z')
                {
                    newText.Append(c);
                }
            }
            File.WriteAllText(outputPath, newText.ToString());
            return outputPath;
        }
    }
}
