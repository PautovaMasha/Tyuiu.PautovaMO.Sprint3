using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PautovaMO.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;
            for (i = startValue1; i<= stopValue1; i++)
            {
                for (j = startValue1; j <= stopValue1; j++)
                {
                    res = res + ((Math.Sin(x) + x)/(x));
                }

            }
            return Math.Round(res, 3);
        }
    }
}
