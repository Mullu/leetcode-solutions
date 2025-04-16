using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RotateArrayToLeft
    {
        public static int[] RotateArrayByOnePosition(int[] input)
        {
            int length = input.Length;
            int[] rotatedArray = new int[length];

            for (int i = 1; i < length; i++)
            {
                rotatedArray[i - 1] = input[i];
            }

            rotatedArray[length - 1] = input[0];

            return rotatedArray;
        }
    }
}
