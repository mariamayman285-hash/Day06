using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using common1;

namespace Day06
{
    #region Problem 1
    public struct Point
    {
        public int x;
        public int y;

        /*public Point()
        {
            x = 0;
            y = 0;
        }*/
        #region Problem 4
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int Value)
        {
            x = Value;
            y = 0;
        } 
        #endregion

        public override string ToString()
        {
            return ($"({x}, {y})");
        }
        //A struct is a value type in C#. It cannot inherit from another struct or class because C# does not support inheritance for structs. However, a struct can implement interfaces 
        #endregion


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1 testing
            //Point p = new Point();
            //Console.WriteLine(p); 
            #endregion

            #region Problem 2 testing 
            //TypeA M = new TypeA();
            //M.F = 10;
            //M.G = 10;
            //M.H = 10; 
            #endregion

            #region Problem 3 testing
            //Employee emp = new Employee();
            //emp.SetName("Mariam");
            //Console.WriteLine(emp.GetName());

            //emp.Salary = 20000;
            //Console.WriteLine(emp.Salary);

            //emp.EmpId = 11;
            //Console.WriteLine(emp.EmpId);

            ////encapsulation is important to protect data and control access + it makes code easier to maintain + scalability(we can scale it or use a validation 
            #endregion

            #region Problem 4 testing
            //Point p1 = new Point(10,20);
            //Console.WriteLine(p1.x + " " + p1.y);

            //p1= new Point(10);
            //Console.WriteLine(p1.x + " " + p1.y);
            ////Constructors in structs are special methods used to initialize the fields of a struct when it is created 
            #endregion

            #region Problem 5
            //Point p2 = new Point(1,2);
            //Console.WriteLine(p2);
            //Point p3 = new Point(3, 4);
            //Console.WriteLine(p3);
            //Point p4 = new Point(5, 6);
            //Console.WriteLine(p4);
            ////overriding ToString() improve readability a clear representation insead of a random output. making it easier to understand 
            #endregion

            #region Problem 6
            //PointStruct P = new PointStruct();
            //P.X = 20;
            //P.Y = 30;
            //P.ChangePoint(P);
            //Console.WriteLine(P.X + " " + P.Y);

            //EmployeeClass E = new EmployeeClass();
            //E.X = 20;
            //E.Y = 30;
            //E.ChangeEmployee(E);
            //Console.WriteLine(E.X + " " + E.Y);

            ///*
            //  Structs are value types, so they store the actual value. When passed by value,only a copy is affected not the original value

            //  Classes are reference types, so variables store a reference to an object. When the object is modified the original object is affected
            // */ 
            #endregion
        }
    }
}
