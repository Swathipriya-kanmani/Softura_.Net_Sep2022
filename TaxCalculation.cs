using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vat
    {
 
        public void calculateTax(double NetAmount)
        {

            double VatTaxValue = (NetAmount * 0.20);
            Console.WriteLine("The VAT Amount is: " + VatTaxValue);

        }
    }
    class Gst: Vat
    {
        public new void calculateTax(double NetAmount)
        {

            double GstTaxValue = (NetAmount * 0.12);
            Console.WriteLine("The GST Amount is:" + GstTaxValue);
        }
    }
    internal class TaxCalculation
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Net Amount");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Vat vatobj = new Gst();
            vatobj.calculateTax(Amount);
            Gst gstobj = new Gst();
            gstobj.calculateTax(Amount);
       
        }
    }
}
