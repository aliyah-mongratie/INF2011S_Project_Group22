using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class Booking
    {
        //attributes
        private int bookingResNumber { get; set; }//(alphanumeric, 8–12 chars)
        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }
        protected BookingStatus bookingStat;
        private string bookingType { get; set; } //Personal or Travel Agency
        private int numOfPeople { get; set; } //max 6
        private int numOfRooms { get; set; } //1–3 rooms
        private DateTime checkInDate { get; set; }
        private DateTime checkOutDate { get; set; }
        private string specialRequirements { get; set; }

        // Foreign Keys
        private Guest guest{ get; set; }
        private HotelRoom room{ get; set; }
        private TravelAgent travelAgent { get; set; }

        #region Constructors
        public Booking()
        {
            bookingResNumber = 0;
            bookingStat = BookingStatus.Pending;
            numOfPeople = 0;
            numOfRooms = 0;
            checkInDate = DateTime.Now;
            checkOutDate = DateTime.Today.AddDays(1);
            specialRequirements = " ";
            guest = new Guest();
            room = new HotelRoom(); 
            travelAgent = new TravelAgent();    

        }
        public Booking(int newBookResNumber, string newBookingType, int newNumOfPeople, int newNumOfRooms, DateTime newCheckInDate, DateTime newCheckOutDate, string newSpecialRequirements, Guest newGuest, HotelRoom newRoomID, TravelAgent newTravelAgentID)
        {
            bookingResNumber = newBookResNumber;
            bookingStat = Booking.BookingStatus.Pending;
            bookingType = newBookingType;
            numOfPeople = newNumOfPeople;
            numOfRooms = newNumOfRooms;
            checkInDate = newCheckInDate;
            checkOutDate = newCheckOutDate;
            specialRequirements = newSpecialRequirements;
            guest = newGuest;
            room = newRoomID;
            travelAgent= newTravelAgentID;
        }

        #endregion

        #region Methods
        public int GetBookingDuration()
        {
            return (checkOutDate - checkInDate).Days;
        }

       
      

        #endregion
    }
}
