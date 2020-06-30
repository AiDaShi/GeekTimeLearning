using AiDaSi_Hash;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AiDaSi_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HashMapInsterface<string, string> hashMapInsterface = new HashMapInit<string, string>();
            hashMapInsterface.Put("key1", "Value1");
            hashMapInsterface.Put("key2", "Value2");
            hashMapInsterface.Put("Hey3", "Value3");
            string value = hashMapInsterface.GetV("Hey3");

        }
    }
}
