using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class InterfaceMem : PackageBenefits
    {
        public void SilverPack()
        {
            Console.WriteLine("Sliver Membership Package Benefits: Your have 3 days accomodation at Resort");
        }

        public void GoldPack()
        {
            Console.WriteLine("Gold Membership Package Benefits:5 days accomodation at Resort & 2 Dinners on the house");
        }
        public void PlatinumPack()
        {
            Console.WriteLine("Platinum Membership Package Benefits: You have 7 days accomodation at Resort & 5 Dinners on the house");
        }

    }
    internal class MembershipInterface
    {
        public static void Main()
        {
            InterfaceMem intmem = new InterfaceMem();
            intmem.SilverPack();
            intmem.GoldPack();
            intmem.PlatinumPack();

        }
    }
}
