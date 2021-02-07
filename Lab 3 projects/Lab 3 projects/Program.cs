using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_projects
{
    class Student {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Department { get => department; set => department = value; }
        public float Cgpa { get => cgpa; set => cgpa = value; }

        public void showinfo() {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Department: "+department);
            Console.WriteLine("Cgpa: "+cgpa);
        }
    }


    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public Triangle() { }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        

        public void showinfo()
        {
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("Z = " + z);


        }

        public void TestTriangle()
        {
            if (x == y && y == z && z == x)
            {
                Console.WriteLine("Equilateral triangle");
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine("Isosceles triangle");

            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }
        }
    }


    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        private int deposit;
        private int withdraw;
      

        public Account() { }

        public string AccName { get => accName; set => accName = value; }
        public string Acid { get => acid; set => acid = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Deposit { get => deposit; set => deposit = value; }
        public int Withdraw { get => withdraw; set => withdraw = value; }

        public void showinfo()
        {
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Deposit: " + deposit);
            Console.WriteLine("Withdraw: " + withdraw);
            Console.WriteLine("Balance: "+balance);
        }
    }


    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        


        public Course() { }

        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public int CourseCredit { get => courseCredit; set => courseCredit = value; }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Student Class Program ***************************");
            Student s = new Student();
            s.Name = "Saif";
            s.Id = "18-38710-3";
            s.Department = "CSE";
            s.Cgpa = 3.14f;
            s.showinfo();

            Console.WriteLine("******************* Triangle Class Program ***************************");

            Triangle t = new Triangle();
            t.X = 20;
            t.Y = 30;
            t.Z = 20;

            t.showinfo();
            t.TestTriangle();
            Console.WriteLine("******************* Account Class Program ***************************");
            Account a = new Account();
            a.AccName = "Saif";
            a.Acid = "123456";
            a.Deposit = 80000;
            a.Withdraw = 2000;
            a.Balance = a.Deposit - a.Withdraw;
            a.showinfo();

            Console.WriteLine("******************* Course Class Program ***************************");
            Course c = new Course();
            c.CourseName = "PLL2";
            c.CourseCode = "123456";
            c.CourseCredit = 3;

            c.ShowCourseInfo();


        }
    }
}
