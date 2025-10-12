using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static INF2011S_Project_Group22.HotelRoom;

namespace INF2011S_Project_Group22.Business
{
    public class Booking
    {
        #region data members
        //attributes
        public int bookingResNumber { get; set; }//(alphanumeric, 8–12 chars)
        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }
        public BookingStatus bookingStat { get; set; }//various statuses the booking can be in
        public List<HotelRoom> Rooms { get;  set; } = new List<HotelRoom>();//list of rooms chosen by guest
        public enum BookingType
        {
            Personal,
            TravelAgency
        }
        public BookingType bookingType { get; set; }//types of booking that can be made
        public int numOfPeople { get; set; } //max 6
        public int numOfRooms { get; set; } //1–3 rooms
        public DateTime checkInDate { get; set; }//checkin date chosen by guest
        public DateTime checkOutDate { get; set; }//checkout date chosen by guest
        public string specialRequirements { get; set; }//null??

        // Foreign Keys

        public string guestId { get; set; }
        public string travelAgentId { get; set; }
        public string hotelId { get; set; }
        #endregion
        #region Constructors
        public Booking()
        {
            bookingResNumber = 0;
            bookingStat = BookingStatus.Pending;
            bookingType = BookingType.Personal;
          
            numOfPeople = 0;
            numOfRooms = 0;
            checkInDate = DateTime.Now;
            checkOutDate = DateTime.Today.AddDays(1);
            specialRequirements = "";
            hotelId = new Hotel().HotelID; 
            guestId = new Guest().GuestID;
            Rooms = new List<HotelRoom>(3); 
            travelAgentId = new TravelAgent().TravelAgentId;    

        }
        public Booking(int newBookResNumber, string newGuestId,string newHotelId, string agentId,BookingStatus newBookingStatus, BookingType newBookingType, int newNumOfPeople, int newNumOfRooms, DateTime newCheckInDate, DateTime newCheckOutDate, string newSpecialRequirements, string newTravelAgentId = null)
        {
            bookingResNumber = newBookResNumber;
            bookingStat = newBookingStatus;
            bookingType = newBookingType;
            travelAgentId = agentId;
            numOfPeople = newNumOfPeople;
            numOfRooms = newNumOfRooms;
            checkInDate = newCheckInDate;
            checkOutDate = newCheckOutDate;
            specialRequirements = newSpecialRequirements;
            guestId = newGuestId;
            hotelId = newHotelId;
            travelAgentId = newTravelAgentId ?? string.Empty;//optional
        }

    

        #endregion

        #region Methods

     
        public static int generateBookingResNumber() //generates a random booking/reservation number
        {
            Random rand = new Random();
            return rand.Next(10000, 100000); // generates a random number between 10000 and 100000
        }
        public int GetBookingDuration(DateTime checkInDate, DateTime checkOutDate)
        {
            return (checkOutDate - checkInDate).Days;//calculates amount of days/nights stay for booking
        }

        public string CheckRoomAvailability() //checks if all rooms in the booking are available
        {
            
            
            foreach (var room in Rooms) // iterate through each room in the booking
            {
                if (room.getRoomStatus != HotelRoom.RoomStatus.Available) // check if the room is not available
                {
                    return room.HotelRoomID; // as soon as we find one unavailable room, stop and return its Id
                }
            }
            return null; // all rooms passed the check
        }

        //This method is used to add a room to the booking
        /*  public void AddRoom(string newHotelRoomID, string newHotelID) //add a room to teh booking
           {
              var newRoom = new HotelRoom(newHotelRoomID, newHotelID); //create a new room object

              // Change status to Occupied right after creation
              newRoom.roomStat = RoomStatus.Occupied;

              Rooms.Add(newRoom); //add the new room to the list of rooms in the booking

              MessageBox.Show($"Added Room {newHotelRoomID} ({newHotelID}) - Status: {newRoom.roomStat}");
              MessageBox.Show($"Count: {Rooms.Count}, Capacity: {Rooms.Capacity}");
          } */

        public decimal CalculateBookingAmount()
        {
            if (Rooms == null || Rooms.Count == 0) return 0;

            int nights = (checkOutDate - checkInDate).Days;
            if (nights <= 0) nights = 1;

            decimal total = 0;
            foreach (HotelRoom room in Rooms)
            {
                total += room.GetRoomPrice(checkInDate) * nights;
            }

            return total;
        }



        public decimal CalculateDeposit(decimal totalAmount)
        {
            // Deposit = 10% of total thats due 14 days before arrival
            return totalAmount * 0.10m;
        }

        #endregion
    }
}
