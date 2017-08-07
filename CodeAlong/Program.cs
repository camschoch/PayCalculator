using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            payCalculator runCalculator = new payCalculator();
            runCalculator.hoursWorked = runCalculator.getHoursWorked();
            runCalculator.payRate = runCalculator.getPayRate();
            runCalculator.getTotalPay(runCalculator.hoursWorked, runCalculator.payRate);

        }
    }
}
