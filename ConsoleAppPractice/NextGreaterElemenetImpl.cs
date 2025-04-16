using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class NextGreaterElemenetImpl
    {
        public static void PrintNextGreaterElement(int[] array)
        {
            if (array.Length == 0)
                return;
            int n = array.Length;
            var stack = new Stack<int>();
            var result = new Dictionary<int, int>();

            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= array[i])
                {
                    stack.Pop();
                }

                int nextGreater = stack.Count > 0 ? stack.Peek() : -1;
                result[array[i]] = nextGreater;

                stack.Push(array[i]);
            }

            foreach (var num in array)
            {
                Console.WriteLine($"{num} ---> {result[num]}");
            }
        }
    }
}
