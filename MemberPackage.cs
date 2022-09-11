using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class MemPack
    {
        public abstract void PackageBenefits();

    }
    class SilverPack : MemPack
    {

        public override void PackageBenefits()
        {
            Console.WriteLine("Sliver Membership Package Benefits: Your have 3 days accomodation at Resort");
        }
    }
    class GoldPack : MemPack
    {

        public override void PackageBenefits()
        {
            Console.WriteLine("Gold Membership Package Benefits:5 days accomodation at Resort & 2 Dinners on the house");
        }
    }
    class PlatinumPack : MemPack
    {

        public override void PackageBenefits()
        {
            Console.WriteLine("Platinum Membership Package Benefits: You have 7 days accomodation at Resort & 5 Dinners on the house");

        }
    }


    internal class MemberPackage
    {
        public static void Main()
        {
            SilverPack sil = new SilverPack();
            GoldPack gol = new GoldPack();
            PlatinumPack pla = new PlatinumPack();
            sil.PackageBenefits();
            gol.PackageBenefits();
            pla.PackageBenefits();

        }
    }
}
