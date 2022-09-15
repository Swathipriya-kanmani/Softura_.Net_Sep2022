using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        
        public string PerName { get; set; }
        public int PerAge { get; set; }

        public void Display(string PerName, int PerAge)
        {
            Console.WriteLine(" Name of the Person {0} And Age of the Person {1}", PerName, PerAge);
            
        }
        public static void Main()
        {
            Person per = new Person()
            {
                PerName = "Priya",
                PerAge = 22
            };

            Console.WriteLine(" Name of the Person {0} And Age of the Person {1} ", per.PerName, per.PerAge);
            per.Display("Priya", 22);
            
        }
    }
}
