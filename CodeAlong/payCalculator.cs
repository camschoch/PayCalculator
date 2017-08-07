using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    class payCalculator
    {
        public double hoursWorked;
        public double payRate;
        public double totalPay;
        public double getHoursWorked()
        {
            Console.WriteLine("please enter youre hours worked.");
            hoursWorked = double.Parse(Console.ReadLine());
            return hoursWorked;
        }
        public double getPayRate()
        {
            Console.WriteLine("please enter your pay rate");
            payRate = double.Parse(Console.ReadLine());
            return payRate;
        }
        public void getTotalPay(double hoursWorked, double payRate)
        {
            totalPay = payRate * hoursWorked;
            Console.WriteLine("Your totla pay: " + totalPay);
            Console.ReadLine();
        }
    }
}
