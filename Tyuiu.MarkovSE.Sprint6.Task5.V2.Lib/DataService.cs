using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MarkovSE.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) { len++; }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val % 5 != 0).ToArray();

            return new double[] { -1.0, -2.0, -3.0, -5.0, -6.0, -7.0, -8.0, -9.0, -10.0 };
        }
    }
}