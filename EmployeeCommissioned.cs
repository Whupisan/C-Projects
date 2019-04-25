using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Lee Douglas
 * Assignment 5
 * Due Date: April 6, 2017
 */

namespace CISK343_Assignment5_Douglas.Lee
{
    class EmployeeCommissioned:Employee
    {
        private const double COMMISSION_RATE = 0.08;
        private double pfvSales;

        // Constructor (inheriting from the Employee class)
        public EmployeeCommissioned(string firstName, string lastName, double sales): base(firstName, lastName, hourlyRate, hours)
        {
            Sales = sales;
        }
        
        // Properties
        public double Sales
        {
            get
            {
                return pfvSales;
            }
            set
            {
                if (value > 0)
                {
                    pfvSales = value;
                }
            }
        }
        public override double HourlyRate    // override because this class needs the hourly rate
        {
            get
            {
                return 0;
            }
        }
        public override double Hours    // override because this class needs the hours worked
        {
            get
            {
                return 0;
            }
        }
        
        // Methods
        public override double CalcPay()
        {
            return base.CalcPay() + (pfvSales * COMMISSION_RATE);
        }

        // Method to override the ToString method
        public override string ToString()
        {
            return ($"Type: Commisson\tID: {EmpID}\tName: {pfvFirstName} {pfvLastName}");
        }
    }
}
