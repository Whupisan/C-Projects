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
    class Employee
    {
        // Constants
        private const double OT_HOURS_AFTER = 40.1;
        private const double OT_MULTIPLIER = 1.5;
        public const double MAX_HOURLY_RATE = 20;
        public const double MAX_HOURS = 80;
        public const double MIN_HOURLY_RATE = 8.25;

        // Private Field Variables
        private int empCount;
        private double pfvHours;
        private double pfvHourlyRate;
        protected int pfvEmpID;
        protected string pfvFirstName;
        protected string pfvLastName;

        // Constructor
        public Employee(string firstName, string lastName, double hourlyRate, double hours)
        {

            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
            Hours = hours;
            empCount++;     // iterated and linked to the EmpID field variable
        }

        // Properties of the Private Field Variables
        public int EmpID
        {
            get
            {
                pfvEmpID = empCount;
                return empCount;
            }
        }
        public string FirstName
        {
            get
            {
                return pfvFirstName;
            }
            set
            {
                if (value != null)
                {
                    pfvFirstName = value;
                }
                else
                {
                    throw new ApplicationException($"Name must not be blank");
                }
            }
        }
        public string LastName
        {
            get
            {
                return pfvLastName;
            }
            set
            {
                if (value != null)
                {
                    pfvLastName = value;
                }
                else
                {
                    throw new ApplicationException($"Name must not be blank.");
                }
            }
        }
        public virtual double Hours
        {
            get
            {
                return pfvHours;
            }
            set
            {
                if (value >= 0)
                {
                    pfvHours = value;
                }
                else
                {
                    throw new ApplicationException($"Hours must not be positive.");
                }
            }
        }
        public virtual double HourlyRate
        {
            get
            {
                return pfvHourlyRate;
            }
            set
            {
                if (value > 0)
                {
                    pfvHourlyRate = value;
                }
                else
                {
                    //throw new ApplicationException($"The worker's rate must be positive.");
                }
            }
        }

        // Methods
        // Calculating the hourly pay
        public virtual double CalcPay()
        {
            return pfvHours * pfvHourlyRate;
        }

        // Method to print the full name of the Employee
        public string FullName()
        {
            return $"{ pfvFirstName} {pfvLastName}";
        }

        // Method to override the ToString method
        public override string ToString()
        {
            return ($"Type: Hourly\tID: {EmpID}\tName: {pfvFirstName} {pfvLastName}"); 
        }
    }
}
