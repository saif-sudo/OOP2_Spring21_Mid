using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycopyelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 35, 66, 52, 96 };

            int[] arr2 = new int[5];

            int i;

            for (i = 0; i < arr1.Length; i++)
            {

                Console.WriteLine("arr1[" + i + "] element is: " + arr1[i]);

            }

            Console.WriteLine("----------- After copy the element of arr1 into arr2-------------------");

            for (i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];

                Console.WriteLine("arr2[" + i + "] element is: " + arr2[i]);

            }
        }
    }
}
