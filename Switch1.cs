using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Switch1
    {
        public static void Main()
        {
            Console.WriteLine("Which TV Channel Package ?");
            Console.WriteLine("Choose Package A or Package B or Package C");
            string PackageType = Console.ReadLine();
            switch (PackageType)
            {
                case "Package A":
                    Console.WriteLine("1. South Specail 2. Children's Club 3. Movies, Rate:- 250");
                    break;
                case "Package B ":
                    Console.WriteLine("1. News 2. Sports 3. Movies 4. Regional-2, Rate:- 450");
                    break;
                case "Package C":
                    Console.WriteLine("1. Discovery 2. History 3. National, Rate:- 350");
                    break;
                default:
                    Console.WriteLine("try using Package A or Package B or Package C");
                    break;
            }
        }
    }
}


