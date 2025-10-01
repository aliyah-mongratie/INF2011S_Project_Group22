using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /*public Booking MakeBooking(int bookResNumber, Guest guest, string bookingType,int numOfPeople, int numOfRooms, 
                        DateTime checkInDate, DateTime checkOutDate, string specialRequirements)
        {

        }*/
        #endregion
    }
}
