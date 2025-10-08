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
    public partial class BookingConfirmation : Form
    {

        private Booking booking;
        private int guestbookNo;
        public BookingConfirmation(int bookNo)
        {
            InitializeComponent();
            guestbookNo = bookNo;

            //booking = existingBooking; chat said just have this in constructor
            BookingController bookingController = new BookingController();
            Booking booking = new Booking(); //instantiate a booking object so that we can use the bookingResNumber property

            //int bookingResNumber = Booking.generateBookingResNumber(); //generate a booking reservation number
            lblBookingReservation.Text= "The Booking Reservation Number is: " + bookNo; //add the booking reservation number here


            
            
        }
      

        private void BookingConfirmation_Load(object sender, EventArgs e)
        {
            if (booking == null)
            {
                lblBookingReservation.Text = "Error: No booking information received.";
                return;
            }
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
