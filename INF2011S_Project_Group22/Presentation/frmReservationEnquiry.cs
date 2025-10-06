using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class frmReservationEnquiry : Form
    {
        public frmReservationEnquiry()
        {
            InitializeComponent();
        }

        private void ReservationEnquiryDetails()
        {
            //This method will validate the input fields for reservation enquiry
            //It will check if the fields are empty, if they contain invalid characters, and if they exceed the maximum length
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            //Validation for First Name and Last Name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Fist Name and Last Name are required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("First and Last Name cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstName.Length > 50 || lastName.Length > 50)
            {
                MessageBox.Show("First Name and Last Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validation for Booking Number
            if (string.IsNullOrWhiteSpace(txtResNumber.Text))
            {
                MessageBox.Show("Booking Number is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtResNumber.Text, out int bookingNumber)) // out int bookingNumber will store the parsed integer if successful, the out keyword allows the method to return this value.
            {
                MessageBox.Show("Booking Number must contain digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtResNumber.Text.Length > 10)
            {
                MessageBox.Show("Booking Number cannot exceed 10 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtResNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReservationEnquiryDetails();
            ReservationDetails newViewReservationDetails = new ReservationDetails();
            newViewReservationDetails.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
