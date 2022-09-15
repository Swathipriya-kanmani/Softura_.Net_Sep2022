using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class SalesDept
    {
        public virtual void TotalSalary(double salary)
        {
            double BonusCalc, FinalTotalSalary;
            BonusCalc = (salary * 20) / 100;
            FinalTotalSalary = BonusCalc + salary;
            Console.WriteLine("Salary with Bonus:" + FinalTotalSalary);
        }
    }
    class ProductionDept : SalesDept
    {
        public override void TotalSalary(double salary)
        {
            double BonusCalc, FinalTotalSalary;
            BonusCalc = (salary * 10) / 100;
            FinalTotalSalary = BonusCalc + salary;
            Console.WriteLine("Salary with Bonus:" + FinalTotalSalary);
        }
    }
    internal class BonusCalc
    {
        
        

            public static void Main()
            {
                Console.WriteLine("Enter the Employee ID: ");
                int EId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name: ");
                string EmpName = Console.ReadLine();
                Console.WriteLine("Enter the Employee Gender: ");
                string EmpGender = Console.ReadLine();
                Console.WriteLine("Enter the Employee's Year of Experience:");
                int Empexpe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary");
                double Empsalary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Employee's Department(sales/production)");
                string EmpDepart = Console.ReadLine();

                Console.WriteLine("Employee Details:");

                Console.WriteLine("Id:" + EId);
                Console.WriteLine("Name:" + EmpName);
                Console.WriteLine("Gender:" + EmpGender);
                Console.WriteLine("Year of Experence:" + Empexpe);
                Console.WriteLine("Department:" + EmpDepart);

                if (EmpDepart == "sales")
                {
                    SalesDept salobj = new SalesDept();
                    salobj.TotalSalary(Empsalary);
                }
                else if (EmpDepart == "production")
                {
                    ProductionDept prodobj = new ProductionDept();
                    prodobj.TotalSalary(Empsalary);
                }
                else
                {
                    Console.WriteLine("Enter the valid Department");
                }


            }
        


    }
}
