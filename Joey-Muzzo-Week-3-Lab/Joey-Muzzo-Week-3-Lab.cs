using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joey_Muzzo_Week_3_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoursWorked;
            double HourlyRate, GrossPay, NetPay, RegularPay = 0.0, OverTimePay = 0.0, TaxRate = 0.0;
            String Status; // single, Married, Divorced, Widowed
            Console.Write("Enter the Hourly Rate: ");

            HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Hours Worked: ");

            HoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter letter  for (M)arried, (S)ingle, (D)ivorced, (W)idowed : ");
            //get user input from the console

            Status = Console.ReadLine();
            //check user input for status
            if (Status == "M")
            {
                TaxRate = .15;
            }
            else if (Status == "S")
            {
                TaxRate = .22;
            }
            else if (Status == "D")
            {
                TaxRate = .23;
            }
            else if (Status == "W")
            {
                TaxRate = .13;
            }
            //add in logic for overtime vs non-overtime
            if (HoursWorked > 40)
            {//the person worked overtime
                int OverTime;
                OverTime = HoursWorked - 40;
                OverTimePay = OverTime * (HourlyRate * 1.5);
                RegularPay = 40 * HourlyRate;
            }

            else
            {

                RegularPay = HoursWorked * HourlyRate;
            }
                if (HoursWorked > 40)
            {
                Console.WriteLine("Regular Pay is: {0}", RegularPay);
                Console.WriteLine("Overtime Pay is: {0}", OverTimePay);
            }

            GrossPay = RegularPay + OverTimePay;
            //Final output
            NetPay = GrossPay - (TaxRate * GrossPay);
            Console.WriteLine("Gross Pay: {0}", GrossPay);

            Console.WriteLine("Net Pay: {0}", NetPay);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}