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
        public BookingConfirmation()
        {
            InitializeComponent();
            Booking booking = new Booking();

            int bookingResNumber = booking.bookingResNumber;

            //string BookingReservationNumber =;//get booking reservation number from database once bookingController is done
            lblBookingReservation.Text= "$The Booking Reservation Number is: {booking.bookingResNumber}" //add the booking reservation number here
            ;
        }

        private void BookingConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
