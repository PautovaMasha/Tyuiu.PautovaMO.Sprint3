using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using Tyuiu.PautovaMO.Sprint3.Task3.V9.Lib;
namespace Tyuiu.PautovaMO.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string str = "56hy vfe4r4 vf45b";
            char chr = 'w';
            string res=ds.ReplaceNumOnChar(str, chr);
            string wait = "wwhy vfewrw vfwwb";
            Assert.AreEqual(wait, res);

        }
    }
}
