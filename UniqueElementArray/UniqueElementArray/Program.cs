﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicateElementCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 11, 35, 10, 66, 66, 66, 5, 2, 35 };

            int i, j, carr, count = 0;

            for (i = 0; i < arr1.Length; i++)
            {
                carr = arr1[i];

                for (j = 0; j < arr1.Length; j++)
                {
                    if (carr == arr1[j])
                    {
                        count++;


                    }





                }

                if (count == 1)
                {

                    Console.WriteLine("Total duplicate of arr1[" + i + "] =" + arr1[i] + " is unique element");

                }

                count = 0;
            }
        }
    }
}
