using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Business
{
    class BookingController //aliyah 
    {
        #region Data Members 
        Collection<Booking> bookings;
        #endregion

        #region Property methods 
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }
        #endregion

        #region Constructor
        //added when DB classes are added 
        #endregion

        #region Methods 
        public Booking Find(int bookingResNumber)
        {
            int index = 0;
            bool found = (bookings[index].bookingResNumber == bookingResNumber);
            int count = bookings.Count;

            while (!(found) && (index < bookings.Count - 1))
            {
                index++;
                found = (bookings[index].bookingResNumber == bookingResNumber);
            }
            return bookings[index];
        }
        public Booking MakeBooking(int bookingResNumber, Guest guest, List<HotelRoom> rooms, TravelAgent travelAgent, string bookingType, int numOfPeople, int numOfRooms,
                        DateTime checkInDate, DateTime checkOutDate, string specialRequirements)
        {


            if (numOfPeople > 6)
            {
                MessageBox.Show("The number of people for a booking cannot exceed 6.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (numOfRooms < 1 || numOfRooms > 3)
            {
                MessageBox.Show("The number of rooms for a booking must be between 1 and 3.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 4 people in a room? 

            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("The check in date must be before the check out date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // check if all rooms statuses are  RoomStatus.available before making boooking 

            Booking booking = new Booking(bookingResNumber, bookingType, numOfPeople, numOfRooms, checkInDate, checkOutDate, specialRequirements, guest, rooms, travelAgent);
            bookings.Add(booking);
            return booking;
        }

        public void ChangeBooking(int bookingResNumber, int newNumOfPeople, int newNumOfRooms,
                        DateTime newCheckInDate, DateTime newCheckOutDate, string newSpecialRequirements)
        {
            Booking booking = Find(bookingResNumber);
            if (booking == null)
            {
                MessageBox.Show("The booking cannot be found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newNumOfPeople > 6)
            {
                MessageBox.Show("The number of people for a booking cannot exceed 6.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (newNumOfRooms < 1 || newNumOfRooms > 3)
            {
                MessageBox.Show("The number of rooms for a booking must be between 1 and 3.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 4 people in a room? 

            if (newCheckInDate >= newCheckOutDate)
            {
                MessageBox.Show("The check in date must be before the check out date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            booking.checkInDate = newCheckInDate;
            booking.checkOutDate = newCheckOutDate;
            booking.numOfRooms = newNumOfRooms;
            booking.numOfPeople = newNumOfPeople;
            booking.specialRequirements = newSpecialRequirements;


        }

        public void CancelBooking(int bookingResNumber)
        {
            Booking booking = Find(bookingResNumber);
            if (booking == null)
            {
                MessageBox.Show("The booking cannot be found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            booking.bookingStat = Booking.BookingStatus.Cancelled;

        }
        public Booking EnquireBooking(int bookingResNumber)
        {
            return Find(bookingResNumber);
        }
        public void ConfirmBooking(int bookingResNumber)
        {
            Booking booking = Find(bookingResNumber);
            if (booking == null)
            {
                MessageBox.Show("The booking cannot be found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            booking.bookingStat = Booking.BookingStatus.Confirmed;
        }
        #endregion
    }
}
