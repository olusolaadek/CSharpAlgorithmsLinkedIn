using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashStructures
{
    internal class DictionarySamples
    {
        /// <summary>
        /// Display the count of each element in an unsorted array
        /// </summary>
        /// <param name="arr"></param>
        public static void CountElements(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int key in arr)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key]++;  //= dict[key] + 1;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            foreach (KeyValuePair<int, int> item in dict)
            {
                Console.WriteLine(item.Key + "-> " + item.Value);
            }
        }
    }
}
