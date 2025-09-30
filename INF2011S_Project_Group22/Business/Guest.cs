using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class Guest : Person
    {
        //Munta's part
        #region Data Members
        //TEST
        public int guestID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int creditCardNumber;
        #endregion

        #region Property methods
        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public DateTime CheckInDate 
        { 
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public int CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }
        #endregion

        #region Constructors
        public Guest():base() //default constructor
        {
            checkInDate = DateTime.MinValue;
            checkOutDate = DateTime.MinValue;
            creditCardNumber = 0;
        }

        public Guest(DateTime newCheckInDate, DateTime newCheckOutDate, int newCreditCardNumber):base() //parameterized constructor
        {
            checkInDate = newCheckInDate;
            checkOutDate = newCheckOutDate;
            creditCardNumber = newCreditCardNumber;
        }
        #endregion

    }

}
