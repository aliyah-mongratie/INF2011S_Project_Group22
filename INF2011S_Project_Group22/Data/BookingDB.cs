using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2011S_Project_Group22.Business;
using static INF2011S_Project_Group22.HotelRoom;

namespace INF2011S_Project_Group22.Data
{
    class BookingDB : DB
    {
        #region  Data members        
        private string tableBooking = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private string tableBookingRoom = "BookingRoom";
        private string sqlLocal2 = "SELECT * FROM BookingRoom";

        private string tableRoom = "HotelRoom";
        private string sqlLocal3 = "SELECT * FROM HotelRoom";

        private string tableGuest = "Guest";
        private string sqlLocal4 = "SELECT * FROM Guest";

        private string tableAccount = "GuestAccount";
        private string sqlLocal5 = "SELECT * FROM GuestAccount";

        private string tableHotel = "Hotel";
        private string sqlLocal6 = "SELECT * FROM Hotel";

        private string tablePayment = "Payment";
        private string sqlLocal7 = "SELECT * FROM Payment";

        private string tableAgent = "TravelAgent";
        private string sqlLocal8 = "SELECT * FROM TravelAgent";

        private Collection<Booking> bookings;
        private Collection<BookingRoom> bookingRooms;
        private Collection<HotelRoom> hotelRooms;
        private Collection<Guest> guests;
        private Collection<GuestAccount> accounts;
        private Collection<Hotel> hotels;
        private Collection<Payment> payments;
        private Collection<TravelAgent> travelAgents;

        #endregion
        #region Property Methods: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        private Collection<BookingRoom> AllBookingRooms
        {
            get
            {
                return bookingRooms;
            }
        }
        private Collection<HotelRoom> AllHotelRooms
        {
            get
            {
                return hotelRooms;
            }
        }
        private Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        private Collection<GuestAccount> AllAccounts
        {
            get
            {
                return accounts;
            }
        }
        private Collection<Hotel> AllHotels
        {
            get
            {
                return hotels;
            }
        }
        private Collection<Payment> AllPayments
        {
            get
            {
                return payments;
            }
        }
        private Collection<TravelAgent> AlltravelAgents
        {
            get
            {
                return travelAgents;
            }
        }

        #endregion
        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            bookingRooms = new Collection<BookingRoom>();
            hotelRooms = new Collection<HotelRoom>();
            guests = new Collection<Guest>();
            accounts = new Collection<GuestAccount>();
            hotels = new Collection<Hotel>();
            payments = new Collection<Payment>();
            travelAgents = new Collection<TravelAgent>();

            FillDataSet(sqlLocal1, tableBooking);
            Add2Collection(tableBooking);

            FillDataSet(sqlLocal2, tableBookingRoom);
            Add2Collection(tableBookingRoom);

            FillDataSet(sqlLocal3, tableRoom);
            Add2Collection(tableRoom);

            FillDataSet(sqlLocal4, tableGuest);
            Add2Collection(tableGuest);

            FillDataSet(sqlLocal5, tableAccount);
            Add2Collection(tableAccount);

            FillDataSet(sqlLocal6, tableHotel);
            Add2Collection(tableHotel);

            FillDataSet(sqlLocal7, tablePayment);
            Add2Collection(tablePayment);

            FillDataSet(sqlLocal8, tableAgent);
            Add2Collection(tableAgent);
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

                    foreach (DataRow brRow in dsMain.Tables[tableBookingRoom].Select($"BookingId = {booking.bookingResNumber}"))
                    {
                        DataRow roomRow = dsMain.Tables[tableRoom].Rows.Find(brRow["HotelRoomId"]);
                        if (roomRow != null)
                        {
                            HotelRoom room = new HotelRoom();
                            room.HotelRoomID = Convert.ToString(roomRow["HotelRoomId"]).TrimEnd();
                            room.getRoomStatus = (HotelRoom.RoomStatus)Convert.ToByte(myRow["RoomStatus"]);
                            room.RoomPrice = Convert.ToDecimal(roomRow["RoomPrice"]);
                            room.RoomCapacity = Convert.ToInt32(roomRow["RoomCapacity"]);
                            
                            booking.Rooms.Add(room);
                        }
                    }
                    bookings.Add(booking);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            aRow["BookingResNumber"] = booking.bookingResNumber;
            aRow["GuestId"] = booking.guest.guestID;
            aRow["TravelAgentId"] = booking.travelAgent.TravelAgentId;
            aRow["BookingStatus"] = booking.bookingStat;
            aRow["BookingType"] = booking.bookingType;
            aRow["numOfPeople"] = booking.numOfPeople;
            aRow["numOfRooms"] = booking.numOfRooms;
            aRow["CheckInDate"] = booking.checkInDate;
            aRow["CheckOutDate"] = booking.checkOutDate;
            aRow["SpecialRequirements"] = booking.specialRequirements;

        }
        private void FillRowBookingRoom(DataRow aRow, HotelRoom room, int bookingResNumber)
        {
            aRow["BookingResNumber"] = bookingResNumber;
            aRow["HotelRoomId"] = room.HotelRoomID;
        }
        private int FindRow(Booking booking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (booking.bookingResNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["BookingResNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database operations CRUD
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].NewRow();
                    FillRow(aRow, booking, DBOperation.add);
                    dsMain.Tables[tableBooking].Rows.Add(aRow);

                    // Rooms
                    foreach (var room in booking.Rooms)
                    {
                        DataRow brRow = dsMain.Tables[tableBookingRoom].NewRow();
                        FillRowBookingRoom(brRow, room, booking.bookingResNumber);
                        dsMain.Tables[tableBookingRoom].Rows.Add(brRow);
                    }
                    break;

                case DB.DBOperation.edit:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        FillRow(aRow, booking, DBOperation.edit);

                    // Rooms: delete old, add current
                    foreach (DataRow old in dsMain.Tables[tableBookingRoom].Select($"BookingResNumber={booking.bookingResNumber}"))
                        old.Delete();

                    foreach (var room in booking.Rooms)
                    {
                        DataRow brRow = dsMain.Tables[tableBookingRoom].NewRow();
                        FillRowBookingRoom(brRow, room, booking.bookingResNumber);
                        dsMain.Tables[tableBookingRoom].Rows.Add(brRow);
                    }
                    break;

                case DB.DBOperation.delete:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        aRow.Delete();

                    // Rooms
                    foreach (DataRow old in dsMain.Tables[tableBookingRoom].Select($"BookingResNumber={booking.bookingResNumber}"))
                        old.Delete();
                    break;
            }
        
        }

        #endregion
        #region Build Parameters, Create Commands & Update database
        private void Build_UPDATE_Parameters(Booking booking)
        {

        }

        #endregion
    }

}

