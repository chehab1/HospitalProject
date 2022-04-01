using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
      class Tech:Staff
    {
      

        private double rate = 10;
        public override double CalculateSalary(double x)
        {
            return rate * x;
        }
        public override double CalculateVacationDays(double x)
        {
            double m = x / 10;
                days += m*7;
            return days;
        }

    }
}
