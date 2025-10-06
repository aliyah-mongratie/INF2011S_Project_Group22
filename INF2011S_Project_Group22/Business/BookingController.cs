using INF2011S_Project_Group22.Data;
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
    class BookingController 
    {
        #region Data Members 
        BookingDB bookingDB; // references the BookingDB class which communicates with the database 
        //Collections for each class 
        Collection<BookingRoom> bookingRooms;
        Collection<HotelRoom> rooms;
        Collection<Guest> guests;
        Collection<GuestAccount> accounts;
        Collection<Hotel> hotels;
        Collection<Payment> payments;
        Collection<TravelAgent> agents;
        Collection<Booking> bookings;
        #endregion

        #region Property methods 
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
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
                return rooms;
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
                return agents;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
            bookingRooms = bookingDB.AllBookingRooms;
            guests = bookingDB.AllGuests;
            payments = bookingDB.AllPayments;
            accounts = bookingDB.AllAccounts;
            rooms = bookingDB.AllHotelRooms;
            agents = bookingDB.AllTravelAgents;
            hotels = bookingDB.AllHotels;
        }

        #endregion

        #region Search Methods 
        // These methods search through the collections and returns a matching object.  

        // Each Find method has a corresponding FindIndex method that returns the index of the object in the collection, and more specifically, the index of the object that is to be edited or deleted.
        public Booking Find(int bookingResNumber)
        {
            if (bookings.Count == 0)
            {
                return null;
            }
               
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

        // this method finds a booking room based on the booking reference number, and returns the booking room object
        public BookingRoom FindBookRoom(int bookingResNumber)
        {
            if (bookingRooms.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (bookingRooms[index].bookingResNumber == bookingResNumber);
            int count = bookingRooms.Count;

            while (!(found) && (index < bookingRooms.Count - 1))
            {
                index++;
                found = (bookingRooms[index].bookingResNumber == bookingResNumber);
            }
            return bookingRooms[index];
        }

        // this method finds a guest based on the guest ID, and returns the guest object
        public Guest FindGuest(string guestID)
        {
            if (guests.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (guests[index].guestID == guestID);
            int count = guests.Count;

            while (!(found) && (index < guests.Count - 1))
            {
                index++;
                found = (guests[index].guestID == guestID);
            }
            return guests[index];
        }

        // this method finds a guest account based on the guest ID, and returns the guest account object
        public GuestAccount FindAccount(string guestId)
        {
            if (accounts.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (accounts[index].guestID == guestId);
            int count = accounts.Count;

            while (!(found) && (index < accounts.Count - 1))
            {
                index++;
                found = (accounts[index].guestID == guestId);
            }
            return accounts[index];
        }

        // this method finds a hotel room based on the room ID, and returns the hotel room object
        public HotelRoom FindRoom(string hotelRoomId)
        {
            if (rooms.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (rooms[index].hotelRoomID == hotelRoomId);
            int count = rooms.Count;

            while (!(found) && (index < rooms.Count - 1))
            {
                index++;
                found = (rooms[index].hotelRoomID == hotelRoomId);
            }
            return rooms[index];
        }

        // this method finds a payment based on the payment ID, and returns the payment object
        public Payment FindPayment(string paymentId)
        {
            if (payments.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (payments[index].paymentID == paymentId);
            int count = payments.Count;

            while (!(found) && (index < payments.Count - 1))
            {
                index++;
                found = (payments[index].paymentID == paymentId);
            }
            return payments[index];
        }

        // this method finds a travel agent based on the travel agent ID, and returns the travel agent object
        public TravelAgent FindAgent(string travelAgentId)
        {
            if (agents.Count == 0)
            {
                return null;
            }
            int index = 0;
            bool found = (agents[index].TravelAgentId == travelAgentId);
            int count = agents.Count;

            while (!(found) && (index < agents.Count - 1))
            {
                index++;
                found = (agents[index].TravelAgentId == travelAgentId);
            }
            return agents[index];
        }

        // FindIndex methods: return the index of the object in the collection, or -1 if the object is not found, in simple terms, it returns the position of the object in the collection.
        public int FindIndex(Booking aBook)
        {
            int counter = 0;
            bool found = false;
            found = (aBook.bookingResNumber == bookings[counter].bookingResNumber);
            while (!(found) && (counter < bookings.Count - 1))
            {
                counter++;
                found = (aBook.bookingResNumber == bookings[counter].bookingResNumber);
            }
            if (found)
            {
                return counter; 
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for BookingRoom, what it does is it finds the index of the booking room in the collection, based on the booking reference number.
        public int FindIndexBookRoom(BookingRoom bookingRoom)
        {
            int counter = 0;
            bool found = false;
            found = (bookingRoom.bookingResNumber == bookingRooms[counter].bookingResNumber);
            while (!(found) && (counter < bookingRooms.Count - 1))
            {
                counter++;
                found = (bookingRoom.bookingResNumber == bookingRooms[counter].bookingResNumber);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for Guest, what it does is it finds the index of the guest in the collection, based on the guest ID.
        public int FindIndexGuest(Guest guest)
        {
            int counter = 0;
            bool found = false;
            found = (guest.guestID == guests[counter].guestID);
            while (!(found) && (counter < bookings.Count - 1))
            {
                counter++;
                found = (guest.guestID == guests[counter].guestID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for GuestAccount, what it does is it finds the index of the guest account in the collection, based on the guest ID.
        public int FindIndexAccount(GuestAccount account)
        {
            int counter = 0;
            bool found = false;
            found = (account.guestID == accounts[counter].guestID);
            while (!(found) && (counter < accounts.Count - 1))
            {
                counter++;
                found = (account.guestID == accounts[counter].guestID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for HotelRoom, what it does is it finds the index of the hotel room in the collection, based on the room ID.
        public int FindIndexRoom(HotelRoom room)
        {
            int counter = 0;
            bool found = false;
            found = (room.hotelRoomID == rooms[counter].hotelRoomID);
            while (!(found) && (counter < rooms.Count - 1))
            {
                counter++;
                found = (room.hotelRoomID == rooms[counter].hotelRoomID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for Payment, what it does is it finds the index of the payment in the collection, based on the payment ID.
        public int FindIndexPayment(Payment payment)
        {
            int counter = 0;
            bool found = false;
            found = (payment.paymentID == payments[counter].paymentID);
            while (!(found) && (counter < payments.Count - 1))
            {
                counter++;
                found = (payment.paymentID == payments[counter].paymentID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        // FindIndex method for TravelAgent, what it does is it finds the index of the travel agent in the collection, based on the travel agent ID.
        public int FindIndexAgent(TravelAgent agent)
        {
            int counter = 0;
            bool found = false;
            found = (agent.TravelAgentId == agents[counter].TravelAgentId); //in simple terms, it checks if the travel agent ID of the agent passed in is equal to the travel agent ID of the agent at the current index of the collection
            while (!(found) && (counter < agents.Count - 1)) 
            {
                counter++;
                found = (agent.TravelAgentId == agents[counter].TravelAgentId);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        } 
        #endregion

        #region Database Communication
        // Data Maintenance methods: makes changes to the collections in terms of adding, editing, or deleting an object.
        public void DataMaintenanceBooking(Booking booking, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in memory; 
            bookingDB.DataSetChangeBooking(booking, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    bookings.Add(booking); // Add the employee to the Collection
                    break;
                case DB.DBOperation.edit:
                    index = FindIndex(booking);
                    bookings[index] = booking;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndex(booking);
                    bookings.RemoveAt(index);
                    break;
            }
            
        }
        public void DataMaintenanceBookRoom(BookingRoom bookingRoom, DB.DBOperation operation)
        {
            int index = 0;
           
            bookingDB.DataSetChangeBookingRoom(bookingRoom, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    bookingRooms.Add(bookingRoom); 
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexBookRoom(bookingRoom);
                    bookingRooms[index] = bookingRoom;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexBookRoom(bookingRoom);
                    bookingRooms.RemoveAt(index);
                    break;
            }
           
        }
        public void DataMaintenanceGuest(Guest guest, DB.DBOperation operation)
        {
            int index = 0;
           
            bookingDB.DataSetChangeGuest(guest, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    guests.Add(guest); 
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexGuest(guest);
                    guests[index] = guest;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexGuest(guest);
                    guests.RemoveAt(index);
                    break;
            }
           
        }
        public void DataMaintenanceAccount(GuestAccount account, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChangeGuestAccount(account, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    accounts.Add(account);
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexAccount(account);
                    accounts[index] = account;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexAccount(account);
                    accounts.RemoveAt(index);
                    break;
            }
            
        }
        public void DataMaintenanceRoom(HotelRoom room, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChangeHotelRoom(room, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    rooms.Add(room);
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexRoom(room);
                    rooms[index] = room;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexRoom(room);
                    rooms.RemoveAt(index);
                    break;
            }
           
        }
        public void DataMaintenancePayment(Payment payment, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChangePayment(payment, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    payments.Add(payment);
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexPayment(payment);
                    payments[index] = payment;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexPayment(payment);
                    payments.RemoveAt(index);
                    break;
            }
           
        }
        public void DataMaintenanceAgent(TravelAgent agent, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChangeTravelAgent(agent, operation);
            switch (operation)
            {
                case DB.DBOperation.add:
                    agents.Add(agent);
                    break;
                case DB.DBOperation.edit:
                    index = FindIndexAgent(agent);
                    agents[index] = agent;
                    break;
                case DB.DBOperation.delete:
                    index = FindIndexAgent(agent);
                    agents.RemoveAt(index);
                    break;
            }
            
        }
        // Finalize changes methods: Commit the changes to the database
        public bool FinalizeChangesBooking(Booking booking)
        {
            
           return bookingDB.UpdateDataSource_Book(booking);
        }
        public bool FinalizeChangesBookingRoom(BookingRoom bookingRoom)
        {

            return bookingDB.UpdateDataSource_BookRoom(bookingRoom);
        }
        public bool FinalizeChangesGuest(Guest guest)
        {

            return bookingDB.UpdateDataSource_Guest(guest);
        }
        public bool FinalizeChangesAccount(GuestAccount account)
        {

            return bookingDB.UpdateDataSource_Account(account);
        }
        public bool FinalizeChangesRoom(HotelRoom room)
        {

            return bookingDB.UpdateDataSource_Room(room);
        }
        public bool FinalizeChangesPayment(Payment payment)
        {

            return bookingDB.UpdateDataSource_Payment(payment);
        }
        public bool FinalizeChangesTravelAgent(TravelAgent agent)
        {

            return bookingDB.UpdateDataSource_Agent(agent);
        }
        #endregion
        #region Methods 

        public List<HotelRoom> GetAvailableRooms()
        {
            List<HotelRoom> availableRooms = new List<HotelRoom>();

            foreach (HotelRoom room in bookingDB.AllHotelRooms)
            {
                if (room.roomStat == HotelRoom.RoomStatus.Available)
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }
        //This methods allow the receptionist to manage bookings according to the business rules, and communicate with the database through the BookingDB class.
        public Booking MakeBooking(Guest guest, List<HotelRoom> rooms, TravelAgent travelAgent, string bookingType, int numOfPeople, int numOfRooms,
                        DateTime checkInDate, DateTime checkOutDate, string specialRequirements)
        {
            // For the receptionist to make a new booking. It ensures that the booking abides by the business rules. 

            if (numOfPeople > 6)
            {
                MessageBox.Show("The number of people for a booking cannot exceed 6.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; // to stop booking from being created 
            }

            if (numOfRooms < 1 || numOfRooms > 3)
            {
                MessageBox.Show("The number of rooms for a booking must be between 1 and 3.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }


            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("The check in date must be before the check out date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            int bookingResNumber = Booking.generateBookingResNumber(); //generate a booking reservation number 

            Booking booking = new Booking(bookingResNumber, numOfPeople, numOfRooms, checkInDate, checkOutDate, specialRequirements, guest, rooms, travelAgent);

            string unavailableRoomID = booking.CheckRoomAvailability(); // the roomId that is unavailable 
            if (unavailableRoomID != null)
            {
                MessageBox.Show("The room " + unavailableRoomID + " is currently occupied. Please select a new room.", "Room Occupied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            bookings.Add(booking);
            DataMaintenanceBooking(booking, DB.DBOperation.add);
            FinalizeChangesBooking(booking);           // adding booking to the database 
            

            foreach (HotelRoom room in rooms) // loop for each room that the guest is booking 
            {
                booking.AddRoom(room.HotelRoomID, room.HotelID, room.RoomPrice, room.RoomCapacity); // add the room to the booking
                room.CheckIn(); //change the room status to "occupied"

                BookingRoom bookingRoom = new BookingRoom(bookingResNumber, room.HotelRoomID);

                bookingDB.DataSetChangeBookingRoom(bookingRoom, DB.DBOperation.add);
                bookingDB.UpdateDataSource_BookRoom(bookingRoom);
                bookingDB.DataSetChangeHotelRoom(room, DB.DBOperation.edit);
                bookingDB.UpdateDataSource_Room(room);
            }
           
            return booking;

        }

        // ChangeBooking method: allows the receptionist to change the details of an existing booking, and ensures that the changes abide by the business rules.
        public void ChangeBooking(int bookingResNumber, int newNumOfPeople, int newNumOfRooms,
                        DateTime newCheckInDate, DateTime newCheckOutDate, string newSpecialRequirements, List<HotelRoom> newRooms)
        {
            //For the receptionist to change the booking details as per the guest's request.
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
            booking.Rooms = newRooms;

            foreach (HotelRoom newRoom in newRooms) //for each room in the booking
            {
                newRoom.CheckIn(); // change the status of the new room to "occupied"
                bookingDB.DataSetChangeHotelRoom(newRoom, DB.DBOperation.edit);
                bookingDB.UpdateDataSource_Room(newRoom);

                BookingRoom newLink = new BookingRoom(booking.bookingResNumber, newRoom.HotelRoomID);
                bookingDB.DataSetChangeBookingRoom(newLink, DB.DBOperation.add);
                bookingDB.UpdateDataSource_BookRoom(newLink);
            }

            DataMaintenanceBooking(booking, DB.DBOperation.edit);
           FinalizeChangesBooking(booking); 
            //the new booking is now added to the database 
        }

        // CancelBooking method: allows the receptionist to cancel an existing booking, and changes the status of the booking to "cancelled".
        public void CancelBooking(int bookingResNumber)
        {
            Booking booking = Find(bookingResNumber); // find the booking reference number for the booking
            if (booking == null)
            {
                MessageBox.Show("The booking cannot be found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            booking.bookingStat = Booking.BookingStatus.Cancelled; // change the status of the booking to "cancelled".

            foreach (HotelRoom room in booking.Rooms)
            {
                
                room.CheckOut();
                BookingRoom bookingRoom = new BookingRoom(booking.bookingResNumber, room.HotelRoomID);
                bookingDB.DataSetChangeBookingRoom(bookingRoom, DB.DBOperation.delete);
                bookingDB.UpdateDataSource_BookRoom(bookingRoom);

               
                bookingDB.DataSetChangeHotelRoom(room, DB.DBOperation.edit);
                bookingDB.UpdateDataSource_Room(room);
            }

            DataMaintenanceBooking(booking, DB.DBOperation.edit);
            FinalizeChangesBooking(booking);
        }

        // EnquireBooking method: allows the receptionist to view the details of an existing booking, given the booking reservation number.
        public Booking EnquireBooking(int bookingResNumber)
        {
            return Find(bookingResNumber); // Find the booking details so that the receptionist can view it 
        }

        // ConfirmBooking method: allows the receptionist to confirm an existing booking, and changes the status of the booking to "confirmed".
        public void ConfirmBooking(int bookingResNumber)
        {
            Booking booking = Find(bookingResNumber);
            if (booking == null)
            {
                MessageBox.Show("The booking cannot be found.", "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            booking.bookingStat = Booking.BookingStatus.Confirmed; // change the booking status to "confirmed". 
            DataMaintenanceBooking(booking, DB.DBOperation.edit);
            FinalizeChangesBooking(booking);
        }
        #endregion
    }
}
