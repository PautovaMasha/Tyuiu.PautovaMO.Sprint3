using Tyuiu.PautovaMO.Sprint3.Task6.V8.Lib;
namespace Tyuiu.PautovaMO.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            
            int startValue = 18;
            int stopValue = 28;


            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 292;
            Assert.AreEqual(wait, res);

        }
    }
}
