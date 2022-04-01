using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Doctor :Staff
    {
        public Doctor() { }
      
        private double rate = 20;
        

        public override double CalculateSalary(double x)
        {
            salary = rate * x;
            return salary;
        }
        public override sealed double CalculateVacationDays(double x)
        {
            double m= x / 100;
                days+= m* 10;
            return days;
        }
        Surgery[] surgery_arr = new Surgery[10];
        public void ScheduleSurgery()
        {
            int i;
            for( i=0 ;i<surgery_arr.Length;i++)
            {
                if (surgery_arr[i].price == 0)
                    break;
            }
            
        }
    }
}
