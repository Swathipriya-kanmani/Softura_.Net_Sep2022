using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Operators
    {
        public abstract void add(int a1, int a2);
        public abstract void sub(int s1, int s2);
        public abstract void mul(int m1, int m2);
        public abstract void div(int d1, int d2);

    }

    class Calculator : Operators
    {
        public override void add(int a1, int a2)
        {
            Console.WriteLine("Addition of two numbers is {0}", a1 + a2);
        }
        public override void sub(int s1, int s2)
        {
            Console.WriteLine("Subtraction of two numbers is {0}", s1 - s2);
        }
        public override void mul(int m1, int m2)
        {
            Console.WriteLine("Multiplication of two numbers is {0}", m1 * m2);
        }
        public override void div(int d1, int d2)
        {
            Console.WriteLine("Division of two numbers is {0}", d1 / d2);
        }

    }
    internal class OperationAbs
    {
        public static void Main()
        {
            Calculator calc = new Calculator();
            calc.add(20, 5);
            calc.sub(40, 8);
            calc.mul(18, 6);
            calc.div(49, 7);
        }
    }
}





