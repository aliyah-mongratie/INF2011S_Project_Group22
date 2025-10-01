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
        private string hotelRoomID;
        private string hotelID;
        public enum RoomStatus
        {
            Available = 0,
            Occupied = 1
                
        }
        protected RoomStatus roomStat;
        private decimal roomPrice;
        private int roomCapacity;

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
        public int RoomCapacity
        {
            get { return roomCapacity; }
            set { roomCapacity = value; }
        }
        #endregion

        #region Constructors 
        public HotelRoom()
        {
            hotelRoomID = "";
            hotelID = "";
            roomStat = HotelRoom.RoomStatus.Available;
            roomPrice = 0;
            roomCapacity = 0;
        }
        public HotelRoom(string newHotelRoomID, string newHotelID, decimal newRoomPrice, int newRoomCapacity)
        {
            hotelRoomID = newHotelRoomID;
            hotelID = newHotelID;
            roomStat = HotelRoom.RoomStatus.Available;
            roomPrice = newRoomPrice;
            roomCapacity = newRoomCapacity;
        }

        #endregion

        #region Methods 
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
