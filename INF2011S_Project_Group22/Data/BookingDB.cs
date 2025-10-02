using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using INF2011S_Project_Group22.Business;
using static INF2011S_Project_Group22.HotelBookingDBDataSet;
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
            AddBooking(tableBooking);

            FillDataSet(sqlLocal2, tableBookingRoom);
            AddBookingRoom(tableBookingRoom);

            FillDataSet(sqlLocal3, tableRoom);
            AddRoom(tableRoom);

            FillDataSet(sqlLocal4, tableGuest);
            AddGuest(tableGuest);

            FillDataSet(sqlLocal5, tableAccount);
            AddGuestAccount(tableAccount);

            FillDataSet(sqlLocal6, tableHotel);
            AddHotel(tableHotel);

            FillDataSet(sqlLocal7, tablePayment);
            AddPayment(tablePayment);

            FillDataSet(sqlLocal8, tableAgent);
            AddTravelAgent(tableAgent);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        //Methods for adding to the collections.
        public void AddHotel(string table)
        {
            DataRow myRow = null;
            Hotel hotel;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableHotel].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    hotel = new Hotel();

                    hotel.HotelID = Convert.ToString(myRow["HotelId"]).TrimEnd();
                    hotel.HotelName = Convert.ToString(myRow["HotelName"]).TrimEnd();
                    hotel.HotelAddress = Convert.ToString(myRow["HotelAddress"]).TrimEnd();
                    hotel.HotelCity = Convert.ToString(myRow["HotelCity"]).TrimEnd();
                    hotel.HotelPostCode = Convert.ToString(myRow["HotelPostCode"]).TrimEnd();
                    hotel.HotelPhone = Convert.ToString(myRow["HotelPhone"]).TrimEnd();
                    hotel.HotelEmail = Convert.ToString(myRow["HotelEmail"]).TrimEnd();
                    hotel.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);


                    hotels.Add(hotel);
                }

            }
        }
        public void AddGuest(string table)
        {
            DataRow myRow = null;
            Guest guest;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableGuest].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guest = new Guest();
                    guest.GuestID = Convert.ToString(myRow["GuestId"]).TrimEnd();
                    guest.FirstName = Convert.ToString(myRow["FirstName"]).TrimEnd();
                    guest.LastName = Convert.ToString(myRow["LastName"]).TrimEnd();
                    guest.PhoneNumber = Convert.ToString(myRow["PhoneNumber"]).TrimEnd();
                    guest.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    guest.CreditCardNumber = Convert.ToInt32(myRow["CreditCardNumber"]);



                    guests.Add(guest);
                }

            }
        }

        public void AddTravelAgent(string table)
        {
            DataRow myRow = null;
            TravelAgent travelAgent;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableAgent].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    travelAgent = new TravelAgent();
                    travelAgent.TravelAgentId = Convert.ToString(myRow["TravelAgentId"]).TrimEnd();
                    travelAgent.AgencyName = Convert.ToString(myRow["AgencyName"]).TrimEnd();
                    travelAgent.FirstName = Convert.ToString(myRow["FirstName"]).TrimEnd();
                    travelAgent.LastName = Convert.ToString(myRow["LastName"]).TrimEnd();
                    travelAgent.PhoneNumber = Convert.ToString(myRow["PhoneNumber"]).TrimEnd();
                    travelAgent.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                   



                    travelAgents.Add(travelAgent);
                }

            }
        }

        public void AddGuestAccount(string table)
        {
            DataRow myRow = null;
            GuestAccount guestAccount;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableAccount].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guestAccount = new GuestAccount();
                    guestAccount.GuestID = Convert.ToInt32(myRow["GuestID"]);
                    guestAccount.RoomID = Convert.ToInt32(myRow["RoomID"]);
                    guestAccount.CreditCardCredentials = Convert.ToInt32(myRow["CreditCardCredentials"]);
                    guestAccount.AccountStatus = Convert.ToString(myRow["AccountStatus"]).TrimEnd();
                    guestAccount.AccountBalance = Convert.ToDecimal(myRow["Email"]);
                    guestAccount.AccountCharges = Convert.ToInt32(myRow["CreditCardNumber"]);


                    accounts.Add(guestAccount);
                }
            }
        }
        private void AddPayment(string table)
        {
            DataRow myRow = null;
            Payment payment;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tablePayment].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    payment = new Payment();
                    payment.paymentID = Convert.ToString(myRow["PaymentId"]).TrimEnd();
                    payment.guestId = Convert.ToString(myRow["GuestId"]).TrimEnd();
                    payment.paymentStat = (Payment.PaymentStatus)Convert.ToByte(myRow["PaymentStatus"]);
                    payment.paymentAmount = Convert.ToSingle(myRow["PaymentAmount"]);

                    payments.Add(payment);
                }
            }
        }

        private void AddBookingRoom(string table)
        {
            DataRow myRow = null;
            BookingRoom bookingRoom;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableBookingRoom].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    bookingRoom = new BookingRoom();
                    bookingRoom.bookingResNumber = Convert.ToInt32(myRow["BookingResNumber"]);
                    bookingRoom.hotelRoomId = Convert.ToString(myRow["HotelRoomId"]).TrimEnd();

                    bookingRooms.Add(bookingRoom);
                }
            }
        }

        private void AddRoom(string table)
        {
            DataRow myRow = null;
            HotelRoom room;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableRoom].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    room = new HotelRoom();
                    room.HotelRoomID = Convert.ToString(myRow["HotelRoomId"]).TrimEnd();
                    room.getRoomStatus = (HotelRoom.RoomStatus)Convert.ToByte(myRow["RoomStatus"]);
                    room.RoomPrice = Convert.ToDecimal(myRow["RoomPrice"]);
                    room.RoomCapacity = Convert.ToInt32(myRow["RoomCapacity"]);

                    hotelRooms.Add(room);
                }
            }
        }
        private void AddBooking(string table)
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

                    
                    bookings.Add(booking);
                }
            }
        }
        private void FillRowBooking(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["BookingResNumber"] = booking.bookingResNumber;
            }
               
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
        
        private int FindRowBooking(Booking booking, string table)
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
        private void FillRowBookingRoom(DataRow aRow, HotelRoom room, int bookingResNumber)
        {
            aRow["BookingResNumber"] = bookingResNumber;
            aRow["HotelRoomId"] = room.HotelRoomID;

        }
        private int FindRowBookingRoom(BookingRoom bookingRoom, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (bookingRoom.bookingResNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["BookingResNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRowGuest(DataRow aRow, Guest guest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["GuestId"] = guest.GuestID;
            }
                
            aRow["FirstName"] = guest.FirstName;
            aRow["LastName"] = guest.LastName;
            aRow["PhoneNumber"] = guest.PhoneNumber;
            aRow["Email"] = guest.Email;
            aRow["CreditCardNumber"] = guest.CreditCardNumber;
        }
        private int FindRowGuest(Guest guest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (guest.guestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestId"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRowGuestAccount(DataRow aRow, GuestAccount account, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["GuestId"] = account.GuestID;
            }

            aRow["RoomId"] = account.RoomID;
            aRow["CreditCardCredentials"] = account.CreditCardCredentials;
            aRow["AccountStatus"] = account.AccountStatus;
            aRow["AccountBalance"] = account.AccountBalance;
            aRow["AccountCharges"] = account.AccountCharges;

        }
        private int FindRowGuestAccount(GuestAccount account, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (account.GuestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestId"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRowPayment(DataRow aRow, Payment payment, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["PaymentId"] = payment.paymentID;
            }
            aRow["GuestId"] = payment.guestId;
            aRow["PaymentStatus"] = payment.paymentStat;
            aRow["PaymentAmount"] = payment.paymentAmount;
        }
        private int FindRowPayment(Payment payment, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (payment.paymentID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["PaymentId"]))
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
                    FillRowBooking(aRow, booking, DBOperation.add);
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
                        FillRowBooking(aRow, booking, DBOperation.edit);

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

