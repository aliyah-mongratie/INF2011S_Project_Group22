using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Business
{
    internal class Booking
    {
        #region data members
        //attributes
        public int bookingResNumber { get; set; }//(alphanumeric, 8–12 chars)
        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }
        protected BookingStatus bookingStat;
        public List<HotelRoom> Rooms { get; private set; } = new List<HotelRoom>();
        public string bookingType { get; set; } //Personal or Travel Agency
        public int numOfPeople { get; set; } //max 6
        public int numOfRooms { get; set; } //1–3 rooms
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public string specialRequirements { get; set; }

        // Foreign Keys
        public Guest guest { get; set; }
        public TravelAgent travelAgent { get; set; }
        #endregion
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
            Rooms = new List<HotelRoom>(3); 
            travelAgent = new TravelAgent();    

        }
        public Booking(int newBookResNumber, string newBookingType, int newNumOfPeople, int newNumOfRooms, DateTime newCheckInDate, DateTime newCheckOutDate, string newSpecialRequirements, Guest newGuest, List<HotelRoom> rooms, TravelAgent newTravelAgentID)
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
            Rooms = new List<HotelRoom>();
            travelAgent= newTravelAgentID;
        }

        #endregion

        #region Methods
        public int GetBookingDuration()
        {
            return (checkOutDate - checkInDate).Days;
        }

        public bool CheckRoomAvailability()
        {
            
            
            foreach (var room in Rooms)
            {
                if (room.getRoomStatus != HotelRoom.RoomStatus.Available)
                {
                    return false; // as soon as we find one unavailable room, stop
                }
            }
            return true; // all rooms passed the check
        }

         public void AddRoom(string roomID, int hotelID, )
    {
        Rooms.Add(new HotelRoom());
        MessageBox.Show($"Added Room {roomNumber} ({type})");
        MessageBox.Show($"Count: {Rooms.Count}, Capacity: {Rooms.Capacity}");
    }


        #endregion
    }
}
