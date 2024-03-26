using System;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace CodeWars1
{


    internal class Program
    {
        // public static int FindDup(int[] arr)
        // {
        //     int duplicateValue = 0;
        //     Array.Sort(arr);
        //    for (int i = 0;i<arr.Length-1;i++)
        //     {
        //         if (arr[i] == arr[i+1])
        //         {
        //             duplicateValue = arr[i];
        //         }
        //
        //     }
        //     return duplicateValue;
        // }

        /// <summary>
        /// Method 
        /// </summary>
        /// TODO: Denis protestirui
        public void Alo()
        {
            Console.WriteLine("Ti pidor");
        }

        public static int FindDup(int[] arr)
        {
            int duplicateValue = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicateValue = arr[i];
                }

            }
            return 1;
        }


        static void Main(string[] args)
        {
            ConsoleWork number = new ConsoleWork();


        }
    }
}