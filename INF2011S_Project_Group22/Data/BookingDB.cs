using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        // Tables in the database and SQL queries associated with each table
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

        // Collections to store a list of objects
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
        // The collections have no set accessors so that they cannot be replaced entirely 
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
        public Collection<TravelAgent> AllTravelAgents
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
            AddBooking();

            FillDataSet(sqlLocal2, tableBookingRoom);
            AddBookingRoom();

            FillDataSet(sqlLocal3, tableRoom);
            AddRoom();

            FillDataSet(sqlLocal4, tableGuest);
            AddGuest();

            FillDataSet(sqlLocal5, tableAccount);
            AddGuestAccount();

            FillDataSet(sqlLocal6, tableHotel);
            AddHotel();

            FillDataSet(sqlLocal7, tablePayment);
            AddPayment();

            FillDataSet(sqlLocal8, tableAgent);
            AddTravelAgent();
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            //Returns the dsMain object which stores the database tables so that they can be read, displayed, or changed
            return dsMain;
        }
        //Methods for adding to the collections for each table.
        public void AddHotel()
        {
            DataRow myRow = null; // row in a table 
            Hotel hotel; //The hotel class
            if (dsMain.Tables[tableHotel] == null)
            {
                throw new Exception($"Table '{tableHotel}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableHotel].Rows) //for each row in the Hotel table
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted)) //skips rows that have been deleted 
                {
                    hotel = new Hotel(); //create a new Hotel object

                    hotel.HotelID = Convert.ToString(myRow["HotelId"]).TrimEnd();
                    hotel.HotelName = Convert.ToString(myRow["HotelName"]).TrimEnd();
                    hotel.HotelAddress = Convert.ToString(myRow["HotelAddress"]).TrimEnd();
                    hotel.HotelCity = Convert.ToString(myRow["HotelCity"]).TrimEnd();
                    hotel.HotelPostCode = Convert.ToString(myRow["HotelPostCode"]).TrimEnd();
                    hotel.HotelPhone = Convert.ToString(myRow["HotelPhone"]).TrimEnd();
                    hotel.HotelEmail = Convert.ToString(myRow["HotelEmail"]).TrimEnd();
                    hotel.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);


                    hotels.Add(hotel); //add the hotel object to the collection 
                }

            }
        }
        public void AddGuest()
        {
            DataRow myRow = null;
            Guest guest;
            if (dsMain.Tables[tableGuest] == null)
            {
                throw new Exception($"Table '{tableGuest}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
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
                    guest.CreditCardNumber = Convert.ToString(myRow["CreditCardNumber"]);



                    guests.Add(guest);
                }

            }
        }

        public void AddTravelAgent()
        {
            DataRow myRow = null;
            TravelAgent travelAgent;
            if (dsMain.Tables[tableAgent] == null)
            {
                throw new Exception($"Table '{tableAgent}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
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

        public void AddGuestAccount()
        {
            DataRow myRow = null;
            GuestAccount guestAccount;
            if (dsMain.Tables[tableAccount] == null)
            {
                throw new Exception($"Table '{tableAccount}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableAccount].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guestAccount = new GuestAccount();
                    guestAccount.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    guestAccount.CreditCardCredentials = Convert.ToString(myRow["CreditCardCredentials"]);
                    guestAccount.accountStat = (GuestAccount.AccountStatus)Enum.Parse(typeof(GuestAccount.AccountStatus), Convert.ToString(myRow["AccountStatus"]));
                    guestAccount.AccountBalance = Convert.ToDecimal(myRow["AccountBalance"]);
                    guestAccount.AccountCharges = Convert.ToInt32(myRow["AccountCharges"]);


                    accounts.Add(guestAccount);
                }
            }
        }
        private void AddPayment()
        {
            DataRow myRow = null;
            Payment payment;
            if (dsMain.Tables[tablePayment] == null)
            {
                throw new Exception($"Table '{tablePayment}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tablePayment].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    payment = new Payment();
                    payment.paymentID = Convert.ToString(myRow["PaymentId"]).TrimEnd();
                    payment.guestId = Convert.ToString(myRow["GuestId"]).TrimEnd();
                    payment.paymentStat = (Payment.PaymentStatus)Enum.Parse(typeof(Payment.PaymentStatus), Convert.ToString(myRow["PaymentStatus"]));
                    payment.paymentAmount = Convert.ToDecimal(myRow["PaymentAmount"]);

                    payments.Add(payment);
                }
            }
        }

        private void AddBookingRoom()
        {
            DataRow myRow = null;
            BookingRoom bookingRoom;
            if (dsMain.Tables[tableBookingRoom] == null)
            {
                throw new Exception($"Table '{tableBookingRoom}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
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

        public void AddRoom()
        {
            if (dsMain.Tables[tableRoom] == null)
                throw new Exception($"Table '{tableRoom}' was not loaded into the DataSet.");

            foreach (DataRow myRow in dsMain.Tables[tableRoom].Rows)
            {
                if (myRow.RowState == DataRowState.Deleted) continue;

                HotelRoom room = new HotelRoom();

                room.HotelRoomID = Convert.ToString(myRow["HotelRoomId"]).Trim();
                room.HotelID = Convert.ToString(myRow["HotelId"]).Trim();
                room.RoomCapacity = Convert.ToInt32(myRow["RoomCapacity"]);

                string statusString = Convert.ToString(myRow["RoomStatus"]).Trim();

                // Safe parsing — avoids crash if value doesn't match enum name exactly
                if (Enum.TryParse(statusString, true, out HotelRoom.RoomStatus parsedStatus))
                    room.roomStat = parsedStatus;
                else
                    room.roomStat = HotelRoom.RoomStatus.Available;

                hotelRooms.Add(room);
            }
        }

        private void AddBooking()
        {
            DataRow myRow = null;
            Booking booking;
            if (dsMain.Tables[tableBooking] == null)
            {
                throw new Exception($"Table '{tableBooking}' was not loaded into the DataSet."); //if the table is not loaded, throw an exception to remind the user.
            }
            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableBooking].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    booking = new Booking(); // instantiate new booking object 

                    booking.bookingResNumber = Convert.ToInt32(myRow["BookingResNumber"]);
                    booking.guestId = Convert.ToString(myRow["GuestId"]).TrimEnd();
                    booking.hotelId = Convert.ToString(myRow["HotelId"]).TrimEnd();
                    booking.travelAgentId = Convert.ToString(myRow["TravelAgentId"]).TrimEnd();
                    booking.bookingStat = (Booking.BookingStatus)Enum.Parse(typeof(Booking.BookingStatus), Convert.ToString(myRow["BookingStatus"]));
                    booking.bookingType = (Booking.BookingType)Enum.Parse(typeof(Booking.BookingType), Convert.ToString(myRow["bookingType"]));
                    booking.numOfPeople = Convert.ToInt32(myRow["numOfPeople"]);
                    booking.numOfRooms = Convert.ToInt32(myRow["numOfRooms"]);
                    booking.checkInDate = Convert.ToDateTime(myRow["CheckInDate"]).Date;
                    booking.checkOutDate = Convert.ToDateTime(myRow["CheckOutDate"]).Date;
                    booking.specialRequirements = Convert.ToString(myRow["SpecialRequirements"]).TrimEnd();

                    bookings.Add(booking);
                }
            }
        }
        private void FillRowBooking(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            // Fill a row with specific Booking data 
            if (operation == DB.DBOperation.add)
            {
                aRow["BookingResNumber"] = booking.bookingResNumber; //Set the row's primary key if a new row is being added 
            }

            aRow["GuestId"] = booking.guestId;
            aRow["HotelId"] = booking.hotelId;
            if (booking.travelAgentId == null)
                aRow["TravelAgentId"] = DBNull.Value;
            else
                aRow["TravelAgentId"] = booking.travelAgentId;

            aRow["BookingStatus"] = booking.bookingStat;
            aRow["bookingType"] = booking.bookingType;
            aRow["numOfPeople"] = booking.numOfPeople;
            aRow["numOfRooms"] = booking.numOfRooms;
            aRow["CheckInDate"] = booking.checkInDate < SqlDateTime.MinValue.Value
                       ? DateTime.Today
                       : booking.checkInDate.Date;

            aRow["CheckOutDate"] = booking.checkOutDate < SqlDateTime.MinValue.Value
                                    ? DateTime.Today.AddDays(1)
                                    : booking.checkOutDate.Date;

            aRow["SpecialRequirements"] = booking.specialRequirements;

        }

        private int FindRowBooking(Booking booking, string table)
        {
            //Find the index of the row in the table which represents a specific object. In this case a booking.
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
            aRow["BookingResNumber"] = bookingRoom.bookingResNumber;
            aRow["HotelRoomId"] = bookingRoom.hotelRoomId;


        }
        private int FindRowBookingRoom(BookingRoom bookingRoom, string table)
        {
            //Find the index of the row in the table which represents a specific object. In this case a room in a booking.
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
            //Find the index of the row in the table which represents a specific object. In this case a guest.
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
                aRow["GuestID"] = account.GuestID;
            }

            aRow["CreditCardCredentials"] = account.CreditCardCredentials;
            aRow["AccountStatus"] = account.accountStat;
            aRow["AccountBalance"] = account.AccountBalance;
            aRow["AccountCharges"] = account.AccountCharges;

        }
        private int FindRowGuestAccount(GuestAccount account, string table)
        {
            //Find the index of the row in the table which represents a specific object. In this case a guest account.
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (account.GuestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]))
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
            //Find the index of the row in the table which represents a specific object. In this case a payment.
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
            //Find the index of the row in the table which represents a specific object. In this case a travel agent.
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
            aRow["HotelId"] = room.HotelID;
            aRow["RoomStatus"] = room.roomStat;
            aRow["RoomCapacity"] = room.RoomCapacity;



        }
        private int FindRowRoom(HotelRoom room, string table)
        {
            //Find the index of the row in the table which represents a specific object. In this case a hotel room.
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


        #region Build Parameters, Create Commands & Update database

        private void Create_UPDATE_Command_Book()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Booking SET GuestId = @GuestId, HotelId = @HotelId, TravelAgentId = @TravelAgentId, " +
                "BookingStatus = @BookingStatus, bookingType = @bookingType, numOfPeople = @numOfPeople, " +
                "numOfRooms = @numOfRooms, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, " +
                "SpecialRequirements = @SpecialRequirements " +
                "WHERE BookingResNumber = @Original_BookingResNumber", cnMain);

            Build_UPDATE_Parameters_Book();
        }

        private void Create_UPDATE_Command_BookRoom()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE BookingRoom " +
                "SET HotelRoomId = @HotelRoomId " +
                "WHERE BookingResNumber = @Original_BookingResNumber " +
                "AND HotelRoomId = @Original_HotelRoomId", cnMain);

            Build_UPDATE_Parameters_BookRoom();
        }

        private void Create_UPDATE_Command_Guest()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Guest SET FirstName = @FirstName, LastName = @LastName, " +
                "PhoneNumber = @PhoneNumber, Email = @Email, CreditCardNumber = @CreditCardNumber " +
                "WHERE GuestId = @Original_GuestId", cnMain);

            Build_UPDATE_Parameters_Guest();
        }

        private void Create_UPDATE_Command_Account()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE GuestAccount SET CreditCardCredentials = @CreditCardCredentials, " +
                "AccountStatus = @AccountStatus, AccountBalance = @AccountBalance, AccountCharges = @AccountCharges " +
                "WHERE GuestID = @Original_GuestID", cnMain);

            Build_UPDATE_Parameters_Account();
        }

        private void Create_UPDATE_Command_Room()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE HotelRoom SET HotelId = @HotelId, RoomStatus = @RoomStatus, RoomCapacity = @RoomCapacity " +
                "WHERE HotelRoomId = @Original_HotelRoomId", cnMain);

            Build_UPDATE_Parameters_Room();
        }

        private void Create_UPDATE_Command_Payment()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Payment SET GuestId = @GuestId, PaymentStatus = @PaymentStatus, PaymentAmount = @PaymentAmount " +
                "WHERE PaymentId = @Original_PaymentId", cnMain);

            Build_UPDATE_Parameters_Payment();
        }

        private void Create_UPDATE_Command_Agent()
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE TravelAgent SET AgencyName = @AgencyName, FirstName = @FirstName, LastName = @LastName, " +
                "PhoneNumber = @PhoneNumber, Email = @Email " +
                "WHERE TravelAgentId = @Original_TravelAgentId", cnMain);

            Build_UPDATE_Parameters_Agent();
        }

        private void Build_UPDATE_Parameters_Book()
        {
            daMain.UpdateCommand.Parameters.Clear();

            SqlParameter param;
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

            param = new SqlParameter("@CheckInDate", SqlDbType.Date, 0, "CheckInDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date, 0, "CheckOutDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequirements", SqlDbType.NVarChar, 500, "SpecialRequirements");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_BookingResNumber", SqlDbType.Int, 0, "BookingResNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters_BookRoom()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Original_BookingResNumber", SqlDbType.Int, 0, "BookingResNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }
        private void Build_UPDATE_Parameters_Guest()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

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

            param = new SqlParameter("@Original_GuestId", SqlDbType.NVarChar, 10, "GuestId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_UPDATE_Parameters_Account()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CreditCardCredentials", SqlDbType.NVarChar, 19, "CreditCardCredentials");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountStatus", SqlDbType.NVarChar, 20, "AccountStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountBalance", SqlDbType.Money, 8, "AccountBalance");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountCharges", SqlDbType.Money, 8, "AccountCharges");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_GuestID", SqlDbType.NVarChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters_Room()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomStatus", SqlDbType.NVarChar, 20, "RoomStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomCapacity", SqlDbType.Int, 0, "RoomCapacity");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters_Payment()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 20, "PaymentStatus");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentAmount", SqlDbType.Money, 8, "PaymentAmount");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_PaymentId", SqlDbType.NVarChar, 10, "PaymentId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }
        private void Build_UPDATE_Parameters_Agent()
        {
            daMain.UpdateCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@AgencyName", SqlDbType.NVarChar, 50, "AgencyName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15, "PhoneNumber");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command_Book()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Booking (BookingResNumber, GuestId, HotelId, TravelAgentId, BookingStatus, bookingType, " +
                "numOfPeople, numOfRooms, CheckInDate, CheckOutDate, SpecialRequirements) " +
                "VALUES (@BookingResNumber, @GuestId, @HotelId, @TravelAgentId, @BookingStatus, @bookingType, " +
                "@numOfPeople, @numOfRooms, @CheckInDate, @CheckOutDate, @SpecialRequirements)", cnMain);

            Build_INSERT_Parameters_Book();
        }

        private void Create_INSERT_Command_BookRoom()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO BookingRoom (BookingResNumber, HotelRoomId) " +
                "VALUES (@BookingResNumber, @HotelRoomId)", cnMain);

            Build_INSERT_Parameters_BookRoom();
        }

        private void Create_INSERT_Command_Guest()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Guest (GuestId, FirstName, LastName, PhoneNumber, Email, CreditCardNumber) " +
                "VALUES (@GuestId, @FirstName, @LastName, @PhoneNumber, @Email, @CreditCardNumber)", cnMain);

            Build_INSERT_Parameters_Guest();
        }

        private void Create_INSERT_Command_Account()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO GuestAccount (GuestID, CreditCardCredentials, AccountStatus, AccountBalance, AccountCharges) " +
                "VALUES (@GuestID, @CreditCardCredentials, @AccountStatus, @AccountBalance, @AccountCharges)", cnMain);

            Build_INSERT_Parameters_Account();
        }

        private void Create_INSERT_Command_Payment()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Payment (PaymentId, GuestId, PaymentStatus, PaymentAmount) " +
                "VALUES (@PaymentId, @GuestId, @PaymentStatus, @PaymentAmount)", cnMain);

            Build_INSERT_Parameters_Payment();
        }

        private void Create_INSERT_Command_Agent()
        {
            if (daMain == null)
                daMain = new SqlDataAdapter();

            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO TravelAgent (TravelAgentId, AgencyName, FirstName, LastName, PhoneNumber, Email) " +
                "VALUES (@TravelAgentId, @AgencyName, @FirstName, @LastName, @PhoneNumber, @Email)", cnMain);

            Build_INSERT_Parameters_Agent();
        }




        private void Build_INSERT_Parameters_Book()
        {
            daMain.InsertCommand.Parameters.Clear();
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingResNumber", SqlDbType.Int, 0, "BookingResNumber");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@HotelId", SqlDbType.NVarChar, 10, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            param.Value = DBNull.Value;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingStatus", SqlDbType.NVarChar, 20, "BookingStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@bookingType", SqlDbType.NVarChar, 50, "bookingType");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfPeople", SqlDbType.Int, 0, "numOfPeople");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@numOfRooms", SqlDbType.Int, 0, "numOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date, 0, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date, 0, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequirements", SqlDbType.NVarChar, 500, "SpecialRequirements");
            daMain.InsertCommand.Parameters.Add(param);


        }

        private void Build_INSERT_Parameters_BookRoom()
        {
            daMain.InsertCommand.Parameters.Clear();
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingResNumber", SqlDbType.Int, 0, "BookingResNumber");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@HotelRoomId", SqlDbType.NVarChar, 10, "HotelRoomId");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Build_INSERT_Parameters_Guest()
        {
            daMain.InsertCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 10, "GuestId");
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

        private void Build_INSERT_Parameters_Account()
        {
            daMain.InsertCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardCredentials", SqlDbType.NVarChar, 19, "CreditCardCredentials");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountStatus", SqlDbType.NVarChar, 20, "AccountStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountBalance", SqlDbType.Money, 8, "AccountBalance");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountCharges", SqlDbType.Money, 8, "AccountCharges");
            daMain.InsertCommand.Parameters.Add(param);
        }


        private void Build_INSERT_Parameters_Payment()
        {
            daMain.InsertCommand.Parameters.Clear();
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
        private void Build_INSERT_Parameters_Agent()
        {
            daMain.InsertCommand.Parameters.Clear();
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@TravelAgentId", SqlDbType.NVarChar, 10, "TravelAgentId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AgencyName", SqlDbType.NVarChar, 50, "AgencyName");
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



        #endregion
        #region Database operations CRUD
        // Data set change methods: take an object and apply a specific operation to the data
        public void DataSetChangeBooking(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.add: //creates a row, fills the row, and it adds it to the dataset
                    aRow = dsMain.Tables[tableBooking].NewRow();
                    FillRowBooking(aRow, booking, DBOperation.add);
                    dsMain.Tables[tableBooking].Rows.Add(aRow);

                    break;

                case DB.DBOperation.edit: //Finds a row and edits the data 
                    aRow = dsMain.Tables[tableBooking].Rows[FindRowBooking(booking, tableBooking)];
                    if (aRow != null)
                        FillRowBooking(aRow, booking, DBOperation.edit);
                    
                    break;

                case DB.DBOperation.delete: //Finds a row and marks it as deleted 
                    aRow = dsMain.Tables[tableBooking].Rows[FindRowBooking(booking, tableBooking)];
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
                    aRow = dsMain.Tables[tableBookingRoom].Rows[FindRowBookingRoom(bookingRoom, tableBookingRoom)];
                    if (aRow != null)
                        FillRowBookingRoom(aRow, bookingRoom, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableBookingRoom].Rows[FindRowBookingRoom(bookingRoom, tableBookingRoom)];
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
                    aRow = dsMain.Tables[tableGuest].Rows[FindRowGuest(guest, tableGuest)];
                    if (aRow != null)
                        FillRowGuest(aRow, guest, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableGuest].Rows[FindRowGuest(guest, tableGuest)];
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
                    aRow = dsMain.Tables[tableAccount].Rows[FindRowGuestAccount(account, tableAccount)];
                    if (aRow != null)
                        FillRowGuestAccount(aRow, account, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableAccount].Rows[FindRowGuestAccount(account, tableAccount)];
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
                    aRow = dsMain.Tables[tableRoom].Rows[FindRowRoom(room, tableRoom)];
                    if (aRow != null)
                        FillRowRoom(aRow, room, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableRoom].Rows[FindRowRoom(room, tableRoom)];
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
                    aRow = dsMain.Tables[tablePayment].Rows[FindRowPayment(payment, tablePayment)];
                    if (aRow != null)
                        FillRowPayment(aRow, payment, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tablePayment].Rows[FindRowPayment(payment, tablePayment)];
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
                    aRow = dsMain.Tables[tableAgent].Rows[FindRowTravelAgent(agent, tableAgent)];
                    if (aRow != null)
                        FillRowTravelAgent(aRow, agent, DBOperation.edit);
                    break;

                case DB.DBOperation.delete:
                    aRow = dsMain.Tables[tableAgent].Rows[FindRowTravelAgent(agent, tableAgent)];
                    if (aRow != null)
                        aRow.Delete();
                    break;
            }

        }
        #endregion
        #region Update data source 
        public bool UpdateDataSource_Book(Booking booking)
        {
            bool success = true; //Tells you if the update succeeded or not 
            Create_INSERT_Command_Book();
            Create_UPDATE_Command_Book();

            success = UpdateDataSource(sqlLocal1, tableBooking);

            return success;
        }

        public bool UpdateDataSource_BookRoom(BookingRoom bookingRoom)
        {
            bool success = true;
            Create_INSERT_Command_BookRoom();
            Create_UPDATE_Command_BookRoom();
            success = UpdateDataSource(sqlLocal2, tableBookingRoom);

            return success;
        }

        public bool UpdateDataSource_Guest(Guest guest)
        {
            bool success = true;
            Create_INSERT_Command_Guest();
            Create_UPDATE_Command_Guest();
            success = UpdateDataSource(sqlLocal4, tableGuest);

            return success;
        }

        public bool UpdateDataSource_Account(GuestAccount account)
        {
            bool success = true;
            Create_INSERT_Command_Account();
            Create_UPDATE_Command_Account();
            success = UpdateDataSource(sqlLocal5, tableAccount);

            return success;
        }

        public bool UpdateDataSource_Room(HotelRoom room)
        {
            bool success = true;

            Create_UPDATE_Command_Room();
            success = UpdateDataSource(sqlLocal3, tableRoom);

            return success;
        }

        public bool UpdateDataSource_Payment(Payment payment)
        {
            bool success = true;
            Create_INSERT_Command_Payment();
            Create_UPDATE_Command_Payment();
            success = UpdateDataSource(sqlLocal7, tablePayment);

            return success;
        }

        public bool UpdateDataSource_Agent(TravelAgent agent)
        {
            bool success = true;
            Create_INSERT_Command_Agent();
            Create_UPDATE_Command_Agent();
            success = UpdateDataSource(sqlLocal8, tableAgent);

            return success;
        }
        #endregion 
    }

}