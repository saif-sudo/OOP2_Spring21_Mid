using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy = 80, chem = 90, bio = 75, math = 67, comp = 66;
            float per;

            per = (phy + chem + bio + math + comp) / 5.0f;

            Console.WriteLine("Percentage = "+per);


            /* Find grade according to the percentage */
            if (per >= 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if (per >= 85 && per <= 89)
            {
                Console.WriteLine("Grade A");
            }
            else if (per >= 80 && per <= 84)
            {
                Console.WriteLine("Grade B+");
            }
            else if (per >= 75 && per <= 79)
            {
                Console.WriteLine("Grade B");
            }
            else if (per >= 50 && per <= 74)
            {
                Console.WriteLine("Grade C+");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }
    }
}
