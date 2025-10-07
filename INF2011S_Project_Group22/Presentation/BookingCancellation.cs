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
using System.Data.SqlClient;


namespace INF2011S_Project_Group22.Presentation
{
    public partial class frmBookingCancellation : Form
    {
        public frmBookingCancellation()
        {
            InitializeComponent();


           
            Booking booking = new Booking(); //instantiate a booking object so that we can use the bookingResNumber property

            int bookingResNumber = booking.bookingResNumber;

            //get bookingReservationNumber from database once bookingController is done

            lblBookingNumberRemoved.Text = "The Booking Reservation Number is: $"+bookingResNumber; //add the booking reservation number here

            

        }

        private void lblBookingNumberRemoved_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmBookingCancellation_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
