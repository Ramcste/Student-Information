using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentInformation : Form
    {

        private string regNo;
        private string firstName;
        private string lastName;

        public StudentInformation()
        {
            InitializeComponent();
        }


        private void showStudentInformationButton_Click(object sender, EventArgs e)
        {
            regNo = regNoTextBox.Text;
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;

            MessageBox.Show("\nYour Registration Number is: "+regNo
                              +"\nFirs Name: "+firstName
                              +"\nLast Name: "+lastName);

            regNoTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";

        }

        private void retrieveStudentInformationButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = regNo;
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }

        private void clearStudentInformationButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            regNo = "";
            firstName = "";
            lastName = "";

           
        }

        
    }
}
