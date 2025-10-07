using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class Season
    {
        #region Fields
        private int seasonID; //Unique season ID
        private string seasonName; //Name of Season
        private DateTime startDate; //Starting date of the season
        private DateTime endDate; //End date of the season
        private decimal roomRate; // the price of the room per night
        #endregion

        #region Constructors
        public Season(int seasonId) // Assigning the seasonId when a season object is created
        {
            this.seasonID = seasonId;
        }

        public int SeasonId
        {
            get { return seasonID; }
            set { seasonID = value; }
        }
        public string SeasonName
        {
            get { return seasonName; }
            set { seasonName = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public decimal RoomRate
        {
            get { return roomRate; }
            set { roomRate = value; }
        }
        #endregion

        #region Methods 

        //PUT IN BOOOKING CLASS!!!!!!
        public void GetSeasonDate(DateTime bookingDate) // this method figures out the season based on the booking date
        {
            // only December is being checked
            if (bookingDate.Month == 12)
            {
                // Low season starts from the first of December until the seventh
                if (bookingDate.Day >= 1 && bookingDate.Day <= 7)
                {
                    seasonName = "Low Season";
                    roomRate = 550m;
                    startDate = new DateTime(bookingDate.Year,12,1);
                    endDate = new DateTime(bookingDate.Year, 12, 7);
                }

                // Mid season starts from the 8th of december until the 15th
                else if (bookingDate.Day >= 8 && bookingDate.Day <= 15)
                {
                    seasonName = "Mid Season";
                    roomRate = 750m;
                    startDate = new DateTime(bookingDate.Year, 12, 8);
                    endDate = new DateTime(bookingDate.Year, 12, 15);
                }

                // High season starts from the 16th until the 31st
                else if (bookingDate.Day >= 16 && bookingDate.Day <= 31)
                {
                    seasonName = "High Season";
                    roomRate = 995m;
                    startDate = new DateTime(bookingDate.Year, 12, 16);
                    endDate = new DateTime(bookingDate.Year, 12, 31);
                }

                else
                {
                    seasonName = "Invalid Date";
                    roomRate = 0m;
                }
            }
            // Occurs for all months that aren't December
            else
            {
                seasonName = "It is not in December season";
                roomRate = 0m;
            }
        }
        #endregion
    }
}
