using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    class BookingRoom
        // Class that represents a room that is including in a booking 
    {
        #region Data Members
        public int bookingResNumber { get; set; } // To identify the booking that the room is a part of.
        public string hotelRoomId { get; set; } // To identify the details about the room

        public Booking booking { get; set; }
        public HotelRoom room { get; set; }
        #endregion

        #region Constructors 
        public BookingRoom()
        {
            bookingResNumber = 0;
            hotelRoomId = "";
        }
        public BookingRoom(int newBookingNumber, string newRoomId)
        {
            bookingResNumber = newBookingNumber;
            hotelRoomId = newRoomId;
        }
        #endregion
    }
}
