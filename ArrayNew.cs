using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class ArrayNew
    {
       public static void Main()
        {
            int[] sub = new int[5] {98, 87, 75, 54, 65} ;
            int tot = sub[0] + sub[1] + sub[2] + sub[3] + sub[4];
            Console.WriteLine(tot);
            int per = tot/5;
            Console.WriteLine(per);
            
        }
    }
}



