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
        private string guestID;
        private string guestStatus; // e.g. regular, vip, etc
        
        private GuestStatusType guestStatus;//i.e new or existing guest
        private int roomID;
        private int creditCardCredentials; // e.g. credit card number
        private string accountStatus; // e.g. active, inactive, closed
        private decimal accountBalance; // e.g. current balance
        private decimal accountCharges; // e.g. charges incurred
        #endregion

        #region Property methods
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public GuestStatusType GuestStatus
        {
            get { return guestStatus; }
            set { guestStatus = value; }
        }
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int CreditCardCredentials
        {
            get { return creditCardCredentials; }
            set { creditCardCredentials = value; }
        }
        public string AccountStatus
        {
            get { return accountStatus; }
            set { accountStatus = value; }
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
            guestID = 0;
            guestStatus = GuestStatusType.New;
            roomID = 0;
            creditCardCredentials = 0;
            accountStatus = " ";
            accountBalance = 0.0m;
            accountCharges = 0.0m;
        }

        public GuestAccount(int newGuestID, GuestStatusType newGuestStatus, int newRoomID, int newCreditCardCredentials, string newAccountStatus, decimal newAccountBalance)
        {
            guestID = newGuestID;
            guestStatus = newGuestStatus;
            roomID = newRoomID;
            creditCardCredentials = newCreditCardCredentials;
            accountStatus = newAccountStatus;
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
