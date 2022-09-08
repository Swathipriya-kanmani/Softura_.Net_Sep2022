using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Agecount1
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i= 0; i<age; i++)
            {
                Console.WriteLine(name);
            }

        }
    }
}
