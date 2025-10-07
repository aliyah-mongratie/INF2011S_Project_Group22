using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    class HotelRoom //aliyah
    {
        #region Data Members 
        public string hotelRoomID; // room number
      

        public string hotelID;//unique id of hotel in system
        public enum RoomStatus 
        {
            Available = 0,
            Occupied = 1
                
        }
        public RoomStatus roomStat;//various statuses that a room can be in
        public decimal roomPrice;//price of room
        public const int roomCapacity = 4;//capacity the room is allowed to have
        //should be linked to the UI when calculatin how many people per booking

        #endregion

        #region Property Methods 
        public string HotelRoomID
        {
            get { return hotelRoomID; }
            set { hotelRoomID = value; }
        }
        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }
        public RoomStatus getRoomStatus
        {
            get { return roomStat; }
            set { roomStat = value; }
        }
        public decimal RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }
      
        #endregion

        #region Constructors 
        public HotelRoom()
        {
            hotelRoomID = "";
            hotelID = "";
            roomStat = HotelRoom.RoomStatus.Available; //the default state of a room
            roomPrice = 0;
            
        }
        public HotelRoom(string newHotelRoomID, string newHotelID, decimal newRoomPrice)
        {
            hotelRoomID = newHotelRoomID;
            hotelID = newHotelID;
            roomStat = HotelRoom.RoomStatus.Available;
            roomPrice = newRoomPrice;
           
        }

        #endregion

        #region Methods 
        // To change the state of the room 
        public void CheckIn()
        {
            roomStat = RoomStatus.Occupied;
        }

        public void CheckOut()
        {
            roomStat = RoomStatus.Available;
        }
        #endregion
    }


}
