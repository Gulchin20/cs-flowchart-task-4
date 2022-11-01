using System;
namespace array
{
    class AverageOfArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 82, 34,42 };
            int sum = 0;
            float avg;
            for(int i=0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            avg = sum / arr.Length;

            Console.WriteLine(avg);
            
        }
    }
}
