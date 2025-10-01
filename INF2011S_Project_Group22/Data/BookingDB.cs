using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2011S_Project_Group22.Business;

namespace INF2011S_Project_Group22.Data
{
    class BookingDB : DB
    {
        #region  Data members        
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";
        private string table2 = "BookingRoom";
        private string sqlLocal2 = "SELECT * FROM BookingRoom";
        
        private Collection<Booking> bookings;

        #endregion
        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion
        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
           
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Booking booking;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    booking = new Booking(); // instantiate new booking object 
                    booking.bookingResNumber = Convert.ToInt32(myRow["BookingResNumber"]);
                    booking.guest.guestID = Convert.ToString(myRow["GuestId"]).TrimEnd();
                    booking.travelAgent.TravelAgentId = Convert.ToString(myRow["TravelAgentId"]).TrimEnd();
                    booking.bookingStat = (Booking.BookingStatus)Convert.ToByte(myRow["BookingStatus"]);
                    booking.bookingType = (Booking.BookingType)Convert.ToByte(myRow["BookingType"]);
                    booking.numOfPeople = Convert.ToInt32(myRow["numOfPeople"]);
                    booking.numOfRooms = Convert.ToInt32(myRow["numOfRooms"]);
                    booking.checkInDate = Convert.ToDateTime(myRow["CheckInDate"]);
                    booking.checkOutDate = Convert.ToDateTime(myRow["CheckOutDate"]);
                    booking.specialRequirements = Convert.ToString(myRow["SpecialRequirements"]).TrimEnd();

                }
            }
        }
        #endregion
    }
}

