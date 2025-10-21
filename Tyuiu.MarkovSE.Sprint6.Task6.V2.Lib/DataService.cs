using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarkovSE.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";
            result = result.Trim();
            using (StreamReader reader = new StreamReader(path))
            {
                string lines;
                while ((lines = reader.ReadLine()) != null)
                {
                    string[] words = lines.Split(' ');
                    if (words.Length > 1)
                    {
                        result += words[1] + " ";
                    }
                    else
                    {
                        // 
                    }
                }
            }
            return result.Trim();
        }

       
    }
}