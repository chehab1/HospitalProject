using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
      class Nurse:Staff

    {
        
        private double rate = 15;
        public override double CalculateSalary(double x)
        {
            return rate * x;
        }
        public override double CalculateVacationDays(double x)
        {
            double m = x / 100;
            
                days += m* 7;
                
            
            return days; 
        }
    }
}
