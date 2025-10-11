using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    public class HotelRoom //aliyah
    {
        #region Data Members 
        public string hotelRoomID; // room number
      

        public string hotelID;//unique id of hotel in system
        public enum RoomStatus 
        {
            Available,
            Occupied
                
        }
        public RoomStatus roomStat;//various statuses that a room can be in
       
        public int roomCapacity = 4;//capacity the room is allowed to have
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
            roomStat = HotelRoom.RoomStatus.Available; //the default state of a room
            roomCapacity = 4;
            
        }
        public HotelRoom(string newHotelRoomID, string newHotelID, RoomStatus status, int newCapacity)
        {
            hotelRoomID = newHotelRoomID;
            hotelID = newHotelID;
            roomStat = status;
            roomCapacity = newCapacity;
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

        public decimal GetRoomPrice(DateTime checkInDate) // this method figures out the season based on the booking date
        {
            decimal roomPrice = 0;
            // only December is being checked
            if (checkInDate.Month == 12)
            {
                // Low season starts from the first of December until the seventh
                if (checkInDate.Day >= 1 && checkInDate.Day <= 7)
                {
                    roomPrice = 550m;
                   
                }

                // Mid season starts from the 8th of december until the 15th
                else if (checkInDate.Day >= 8 && checkInDate.Day <= 15)
                {
                    
                    roomPrice = 750m;
                   
                }

                // High season starts from the 16th until the 31st
                else if (checkInDate.Day >= 16 && checkInDate.Day <= 31)
                {
                   
                    roomPrice = 995m;
                   
                }

                else
                {
                    
                    roomPrice = 550m;
                }
            }
            return roomPrice;
        }
        #endregion
    }


}
