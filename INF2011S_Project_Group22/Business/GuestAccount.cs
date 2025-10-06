 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class GuestAccount
    {
        #region Enum
        public enum GuestStatusType // this is used to determine if the guest is new or existing
        {
            New,
            Existing
        }
        #endregion

        //Munta's part
        #region Data Members
        public string guestID;
        
        private string roomID;
        private int creditCardCredentials; // e.g. credit card number
        public enum AccountStatus
        {
            Active,
            Inactive,
            Closed
        }
        public AccountStatus accountStat { get; set; } // e.g. active, inactive, closed
        private decimal accountBalance; // e.g. current balance
        private decimal accountCharges; // e.g. charges incurred
        #endregion

        #region Property methods
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
      
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int CreditCardCredentials
        {
            get { return creditCardCredentials; }
            set { creditCardCredentials = value; }
        }
        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        public decimal AccountCharges
        {
            get { return accountCharges; } 
            set { accountCharges = value; }
        }
        #endregion

        #region Constructors
        public GuestAccount()
        {
            guestID = " ";
            roomID = "";
            creditCardCredentials = 0;
            accountStat = AccountStatus.Active;//default?
            accountBalance = 0.0m;
            accountCharges = 0.0m;
        }

        public GuestAccount(string newGuestID,  string newRoomID, int newCreditCardCredentials,  decimal newAccountBalance)
        {
            guestID = newGuestID;
            roomID = newRoomID;
            creditCardCredentials = newCreditCardCredentials;
            accountBalance = newAccountBalance;
        }
        #endregion

        #region Methods
        public void updateGuestAccount(decimal accountCharges) // method to update guest account balance by deducting charges incurred
        {
            accountBalance = accountBalance - accountCharges;
        }
        #endregion
    }
}
