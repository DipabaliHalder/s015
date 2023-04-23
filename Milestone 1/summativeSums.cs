using System;
namespace GuessingGame
{
    class Program
    {
        static int summativeSum(int[] arr){
            int sum=0;
            for(int i=0;i<arr.Length;i++){
                sum+=arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {              
            int[] a1=new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] a2=new int[] { 999, -60, -77, 14, 160, 301 };
            int[] a3=new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };
            Console.WriteLine("#1 Array Sum: {0}",summativeSum(a1));
            Console.WriteLine("#2 Array Sum: {0}",summativeSum(a2));      
            Console.WriteLine("#3 Array Sum: {0}",summativeSum(a3));      
        }
    }
}
