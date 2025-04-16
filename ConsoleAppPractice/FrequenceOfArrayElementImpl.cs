using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FrequenceOfArrayElementImpl
    {
        public static void DispalceElementsFrequence(int[] array)
        {
            Dictionary<int, int> freqDictionary = new Dictionary<int, int>();

            foreach(int element in array)
            {
                if (freqDictionary.ContainsKey(element))
                {
                    freqDictionary[element]++;
                }
                else
                {
                    freqDictionary[element] = 1; 
                }
            }

            foreach (var item in freqDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
