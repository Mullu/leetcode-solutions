
namespace Algorithms
{
    public class ArrayBinarySearchImpl
    {
        public static Boolean BinarySearch(int[] array, int item) 
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (array[mid] == item)
                {
                    return true;
                }
                else if (array[mid] > item)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }
        //public static void Main(String[] args)
        //{
        //    int[] array = {1, 2, 3, 4, 5, 6};

        //    Console.WriteLine(BinarySearch(array, 4));
        //    Console.WriteLine(BinarySearch(array, 4));
        //}
    }
}
