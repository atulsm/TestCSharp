using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> testDictionary = new Dictionary<string, string>();
            testDictionary.Add("1", "one");
            if (testDictionary.ContainsKey("1"))
            {
                Debug.WriteLine("Already contains key 1");
            }
            else
            {
                testDictionary.Add("1", "ONE");
            }

            Debug.WriteLine(testDictionary);

            String key = String.Format("{0}:{1}", "key", "value");
            Debug.WriteLine(key);
        }
    }
}
