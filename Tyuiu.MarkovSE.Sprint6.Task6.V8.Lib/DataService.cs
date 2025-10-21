using tyuiu.cources.programming.interfaces.Sprint6;
using System.Text.RegularExpressions;

namespace Tyuiu.MarkovSE.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
            string result = string.Empty;

            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);

                string pattern = @"\b\w*z\w*\b";
                MatchCollection matches = Regex.Matches(content, pattern);

                foreach (Match match in matches)
                {
                    result += match.Value + " ";
                }
            }

            return result.Trim();
        }
    }
}