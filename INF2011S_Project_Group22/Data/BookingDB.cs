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
        public Collection<BookingRoom> AllBookingRooms
        {
            get
            {
                return bookingRooms;
            }
        }
        public Collection<HotelRoom> AllHotelRooms
        {
            get
            {
                return hotelRooms;
            }
        }
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        public Collection<GuestAccount> AllAccounts
        {
            get
            {
                return accounts;
            }
        }
        public Collection<Hotel> AllHotels
        {
            get
            {
                return hotels;
            }
        }
        public Collection<Payment> AllPayments
        {
            get
            {
                return payments;
            }
        }
        public Collection<TravelAgent> AlltravelAgents
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
                    guest.guestStat = (Guest.GuestStatus)Convert.ToByte(myRow["GuestStatus"]);
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
                    guestAccount.GuestID = Convert.ToString(myRow["GuestID"]);
                    guestAccount.RoomID = Convert.ToInt32(myRow["RoomID"]);
                    guestAccount.CreditCardCredentials = Convert.ToInt32(myRow["CreditCardCredentials"]);
                    guestAccount.accountStat = (GuestAccount.AccountStatus)Convert.ToByte(myRow["AccountStatus"]);
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
                    booking.bookingType = (Booking.BookingType)Convert.ToByte(myRow["bookingType"]);
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
        private void FillRowBookingRoom(DataRow aRow, BookingRoom bookingRoom, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["BookingResNumber"] = bookingRoom.bookingResNumber;
                aRow["HotelRoomId"] = bookingRoom.hotelRoomId;
            }
           

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
            aRow["GuestStatus"] = guest.getGuestStatus;
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
            aRow["AccountStatus"] = account.accountStat;
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
        private void FillRowTravelAgent(DataRow aRow, TravelAgent agent, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["TravelAgentId"] = agent.TravelAgentId;
            }
            aRow["AgencyName"] = agent.AgencyName;
            aRow["FirstName"] = agent.FirstName;
            aRow["LastName"] = agent.LastName;
            aRow["PhoneNumber"] = agent.PhoneNumber;
            aRow["Email"] = agent.Email;
        }
        private int FindRowTravelAgent(TravelAgent agent, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (agent.TravelAgentId == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["TravelAgentId"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRowRoom(DataRow aRow, HotelRoom room, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.add)
            {
                aRow["HotelRoomId"] = room.HotelRoomID;
            }
           
            aRow["RoomStatus"] = room.getRoomStatus;
            aRow["RoomPrice"] = room.RoomPrice;
            aRow["RoomCapacity"] = room.RoomCapacity;
            
        }
        private int FindRowRoom(HotelRoom room, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (room.HotelRoomID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["HotelRoomId"]))
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
        public void DataSetChangeBooking(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].NewRow();
                    FillRowBooking(aRow, booking, DBOperation.add);
                    dsMain.Tables[tableBooking].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        FillRowBooking(aRow, booking, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    // Booking
                    aRow = dsMain.Tables[tableBooking].Rows.Find(booking.bookingResNumber);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }
        
        }

        public void DataSetChangeBookingRoom(BookingRoom bookingRoom, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tableBookingRoom].NewRow();
                    FillRowBookingRoom(aRow, bookingRoom, DBOperation.add);
                    dsMain.Tables[tableBookingRoom].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tableBookingRoom].Rows.Find(bookingRoom.bookingResNumber);
                    if (aRow != null)
                        FillRowBookingRoom(aRow, bookingRoom, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableBookingRoom].Rows.Find(bookingRoom.bookingResNumber);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }


        }
        public void DataSetChangeGuest(Guest guest, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tableGuest].NewRow();
                    FillRowGuest(aRow, guest, DBOperation.add);
                    dsMain.Tables[tableGuest].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tableGuest].Rows.Find(guest.GuestID);
                    if (aRow != null)
                        FillRowGuest(aRow, guest, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableGuest].Rows.Find(guest.GuestID);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        public void DataSetChangeGuestAccount(GuestAccount account, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tableAccount].NewRow();
                    FillRowGuestAccount(aRow, account, DBOperation.add);
                    dsMain.Tables[tableAccount].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tableAccount].Rows.Find(account.GuestID);
                    if (aRow != null)
                        FillRowGuestAccount(aRow, account, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableAccount].Rows.Find(account.GuestID);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        public void DataSetChangeHotelRoom(HotelRoom room, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tableRoom].NewRow();
                    FillRowRoom(aRow, room, DBOperation.add);
                    dsMain.Tables[tableRoom].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tableRoom].Rows.Find(room.HotelRoomID);
                    if (aRow != null)
                        FillRowRoom(aRow, room, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableRoom].Rows.Find(room.HotelRoomID);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        public void DataSetChangePayment(Payment payment, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tablePayment].NewRow();
                    FillRowPayment(aRow, payment, DBOperation.add);
                    dsMain.Tables[tablePayment].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tablePayment].Rows.Find(payment.paymentID);
                    if (aRow != null)
                        FillRowPayment(aRow, payment, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tablePayment].Rows.Find(payment.paymentID);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        public void DataSetChangeTravelAgent(TravelAgent agent, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add:
                    aRow = dsMain.Tables[tableAgent].NewRow();
                    FillRowTravelAgent(aRow, agent, DBOperation.add);
                    dsMain.Tables[tableAgent].Rows.Add(aRow);
                    break;

                case DB.DBOperation.edit:
                    aRow = dsMain.Tables[tableAgent].Rows.Find(agent.TravelAgentId);
                    if (aRow != null)
                        FillRowTravelAgent(aRow, agent, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableAgent].Rows.Find(agent.TravelAgentId);
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        #endregion
        #region Build Parameters, Create Commands & Update database
        private void Build_UPDATE_Parameters_Book(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingResNumber", SqlDbType.NVarChar, 10, "BookingResNumber");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingStatus", SqlDbType.NVarChar, 20, "BookingStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@bookingType", SqlDbType.NVarChar, 50, "bookingType");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfPeople", SqlDbType.Int, 0, "numOfPeople");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfRooms", SqlDbType.Int, 0, "numOfRooms");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 0, "CheckInDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 0, "CheckOutDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequirements", SqlDbType.NVarChar, 500, "SpecialRequirements");
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_UPDATE_Parameters_BookRoom(BookingRoom bookingRoom)
        {
            
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingResNumber", SqlDbType.NVarChar, 10, "BookingResNumber");
            daMain.UpdateCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.UpdateCommand.Parameters.Add(param);

        }
        private void Build_UPDATE_Parameters_Guest(Guest guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestStatus", SqlDbType.NVarChar, 20, "GuestStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15, "PhoneNumber");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardNumber", SqlDbType.NVarChar, 19, "CreditCardNumber");
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_UPDATE_Parameters_Account(GuestAccount account)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardCredentials", SqlDbType.NVarChar, 10, "CreditCardCredentials");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountStatus", SqlDbType.NVarChar, 20, "AccountStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountBalance", SqlDbType.Money, 8, "AccountBalance");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountCharges", SqlDbType.Money, 8, "AccountCharges");
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters_Room(HotelRoom room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomStatus", SqlDbType.NVarChar, 20, "RoomStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomPrice", SqlDbType.Money, 8, "RoomPrice");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomCapacity", SqlDbType.Int, 0, "RoomCapacity");
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters_Payment(Payment payment)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentId", SqlDbType.NVarChar, 10, "PaymentId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 20, "PaymentStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentAmount", SqlDbType.Money, 8, "PaymentAmount");
            daMain.UpdateCommand.Parameters.Add(param);

        }
        private void Build_UPDATE_Parameters_Agent(TravelAgent agent)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TravelAgency", SqlDbType.NVarChar, 50, "TravelAgency");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15, "PhoneNumber");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.UpdateCommand.Parameters.Add(param);

        }
        private void Create_UPDATE_Command_Book(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestId =@GuestId, HotelId = @Hotelid, TravelAgentId =@TravelAgentId, BookingStatus =@BookingStatus, bookingType =@bookingType, numOfPeople =@numOfPeople, numOfRooms =@numOfRooms, CheckInDate =@CheckInDate, CheckOutDate =@CheckOutDate, SpecialRequirements =@SpecialRequirements " + "WHERE BookingResNumber = @Original_BookingResNumber", cnMain);
            Build_UPDATE_Parameters_Book(booking);
        }
        private void Create_UPDATE_Command_BookRoom(BookingRoom bookingRoom)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET BookingResNumber = @BookingResNumber , HotelRoomId = @HotelRoomId" + "WHERE BookingResNumber = @Original_BookingResNumber", cnMain);
            Create_UPDATE_Command_BookRoom(bookingRoom);
        }
        private void Create_UPDATE_Command_Guest(Guest guest)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestStatus =@GuestStatus, FirstName = @FirstName, LastName =@LastName, PhoneNumber =@PhoneNumber, Email =@Email, CreditCardNumber =@CreditCardNumber" + "WHERE GuestId = @Original_GuestId", cnMain);
            Build_UPDATE_Parameters_Guest(guest);
        }
        private void Create_UPDATE_Command_Account(GuestAccount account)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET HotelRoomId =@HotelRoomId, CreditCardCredentials = @CreditCardCredentials, AccountStatus =@AccountStatus, AccountBalance =@AccountBalance, AccountCharges =@AccountCharges" + "WHERE GuestId = @Original_GuestId", cnMain);
            Build_UPDATE_Parameters_Account(account);
        }
        private void Create_UPDATE_Command_Room(HotelRoom room)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET HotelId =@HotelId, RoomStatus = @RoomStatus, RoomPrice =@RoomPrice, RoomCapacity =@RoomCapacity" + "WHERE HotelRoomId = @Original_HotelRoomId", cnMain);
            Build_UPDATE_Parameters_Room(room);
        }
        private void Create_UPDATE_Command_Payment(Payment payment)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestId =@GuestId, PaymentStatus = @PaymentStatus, PaymentAmount =@PaymentAmount" + "WHERE PaymentId = @Original_PaymentId", cnMain);
            Build_UPDATE_Parameters_Payment(payment);
        }
        private void Create_UPDATE_Command_Agent(TravelAgent agent)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET TravelAgency =@TravelAgency, FirstName = @FirstName, LastName =@LastName, PhoneNumber =@PhoneNumber, Email =@Email" + "WHERE TravelAgentId = @Original_TravelAgentId", cnMain);
            Build_UPDATE_Parameters_Agent(agent);
        }
        
        private void Build_INSERT_Parameters_Book(Booking booking)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingResNumber", SqlDbType.NVarChar, 10, "BookingResNumber");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingStatus", SqlDbType.NVarChar, 20, "BookingStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@bookingType", SqlDbType.NVarChar, 50, "bookingType");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfPeople", SqlDbType.Int, 0, "numOfPeople");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfRooms", SqlDbType.Int, 0, "numOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 0, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 0, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequirements", SqlDbType.NVarChar, 500, "SpecialRequirements");
            daMain.InsertCommand.Parameters.Add(param);

           
        }

        private void Build_INSERT_Parameters_BookRoom(BookingRoom bookingRoom)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingResNumber", SqlDbType.NVarChar, 10, "BookingResNumber");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_INSERT_Parameters_Guest(Guest guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestStatus", SqlDbType.NVarChar, 20, "GuestStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15, "PhoneNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardNumber", SqlDbType.NVarChar, 19, "CreditCardNumber");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_INSERT_Parameters_Account(GuestAccount account)
        {
      
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardCredentials", SqlDbType.NVarChar, 10, "CreditCardCredentials");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountStatus", SqlDbType.NVarChar, 20, "AccountStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountBalance", SqlDbType.Money, 8, "AccountBalance");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountCharges", SqlDbType.Money, 8, "AccountCharges");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_INSERT_Parameters_Room(HotelRoom room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomStatus", SqlDbType.NVarChar, 20, "RoomStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomPrice", SqlDbType.Money, 8, "RoomPrice");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomCapacity", SqlDbType.Int, 0, "RoomCapacity");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_INSERT_Parameters_Payment(Payment payment)
        {

            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentId", SqlDbType.NVarChar, 10, "PaymentId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 20, "PaymentStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentAmount", SqlDbType.Money, 8, "PaymentAmount");
            daMain.InsertCommand.Parameters.Add(param);

        }
        private void Build_INSERT_Parameters_Agent(TravelAgent agent)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TravelAgency", SqlDbType.NVarChar, 50, "TravelAgency");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15, "PhoneNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

        }


        private void Create_INSERT_Command_Book(Booking booking)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET GuestId =@GuestId, HotelId = @Hotelid, TravelAgentId =@TravelAgentId, BookingStatus =@BookingStatus, bookingType =@bookingType, numOfPeople =@numOfPeople, numOfRooms =@numOfRooms, CheckInDate =@CheckInDate, CheckOutDate =@CheckOutDate, SpecialRequirements =@SpecialRequirements " + "WHERE BookingResNumber = @Original_BookingResNumber", cnMain);
            Create_INSERT_Command_Book(booking);
        }

        private void Create_INSERT_Command_BookRoom(BookingRoom bookingRoom)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET BookingResNumber = @BookingResNumber , HotelRoomId = @HotelRoomId" + "WHERE BookingResNumber = @Original_BookingResNumber", cnMain);
            Create_INSERT_Command_BookRoom(bookingRoom);
        }

        private void Create_INSERT_Command_Guest(Guest guest)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET GuestStatus =@GuestStatus, FirstName = @FirstName, LastName =@LastName, PhoneNumber =@PhoneNumber, Email =@Email, CreditCardNumber =@CreditCardNumber" + "WHERE GuestId = @Original_GuestId", cnMain);
            Create_INSERT_Command_Guest(guest);
        }
        private void Create_INSERT_Command_Account(GuestAccount account)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET HotelRoomId =@HotelRoomId, CreditCardCredentials = @CreditCardCredentials, AccountStatus =@AccountStatus, AccountBalance =@AccountBalance, AccountCharges =@AccountCharges" + "WHERE GuestId = @Original_GuestId", cnMain);
            Create_INSERT_Command_Account(account);
        }
        private void Create_INSERT_Command_Room(HotelRoom room)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET HotelId =@HotelId, RoomStatus = @RoomStatus, RoomPrice =@RoomPrice, RoomCapacity =@RoomCapacity" + "WHERE HotelRoomId = @Original_HotelRoomId", cnMain);
            Create_INSERT_Command_Room(room);
        }
        private void Create_INSERT_Command_Payment(Payment payment)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET GuestId =@GuestId, PaymentStatus = @PaymentStatus, PaymentAmount =@PaymentAmount" + "WHERE PaymentId = @Original_PaymentId", cnMain);
            Create_INSERT_Command_Payment(payment);
        }
        private void Create_INSERT_Command_Agent(TravelAgent agent)
        {
            daMain.InsertCommand = new SqlCommand("UPDATE Booking SET TravelAgency =@TravelAgency, FirstName = @FirstName, LastName =@LastName, PhoneNumber =@PhoneNumber, Email =@Email" + "WHERE TravelAgentId = @Original_TravelAgentId", cnMain);
            Create_INSERT_Command_Agent(agent);
        }
        public bool UpdateDataSource_Book(Booking booking) 
        {
            bool success = true;
            Create_INSERT_Command_Book(booking);
            Create_UPDATE_Command_Book(booking);

          
            return success;
        }

        public bool UpdateDataSource_BookRoom(BookingRoom bookingRoom)
        {
            bool success = true;
            Create_INSERT_Command_BookRoom(bookingRoom);
            Create_UPDATE_Command_BookRoom(bookingRoom);


            return success;
        }

        public bool UpdateDataSource_Guest(Guest guest)
        {
            bool success = true;
            Create_INSERT_Command_Guest(guest);
            Create_UPDATE_Command_Guest(guest);


            return success;
        }

        public bool UpdateDataSource_Account(GuestAccount account)
        {
            bool success = true;
            Create_INSERT_Command_Account(account);
            Create_UPDATE_Command_Account(account);


            return success;
        }

        public bool UpdateDataSource_Room(HotelRoom room)
        {
            bool success = true;
            Create_INSERT_Command_Room(room);
            Create_UPDATE_Command_Room(room);


            return success;
        }

        public bool UpdateDataSource_Payment(Payment payment)
        {
            bool success = true;
            Create_INSERT_Command_Payment(payment);
            Create_UPDATE_Command_Payment(payment);


            return success;
        }

        public bool UpdateDataSource_Agent(TravelAgent agent)
        {
            bool success = true;
            Create_INSERT_Command_Agent(agent);
            Create_UPDATE_Command_Agent(agent);


            return success;
        }
        #endregion
    }

}

