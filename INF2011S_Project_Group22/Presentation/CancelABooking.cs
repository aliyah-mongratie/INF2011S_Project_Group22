using INF2011S_Project_Group22.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            lblFNameError.Visible = false;
            lblLNameError.Visible = false;
            lblBookingResError.Visible = false;

            txtFirstName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CancelBookingDetailsValidation()
        {
            //This method will validate the input fields for cancelling a booking
            //It will check if the fields are empty, if they contain invalid characters, and if they exceed the maximum length
            //Once bookingController is done, we will use the first name, last name and booking number to find the booking in the database and cancel/delete it.
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            BookingController bookingController = new BookingController();
            Booking booking = new Booking(); //instantiate a booking object so that we can use the bookingResNumber property

            int bookingResNumber = booking.bookingResNumber;


            //Validation for First Name and Last Name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName))
            {
                lblFNameError.Text = "First Name is a required field.";
                lblFNameError.Visible = true;

                lblLNameError.Text = "Last Name is a required field.";
                lblLNameError.Visible = true;


            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                
                lblFNameError.Text = "First Name cannot contain numbers";
                lblFNameError.Visible = true;

               
                lblLNameError.Text = "Last Name cannot contain numbers";
                lblLNameError.Visible = true;
            }
            if (firstName.Length > 50 || lastName.Length > 50)
            {
                lblFNameError.Text = "First Name cannot exceed 50 characters";
                lblFNameError.Visible = true;


                lblLNameError.Text = "Last Name cannot cannot exceed 50 characters";
                lblLNameError.Visible = true;
            }

            //Validation for Booking Number
            if (string.IsNullOrEmpty(txtEnterResNumber.Text))
            {
                lblBookingResError.Text = "Booking Reservation Number is a required field.";
                lblBookingResError.Visible = true;
            }
            if (!int.TryParse(txtEnterResNumber.Text, out int bookingNumber)) // out int bookingNumber will store the parsed integer if successful, the out keyword allows the method to return this value.
            {
                lblBookingResError.Text = "Booking Reservation Number must be a valid number.";
                lblBookingResError.Visible = true;
            }
            if (bookingNumber <= 0)
            {
                lblBookingResError.Text = "Booking Reservation Number must be a positive number.";
                lblBookingResError.Visible = true;

            }
            if (txtEnterResNumber.Text.Length > 6)
            {
                lblBookingResError.Text = "Booking Reservation Number cannot exceed 6 digits.";
                lblBookingResError.Visible = true;
            }
            //Add a method to validate if the booking number, booking and guest even exists in the database.

            return false;
            
        }





        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (!CancelBookingDetailsValidation())
            {
                return; // If validation fails, exit the method
            }

            //Add the method to actually cancel the booking in the database using the bookingController.
            frmBookingCancellation bookingCancellationForm = new frmBookingCancellation();
            bookingCancellationForm.ShowDialog();














        }

        private void frmCancelABooking_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
