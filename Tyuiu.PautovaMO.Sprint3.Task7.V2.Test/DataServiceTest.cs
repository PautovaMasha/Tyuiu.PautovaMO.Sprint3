using Tyuiu.PautovaMO.Sprint3.Task7.V2.Lib;
namespace Tyuiu.PautovaMO.Sprint3.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 59.49;   // x = -5
            valueWaitArray[1] = 38.47;   // x = -4
            valueWaitArray[2] = -2.81;   // x = -3
            valueWaitArray[3] = -19.67;  // x = -2
            valueWaitArray[4] = -8.42;   // x = -1
            valueWaitArray[5] = 0.57;    // x = 0
            valueWaitArray[6] = -6.30;   // x = 1
            valueWaitArray[7] = -20.14;  // x = 2
            valueWaitArray[8] = -3.51;   // x = 3
            valueWaitArray[9] = 38.13;   // x = 4
            valueWaitArray[10] = 59.60;  // x = 5

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
