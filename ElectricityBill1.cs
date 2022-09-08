using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ElectricityBill1
    {
        public static int calculateBill(int units)
        {
            if (units <= 200)
            {
                return units * 2;
            }
            else if (units > 200 && units <= 350)
            {
                return (200 * 2) +
                       (units - 200) * 3;
            }
            else if (units >= 351 && units <= 500)
            {
                return (200 * 2) +
                       (150 * 3) +
                       (units - 350) * 5;
            }
            else if (units > 500)
            {
                return (200 * 2) +
                       (150 * 3) +
                       (150 * 5) +
                       (units - 500) * 7;
            }
            return 0;
        }

        public static void Main(String[] args)
        {
            
            string cusName;
            int meterId, amt;
            Console.WriteLine("\n\n");
            Console.WriteLine("Generating Electricity Bill : \n\n");
            Console.WriteLine("---------------------------------\n\n");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the Meter Id");
            meterId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer Name: ");
            cusName = Console.ReadLine();
            Console.WriteLine("Enter the amount of unit consumed: ");
            amt = Convert.ToInt32(Console.ReadLine());

            int units = 250;

            Console.WriteLine(calculateBill(units));




        }
            
        
    }
}
