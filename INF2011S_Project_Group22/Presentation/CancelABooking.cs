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
    public partial class frmCancelABooking : Form
    {
        public frmCancelABooking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            frmBookingCancellation newBookingCancellation = new frmBookingCancellation();
            newBookingCancellation.ShowDialog();

            //Validation for First Name and Last Name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Fist Name and Last Name are required fields.","Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("First and Last Name cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (firstName.Length > 50 || lastName.Length > 50)
            {
                MessageBox.Show("First Name and Last Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Validation for Booking Number
            if (string.IsNullOrWhiteSpace(txtEnterResNumber.Text))
            {
                MessageBox.Show("Booking Number is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!int.TryParse(txtEnterResNumber.Text, out int bookingNumber)) // out int bookingNumber will store the parsed integer if successful, the out keyword allows the method to return this value.
            {
                MessageBox.Show("Booking Number must contain digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (bookingNumber <= 0)
            {
                MessageBox.Show("Booking Number must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCancelABooking_Load(object sender, EventArgs e)
        {

        }
    }
}
