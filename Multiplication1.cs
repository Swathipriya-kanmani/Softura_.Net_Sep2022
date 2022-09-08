using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Multiplication1
    {
        public static void Main()
        {
           
            Console.WriteLine("Please Enter num Values");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <=20; i++)
            Console.WriteLine(" {0} * {1} = {2} ", num,i, num*i);

        }
    }
}
