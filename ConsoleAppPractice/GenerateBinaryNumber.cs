using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GenerateBinaryNumber
    {
        public static void PrintBinaryNumbers(int n)
        { 
            if (n < 0) 
                return;

            var queue = new Queue<int>();
            queue.Enqueue(1);

            for (int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);

                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
        }
    }
}
