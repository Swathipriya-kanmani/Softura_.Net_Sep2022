using System.Xml.Linq;
using System.Collections;

namespace EmployeeApp.Models
{
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Gender { get; set; }



        public static EmployeeDetails GetSingleEmployeeInfo()
        {
            EmployeeDetails employee = new()
            {


                id = 1,
                firstname = "Divya",
                lastname = "Bharathi",
                Gender = "Female"
            };


            return employee;
        }



        public static List<EmployeeDetails> GetAllEmployeeInfo()
        {


            List<EmployeeDetails> employees = new() {
                
                new EmployeeDetails { id = 2, firstname = "Deepika", lastname = "Padukone", Gender = "Female" },
                new EmployeeDetails { id = 3, firstname = "Swathi", lastname = "Priya", Gender = "Female" },
                new EmployeeDetails { id = 4, firstname = "Bharathi", lastname = "Raja", Gender = "Male" },
                new EmployeeDetails { id = 5, firstname = "Hanuman", lastname = "Kesari", Gender = "Male" }

            };
            return employees;

        }
    }
}
