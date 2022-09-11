using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AddSub
    {
        int as1, as2;
        public void add(int as1, int as2)
        {
            this.as1 = as1;
            this.as2 = as2;
            Console.WriteLine("Addition of two numbers is {0}", as1 + as2);
        }
        public void sub(int as1, int as2)
        {
            this.as1 = as1;
            this.as2 = as2;
            Console.WriteLine("Subtraction of two numbers is {0}", as1 - as2);
        }
    }

    public class MulDiv : AddSub
    {
        int as1, as2;
        public void mul(int as1, int as2)
        {
            this.as1 = as1;
            this.as2 = as2;
            Console.WriteLine("Multiplication of two numbers is {0}", as1 * as2);
        }
        public void div(int as1, int as2)
        {
            this.as1 = as1;
            this.as2 = as2;
            Console.WriteLine("Division of two numbers is {0}", as1 / as2);
        }
    }
    internal class OperatorsTask
    {
        public static void Main()
        {
           
            MulDiv muldiv = new MulDiv();
            muldiv.mul(2, 5);
            muldiv.div(8, 4);
            muldiv.add(10, 6);
            muldiv.sub(15, 7);
        }
    }
}



