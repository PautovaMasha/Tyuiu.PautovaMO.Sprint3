using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PautovaMO.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
         public double GetSumSeries(int startValue, int stopValue)
        {
            double ressum = 0;
            while ( startValue <= stopValue)
            {
                ressum = ressum + (Math.Pow(1.0 / (Math.Cos(startValue)), 2));
                startValue++;
            }
            return Math.Round(ressum, 3);
        }
    }
}