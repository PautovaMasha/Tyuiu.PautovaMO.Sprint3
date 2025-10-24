using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PautovaMO.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = "56hy vfe4r4 vf45b";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    str = str.Replace(c, 'w');
                }
            }

            return str;
        }
    }
}
