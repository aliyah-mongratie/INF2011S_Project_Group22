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
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";
        private string table2 = "BookingRoom";
        private string sqlLocal2 = "SELECT * FROM BookingRoom";
        private string table3 = "HotelRoom";
        private string sqlLocal3 = "SELECT * FROM BookingRoom";

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
            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);

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

                    foreach (DataRow brRow in dsMain.Tables[table2].Select($"BookingId = {booking.bookingResNumber}"))
                    {
                        DataRow roomRow = dsMain.Tables[table3].Rows.Find(brRow["HotelRoomId"]);
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
                    aRow = dsMain.Tables[table1].NewRow();
                    FillRow(aRow, booking, DBOperation.add);
                    dsMain.Tables[table1].Rows.Add(aRow);

                    // Rooms
                    foreach (var room in booking.Rooms)
                    {
                        DataRow brRow = dsMain.Tables[table2].NewRow();
                        FillRowBookingRoom(brRow, room, booking.bookingResNumber);
                        dsMain.Tables[table2].Rows.Add(brRow);
                    }
                    break;

                case DB.DBOperation.edit:
                    // Booking
                    aRow = dsMain.Tables[table1].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        FillRow(aRow, booking, DBOperation.edit);

                    // Rooms: delete old, add current
                    foreach (DataRow old in dsMain.Tables[table2].Select($"BookingResNumber={booking.bookingResNumber}"))
                        old.Delete();

                    foreach (var room in booking.Rooms)
                    {
                        DataRow brRow = dsMain.Tables[table2].NewRow();
                        FillRowBookingRoom(brRow, room, booking.bookingResNumber);
                        dsMain.Tables[table2].Rows.Add(brRow);
                    }
                    break;

                case DB.DBOperation.delete:
                    // Booking
                    aRow = dsMain.Tables[table1].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        aRow.Delete();

                    // Rooms
                    foreach (DataRow old in dsMain.Tables[table2].Select($"BookingResNumber={booking.bookingResNumber}"))
                        old.Delete();
                    break;
            }
        
        }
    }
    #endregion
    #region Build Parameters, Create Commands & Update database

    #endregion
}

