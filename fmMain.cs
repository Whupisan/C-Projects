using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Lee Douglas
 * Assignment 5
 * Due Date: April 6, 2017
 */
namespace CISK343_Assignment5_Douglas.Lee
{
    public partial class fmMain : Form
    {
        // Inenumeration: a way of adding the employees to a dynamic list
        List<Employee> EmpList = new List<Employee>();

        public fmMain()
        {
            InitializeComponent();
        }

        private void btnListEmps_Click(object sender, EventArgs e)
        {
            string response = null;     // a container for the employee instance
            foreach (Employee emp in EmpList)   // reviewing the employees in the list
            {
                response += $"{emp}\n";
            }
            // polymorphism at work... do what's right
            MessageBox.Show($"{response}", "Employee Listing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string response = null;     // a container for the employee instance
            foreach (Employee emp in EmpList)   // reviewing the employees in the list
            {
                response += $"{emp.FullName()}'s pay is ${emp.CalcPay():f2}\n"; 
            }
            // polymorphism at work... do what's right
            MessageBox.Show($"{response}", "Pay Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            // Creating Instances of the Employee   
            Employee employee = new Employee("fName", "lName", 4.25, 0);
            EmployeeCommissioned comEmployee = new EmployeeCommissioned("fName", "lName", 0);
            EmployeeSalaried salEmployee = new EmployeeSalaried("fName", "lName", 0);

            // Setting a boolean value as a test
            bool addEmp = false;

            // testing the first name and then the last name 
            try
            {
                // Making sure the first name is correctly inputted
                employee.FirstName = txtFName.Text;
                addEmp = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please be advised: {ex.Message}");
                addEmp = false;
            }
            if (addEmp == true)
            {
                // Making sure the last name is correctly inputted
                try
                {
                    employee.LastName = txtLName.Text;
                    addEmp = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please be advised: {ex.Message}");
                    addEmp = false;
                }
            }
            if (addEmp == true)
            {
                // Getting the hours and rate from text fields
                if (rbtnHourly.Checked == true)
                {
                    //converting from the employee hours field
                    try
                    {
                        employee.Hours = Convert.ToDouble(mskTxtHours.Text);
                        addEmp = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Please be advised: {ex.Message}");
                        addEmp = false;
                    }
                    //converting from the employee hourly rate field
                    try
                    {
                        employee.HourlyRate = Convert.ToDouble(txtHRate.Text);
                        addEmp = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Please be advised: {ex.Message}");
                        addEmp = false;
                    }
                }
                else if (rbtnCommission.Checked == true)
                {
                    //converting from the sales field
                    try
                    {
                        comEmployee.Sales = Convert.ToDouble(mskTxtSales.Text);
                        addEmp = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Please be advised: {ex.Message}");
                        addEmp = false;
                    }
                }
                else
                {
                    //converting from the salary field
                    try
                    {
                        salEmployee.AnnualSalary = Convert.ToDouble(mskTxtSalary.Text);
                        addEmp = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Please be advised: {ex.Message}", "Salary is Incorrect", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        addEmp = false;
                    }
                }
            }
            if (addEmp == true) // Name checked, numbers checked, now adding to List
            {
                if (rbtnCommission.Checked == true)
                {
                    EmpList.Add(new EmployeeCommissioned(employee.FirstName, employee.LastName, comEmployee.Sales));
                }
                else if (rbtnHourly.Checked == true)
                {
                    EmpList.Add(new Employee(employee.FirstName, employee.LastName, employee.HourlyRate, employee.Hours));
                }
                else
                {
                    EmpList.Add(new EmployeeSalaried(employee.FirstName, employee.LastName, salEmployee.AnnualSalary));
                }
            }

            // Enable the buttons
            btnListEmps.Enabled = true;
            btnCalcPay.Enabled = true;

            // Displaying added recipient
            MessageBox.Show($"{employee.FullName()} was added");

            // Clearing the fields for the next entry
            mskTxtSales.Clear();
            mskTxtHours.Clear();
            mskTxtSalary.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtHRate.Clear();
        }

        /*****************************************************************************
        ** When the GUI loads up we have hourly panel by default
        ******************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            gBoxSalary.Visible = false;
            gBoxSales.Visible = false;
            gBoxHourly.Visible = true;

            // Lock the other buttons until the person is added
            btnCalcPay.Enabled = false;
            btnListEmps.Enabled = false;
        }

        private void rbtnCommission_CheckedChanged(object sender, EventArgs e)
        {
            // Switch panel that the user sees
            gBoxSalary.Hide();
            gBoxHourly.Hide();
            gBoxSales.Show();
        }

        private void rbtnHourly_CheckedChanged(object sender, EventArgs e)
        {
            gBoxHourly.Show();
            gBoxSalary.Hide();
            gBoxSales.Hide();
        }

        private void rbtnSalaried_CheckedChanged(object sender, EventArgs e)
        {
            gBoxHourly.Hide();
            gBoxSales.Hide();
            gBoxSalary.Show();
        }

        /*****************************************************************************
        ** Making sure that the user inputs the correct entry type into field
        ******************************************************************************/
        private void txtHRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) // 8 is the backspace key (C# Keys Enumeration)
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only", "Wrong Key!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*****************************************************************************
        ** Another way of validation (short cut)
        ******************************************************************************/
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Making sure that only letters are entered into the field
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 ? false : true;
            if (e.Handled == true)
            {
                MessageBox.Show("Please use letters only here!", "Wrong Key!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Lock the other buttons until the person is added
            btnCalcPay.Enabled = false;
            btnListEmps.Enabled = false;
        }
    }
}
