using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class GuestAccount
    {
        //Munta's part
        public int guestID { get; set; }
        public string guestStatus { get; set; }
        public int roomID { get; set; }
        public int creditCardCredentials { get; set; }
        public string accountStatus { get; set; }
        public decimal accountBalance { get; set; }
        public decimal accountCharges { get; set; } 

        public GuestAccount()
        {
            guestID = 0;
            guestStatus = " ";
            roomID = 0;
            creditCardCredentials = 0;
            accountStatus = " ";
            accountBalance = 0.0m;
            accountCharges = 0.0m;
        }

        public GuestAccount(int guestID, string guestStatus, int roomID, int creditCardCredentials, string accountStatus, decimal accountBalance)
        {
            this.guestID = guestID;
            this.guestStatus = guestStatus;
            this.roomID = roomID;
            this.creditCardCredentials = creditCardCredentials;
            this.accountStatus = accountStatus;
            this.accountBalance = accountBalance;
        }

        public void updateGuestAccount(decimal accountCharges) //
        {
            accountBalance = accountBalance - accountCharges;
        }
    }
}
