using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class RestaurantCollection
    {
        public static void Main()
        {
            List<string> li = new List<string>();
            li.Add("Vadai");
            li.Add("Poori");
            li.Add("Masal Dosai");
            li.Add("Idiyappam");
            li.Add("Pongal");

            FileStream fst = new FileStream("E:\\Softura - Training\\ConsoleApp6\\ConsoleApp6\\NewSample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fst);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            foreach (string i in li)
                sw.WriteLine(i);
            sw.Flush();
            fst.Close();

            FileStream fst1 = new FileStream("E:\\Softura - Training\\ConsoleApp6\\ConsoleApp6\\NewSample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fst1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fst1.Close();

            FileInfo fio = new FileInfo("E:\\Softura - Training\\ConsoleApp6\\ConsoleApp6\\NewSample.txt");
            Console.WriteLine("File Creation Time : " + fio.CreationTime);
            Console.WriteLine("Length of file: " + fio.Length);



        }
    }
}
