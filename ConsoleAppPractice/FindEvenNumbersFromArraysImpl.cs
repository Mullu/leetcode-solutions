using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FindEvenNumbersFromArraysImpl
    {
        public static int[] FindEvenNumbers(int[] array1, int[] array2)
        {
            var arrayList = new ArrayList();

            foreach (var item in array1)
            {
                if (item % 2 == 0)
                {
                    arrayList.Add(item);
                }
            }
            foreach (var item in array2)
            {
                if (item % 2 == 0)
                {
                    arrayList.Add(item);
                }
            }
            return (int[]) arrayList.ToArray(typeof(int));
        }
    }
}
