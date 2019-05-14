using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/********************************************************************
* Name: Lee Douglas
* Assignment 6
* Due Date: April 20, 2017
**********************************************************************/

namespace CISK343_Assignment6_Douglas.Lee
{
    public partial class fmAbout : Form
    {
        public fmAbout()
        {
            InitializeComponent();
        }
        // Field Variables 
        private int pfvWordsSearched;

        // This was included due to the UML, but the code was cleaner using the PassMessage property
        // If a future augmentation is needed the field variable and properties are ready
        public int WordsSearched
        {
            get
            {
                return pfvWordsSearched;
            }
            set
            {
                if (value.ToString().Length > 0)
                {
                    pfvWordsSearched = value;
                }
            }
        }

        // Receiving the value (of the number of words) from the main form
        public string PassMessage
        {
            get
            {
                return lblWordCount.Text;
            }
            set
            {
                lblWordCount.Text = value;
            }
        }

        private void fmAbout_Load(object sender, EventArgs e)
        {
          
        }

        // Closing the form
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
