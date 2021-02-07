using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int sum = 0;
            for (int i = 1; i <= 100; i++) {
               sum = sum + i;
                Console.WriteLine(sum);
            }

        }
    }
}
