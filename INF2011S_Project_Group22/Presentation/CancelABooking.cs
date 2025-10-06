using INF2011S_Project_Group22.Business;
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
            //Can you guys see this comment? @Aliyah
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBookingDetailsValidation()
        {
            //This method will validate the input fields for cancelling a booking
            //It will check if the fields are empty, if they contain invalid characters, and if they exceed the maximum length
            //Once bookingController is done, we will use the first name, last name and booking number to find the booking in the database and cancel/delete it.
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
            if (string.IsNullOrWhiteSpace(txtEnterResNumber.Text))
            {
                MessageBox.Show("Booking Number is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtEnterResNumber.Text, out int bookingNumber)) // out int bookingNumber will store the parsed integer if successful, the out keyword allows the method to return this value.
            {
                MessageBox.Show("Booking Number must contain digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bookingNumber <= 0)
            {
                MessageBox.Show("Booking Number must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmBookingCancellation newBookingCancellation = new frmBookingCancellation();
            newBookingCancellation.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CancelBookingDetailsValidation();

            //Cancelling and deleting the booking from the database 

            BookingController bookingController = new BookingController();
            Booking booking = new Booking(); //instantiate a booking object so that we can use the bookingResNumber property
            //cancel a booking method
            bookingController.CancelBooking(booking.bookingResNumber);




        }

        private void frmCancelABooking_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
