using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 98, 1, 3, 34, 9, 76, 45, 4 };
            // int[] arr = { 54, 546, 548, 60 };
            Int64 result = CombineInts(arr);

            Console.WriteLine(result);
        }

        static Int64 CombineInts(int[] arr)
        {
            string[] input = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                input[i] = arr[i].ToString();
            }

            Array.Sort(input, CustomSort);

            string result = null;

            foreach (string str in input)
            {
                result += str;
            }

            return Int64.Parse(result);
        }

        static int CustomSort(string s1, string s2)
        {
            string s1s2 = s1 + s2;
            string s2s1 = s2 + s1;

            return s1s2.CompareTo(s2s1) > 0 ? -1 : 1;
        }
    }
}
