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
        
        public string bookingGuestId;
        public DateTime bookingCheckIn;
        public DateTime bookingCheckOut;
        public int bookingNumRooms;
        public string bookingRequirements;
        public List<HotelRoom> bookingRooms;
        public int bookingNumPeople;

        public BookingConfirmation(decimal accountBalance,string cardNo,Booking.BookingType bookingType,string guestId, DateTime guestCheckIn, DateTime guestCheckOut,int guestNumRooms, string guestRequirements, List<HotelRoom> guestSelectedRooms, int guestNumPeople, string agencyName = null)
        {

            InitializeComponent();
            //guestbookNo = bookNo;
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

            //generates travel agent id uding the agency name passed from the creat reservation form
            if (!string.IsNullOrEmpty(agencyName))
            {
                string travelAgentId = TravelAgent.generateAgentId(agencyName);
               
            }

        }
        private void ConfirmBooking()
        {

            BookingController bookingController = new BookingController();
            //Call the MakeBooking method from the BookingController class to create a new booking
            int bookingResNumber = Booking.generateBookingResNumber(); // generate bookingResNumber 

            string hotelId = "PK1"; // Phumla Kamnandi Hotel 1. Our system database is based off of one hotel 

            // add the booking to the database using the MakeBooking() method
             Booking booking = bookingController.MakeBooking(bookingResNumber,bookingGuestId,
                 hotelId, bookType, bookingNumPeople,bookingNumRooms,bookingCheckIn,bookingCheckOut,bookingRequirements
                 );
              //display an error when the booking is details are empty
              if (booking == null)
              {
                  MessageBox.Show("Error: Booking could not be created. Please try again.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
              }

              // add each selected room to the BookingRoom table and link it to the bookingResNumber by using the AddBookingRoom method
            List<BookingRoom> bookedRooms = bookingController.AddBookingRoom(bookingResNumber, bookingRooms);

            lblBookingReservation.Text = "The Booking Reservation Number is: " + bookingResNumber; //add the booking reservation number here

            decimal charges = 0; // Account charges are the incurred costs charged over the time of stay in the hotel room after the booking is made. This means it is out of scope for now
            GuestAccount Account = bookingController.AddGuestAccount(bookingGuestId, guestCardNo, balance, charges, bookingCheckIn, bookingCheckOut);
            
        }
        private void BookingConfirmation_Load(object sender, EventArgs e)
        {
           
            ConfirmBooking();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
