using System.Globalization;

namespace Aug29Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Enter element to search");
            int k=Convert.ToInt32(Console.ReadLine());
            binarySearch(arr, 0, arr.Length - 1, k);
        }
        public static void binarySearch(int[] a,int i,int j,int k)
        {
            int mid;
            while (i <= j)
            {
                mid=(i+j)/2;
                if (a[mid] == k)
                {
                    Console.WriteLine(mid);
                    break;
                }
                else if (a[mid] > k)
                    j = mid - 1;
                else
                    i = mid + 1;

            }
        }
    }
}