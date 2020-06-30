using AiDaSi_Hash;
using System;
using System.Data;

namespace AiDaSi_TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashMapInsterface<string, string> hashMapInsterface = new HashMapInit<string, string>();
            //hashMapInsterface.Put("key1", "Value1");
            //hashMapInsterface.Put("key2", "Value2");
            //hashMapInsterface.Put("Hey3", "Value3");
            //string value = hashMapInsterface.GetV("Hey3");
            //hashMapInsterface.Put("Hey3", "Value4");
            //value = hashMapInsterface.GetV("Hey3");
            DataTable table = new DataTable();
            string value = table.Compute("1.1448e-5", "").ToString();
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
