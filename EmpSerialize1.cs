using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    public class Employ
    {
        public int EmplId { get; set; }
        public string EmplName { get; set; }
        public string EmplGender { get; set; }
        public int EmplAge { get; set; }
    }
    internal class EmpSerialize1
    {
        public static void Main()
        {
            Employ empe = new Employ()
            {
                EmplId = 62,
                EmplName = "Priya",
                EmplGender = "Female",
                EmplAge = 22

            };
            var serialize = new XmlSerializer(typeof(Employ));
            using (StreamWriter stream = new StreamWriter("Employee.xml"))
            {
                serialize.Serialize(stream, empe);
            }
            Console.WriteLine("EMPId:{0} \n EMPName:{1} \n EMPAge:{2} \n EMPGender={3}", empe.EmplId, empe.EmplName, empe.EmplAge, empe.EmplGender);
        }
    }
}


