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
    class EmployeeSalaried : Employee
    {
        // Constants
        private const int divider = 12;
        private const int MIN_SALARY = 18000;

        // Private Field Variables
        private double pfvAnnualSalary;

        // Constructor (inheriting from the Employee class)
        public EmployeeSalaried(string firstName, string lastName, double salary) : base(firstName, lastName, 0, 0)
        {
            AnnualSalary = salary;
        }
        
        // Properties
        public double AnnualSalary
        {
            get
            {
                return pfvAnnualSalary;
            }
            set
            {
                if (value > MIN_SALARY)
                {
                    pfvAnnualSalary = value;
                }
            }
        }
        public new double HourlyRate    // new blows up this property because...
        {
            get
            {
                return 0;
            }
        }
        public new double Hours    // ...they are not needed with a salaried employee
        {
            get
            {
                return 0;
            }
        }

        // Methods
        public override double CalcPay()
        {
            return pfvAnnualSalary / divider;
        }

        // Method to override the ToString method
        public override string ToString()
        {
            return string.Format($"Type: Salaried\tID: {pfvEmpID}\tName: {pfvFirstName} {pfvLastName}");
        }
    }
}
