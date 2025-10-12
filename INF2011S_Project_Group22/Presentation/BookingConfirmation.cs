using INF2011S_Project_Group22.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class BookingConfirmation : Form
    {
        //private Booking booking;
        //private int guestbookNo;
        //(guestId, guestCheckIn, guestCheckOut, guestNumRooms, guestRequirements, guestSelectedRooms, guestNumPeople
        public decimal balance; //The total cost of the booking 
        public string guestCardNo;
        public Booking.BookingType bookType { get; set; }
        public string agentId;
        public string bookingGuestId;
        public DateTime bookingCheckIn;
        public DateTime bookingCheckOut;
        public int bookingNumRooms;
        public string bookingRequirements;
        public List<HotelRoom> bookingRooms;
        public int bookingNumPeople;
        public string firstName, lastName, phone, email, agencyName;

        int bookingResNumber = Booking.generateBookingResNumber(); // generate bookingResNumber 

        public BookingConfirmation(string guestFirstName, string guestLastName, string guestPhone, string guestEmail,
            string travAgentId, decimal accountBalance,string cardNo,Booking.BookingType bookingType,
            string guestId, DateTime guestCheckIn, DateTime guestCheckOut,int guestNumRooms,
            string guestRequirements, List<HotelRoom> guestSelectedRooms, int guestNumPeople, string travelAgencyName)
        {

            InitializeComponent();
            //guestbookNo = bookNo
            agencyName = travelAgencyName;
            firstName = guestFirstName;
            lastName = guestLastName;
            phone = guestPhone;
            email = guestEmail;
            balance = accountBalance;
            guestCardNo = cardNo;
            bookType = bookingType;
            bookingGuestId = guestId;
            bookingCheckIn = guestCheckIn;
            bookingCheckOut = guestCheckOut;
            bookingNumRooms = guestNumRooms;
            bookingRooms = guestSelectedRooms;
            bookingRequirements = guestRequirements;
            bookingNumPeople = guestNumPeople;


            if (bookType == Booking.BookingType.TravelAgency) // ensure that the booking is created with an agentId if it was a travel agent booking
            {
                agentId = travAgentId;
            }
            else
            {
                agentId = null; //ensure that booking is created without a travelAgentId if the booking was personal
            }

            if (bookType == Booking.BookingType.TravelAgency)
            {
                bookingGuestId = null; // No guest for travel agent bookings
            }
            else
            {
                bookingGuestId = guestId; // Personal booking has guestId
            }
        }
        private void ConfirmBooking()
        {
            BookingController bookingController = new BookingController();
           

            if (bookType == Booking.BookingType.TravelAgency)
            {
                TravelAgent agent = bookingController.AddAgent(agentId, agencyName, firstName, lastName, phone, email);
            }
            if (bookType == Booking.BookingType.Personal)
            {
                // Only for personal bookings:
                Guest guest = bookingController.AddGuest(bookingGuestId, firstName, lastName, phone, email, guestCardNo);

                decimal charges = 0; // based on service charges that wiil be made once the guest checks into and stays at the hotel
                GuestAccount account = bookingController.AddGuestAccount(
                    bookingGuestId, guestCardNo, balance, charges, bookingCheckIn, bookingCheckOut
                );
                //add payment to the db 
                string payId = Payment.generatePaymentId().ToString();
                Payment payment = bookingController.AddPayment(payId, bookingGuestId, Payment.PaymentStatus.pending, balance);
            }
            

            string hotelId = "PK1";

            string bookingAgentId = (bookType == Booking.BookingType.TravelAgency) ? agentId : null;

            Booking booking = bookingController.MakeBooking(bookingResNumber, bookingGuestId,
                hotelId, bookingAgentId, bookType, bookingNumPeople, bookingNumRooms, bookingCheckIn, bookingCheckOut, bookingRequirements);

            if (booking == null)
            {
                MessageBox.Show("Error: Booking could not be created. Please try again.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<BookingRoom> bookedRooms = bookingController.AddBookingRoom(bookingResNumber, bookingRooms);

            lblBookingReservation.Text = "The Booking Reservation Number is: " + bookingResNumber; //Display booking reservation reference number 

           
           
        }

        private void BookingConfirmation_Load(object sender, EventArgs e)
        {
           
            ConfirmBooking();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
