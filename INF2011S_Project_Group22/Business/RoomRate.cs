using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class RoomRate
    {
        #region Data Members
        public int roomRateID;
        public string rate;

        #endregion

        #region Property Methods
        
        public int RoomRateID
        {
            get { return roomRateID; }
            set { roomRateID = value; }
        }
        public string Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        #endregion
        #region Constructors

        public RoomRate() // Default constructor
        {
            roomRateID = 0;
            rate = "";
        }
        public RoomRate(int roomRateID, string rate) // Parameterized constructor
        {
            this.roomRateID = roomRateID;
            this.rate = rate;
        }
        #endregion



    }
}
