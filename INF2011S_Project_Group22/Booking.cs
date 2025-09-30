using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class Booking
    {
        //attributes
        private int bookResNumber { get; set; }//(alphanumeric, 8–12 chars)
        private int bookingStatus { get; set; } //Confirmed, Pending, Cancelled
        private string bookingType { get; set; } //Personal or Travel Agency
        private int numOfPeople { get; set; } //max 6
        private int numOfRooms { get; set; } //1–3 rooms
        private DateTime checkInDate { get; set; }
        private DateTime checkOutDate { get; set; }
        private string specialRequirements { get; set; }

        // Foreign Keys
        private int guestID { get; set; }
        private int roomID { get; set; }
        private int travelAgentID { get; set; }

        #region Methods
        public int GetBookingDuration()
        {
            return (checkOutDate - checkInDate).Days;
        }

        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }

        #endregion
    }
}
