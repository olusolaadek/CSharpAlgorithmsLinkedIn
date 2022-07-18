using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashStructures
{
    internal class HashSetSamples
    {

        /// <summary>
        ///  Find items in the first array, but not the second array
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] FindMissingElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>();
            // populate second array with HashSet
            ArrayList result = new ArrayList();
            foreach (var item in arr2)
            {
                set.Add(item);
            }

            foreach (var item in arr1)
            {
                if (!set.Contains(item))
                {
                    result.Add(item);
                }
            }

            return (int[])result.ToArray(typeof(int));

        }
    }
}
