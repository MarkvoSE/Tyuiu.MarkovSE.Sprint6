using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarkovSE.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            // Реализация для интерфейса (может быть пустой)
            return "";
        }

        // Дополнительный метод с двумя параметрами
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                    if (words.Length >= 2)
                    {
                        result += words[1] + " ";
                    }
                }
            }

            return result.Trim();
        }
    }
}