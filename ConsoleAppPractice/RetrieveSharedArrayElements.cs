using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RetrieveSharedArrayElements
    {
        public static void FindSharedElements(int[] array1, int[] array2)
        {
            List<int> sharedElements = new List<int> ();
            HashSet<int> secondArrayElements = new HashSet<int>();

            foreach(int item in array2)
            {
                secondArrayElements.Add (item);
            }

            foreach(int item in array1)
            {
                if (secondArrayElements.Contains (item))
                {
                    sharedElements.Add (item);
                }
            }
            
            sharedElements.ForEach(item => Console.WriteLine($"{item}"));
           // return sharedElements;
        }
    }
}
