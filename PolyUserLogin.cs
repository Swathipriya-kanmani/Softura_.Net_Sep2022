using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PolyUserLogin
    {
        public void UserLogin(string Email_Id, string Pswd)
        {
            if (Email_Id == "sspriya1206@gmail.com" && Pswd == "Candid@294")
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Mail ID " + Email_Id);
                Console.WriteLine("Enter Password " + Pswd);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Email Id and Password");
            }
        }
        public void UserLogin(int MembershipId, int pin)
        {
            if (MembershipId == 1100 && pin == 1234)
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Membership ID " + MembershipId);
                Console.WriteLine("Enter Pin " + pin);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Membership Id and Pin");
            }

        }
        public void UserLogin(string Mobilenumber, int pin)
        {
            if (Mobilenumber == "7598221421" && pin == 1234)
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Mobile Number " + Mobilenumber);
                Console.WriteLine("Enter Pin " + pin);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Mobile number and Pin");
            }
        }
        public static void Main()
        {
            PolyUserLogin poul = new PolyUserLogin();
            Console.WriteLine("Enter your Login choice");
            Console.WriteLine("Press 1 for EmailID and Password");
            Console.WriteLine("Press 2 for MembershipID and Pin");
            Console.WriteLine("Press 3 for Mobile Number and pin");
            int option = Convert.ToInt32(Console.ReadLine());
            string user_name = "";
            string Pswd = "";
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Your EmailId");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(user_name, Pswd);
                    break;
                case 2:
                    Console.WriteLine("Enter your MembershipId");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your pin");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(Convert.ToInt32(user_name), Convert.ToInt32(Pswd));
                    break;
                case 3:
                    Console.WriteLine("Enter your Mobile Number");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your Pin");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(user_name, Convert.ToInt32(Pswd));
                    break;
            }


        }
    }
}
