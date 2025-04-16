using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReverseArrayImpl
    {
        public static int[] ReverseArrray(int[] input)
        {
            int length = input.Length;
            int[] reversedArray = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                reversedArray[i] = input[length-i-1];
            }

            return reversedArray;
        }

        public static int[] ReverseArrrayWithSwap(int[] input)
        {
            int length = input.Length;
            int[] reversedArray = new int[length];

            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i];
                reversedArray[i] = input[length - i - 1];
                reversedArray[length - i - 1] = temp;
            }

            return reversedArray;
        }
    }
}
