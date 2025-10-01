using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        #region Methoods 
       /* public Booking MakeBooking(int bookResNumber, Guest guest, string bookingType,int numOfPeople, int numOfRooms, 
                        DateTime checkInDate, DateTime checkOutDate, string specialRequirements)
        {
            if(numOfPeople > 6)
            {
                MessageBox.Show("The number of people for a booking cannot exceed 6.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            if(numOfRooms < 1 || numOfRooms >3)
            {
                MessageBox.Show("The number of rooms for a booking must be between 1 and 3.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 4 people in a room? 

            if(checkInDate >= checkOutDate)
            {
                MessageBox.Show("The check in date must be before the check out date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Booking booking = new Booking(bookResNumber, guest, bookingType, numOfPeople, numOfRooms, checkInDate, checkOutDate, specialRequirements);
            bookings.Add(booking);
            return booking;
        } */
        #endregion
    }
}
