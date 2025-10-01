using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    class Hotel
    {
        // aliyah's part 

        #region Data Members 
        private string hotelID;
        private string hotelName;
        private string hotelAddress;
        private string hotelCity;
        private string hotelPostCode;
        private string hotelPhone;
        private string hotelEmail;
        private int noOfRooms;
        #endregion

        #region Property methods 

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        public string HotelAddress 
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }
        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }
        public string HotelPostCode
        {
            get { return hotelPostCode; }
            set { hotelPostCode = value; }
        }
        public string HotelPhone
        {
            get { return hotelPhone; }
            set { hotelPhone = value; }
        }
        public string HotelEmail
        {
            get { return hotelEmail; }
            set { hotelEmail = value; }
        }
        public int NoOfRooms
        {
            get { return noOfRooms; }
            set { noOfRooms = value; }
        }
        #endregion

        #region Constructors 
        public Hotel()
        {
            hotelID = "";
            hotelName = "";
            hotelAddress = "";
            hotelCity = "";
            hotelPostCode = "";
            hotelPhone = "";
            hotelEmail = "";
            noOfRooms = 0;
        }
        public Hotel(string newHotelID, string newHotelName, string newHotelAddress, string newHotelCity, string newHotelPostCode, string newHotelPhone, string newHotelEmail, int NewNoOfRooms)
        {
            hotelID = newHotelID;
            hotelName = newHotelName;
            hotelAddress = newHotelAddress;
            hotelCity = newHotelCity;
            hotelPostCode = newHotelPostCode;
            hotelPhone = newHotelPhone;
            hotelEmail = newHotelEmail;
            noOfRooms = NewNoOfRooms;
        }
        #endregion


    }
}
