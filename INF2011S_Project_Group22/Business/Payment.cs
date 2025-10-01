using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class Payment
    {
        #region data members
        private string paymentID;
        private string paymentStatus;
        private float paymentAmount;

        //foreign key
        public string BookingReservationNumber { get; set; }
        #endregion
        #region Constructors
        public Payment(string payID, string payStatus, float payAmount)
        {
            paymentID = payID;
            paymentStatus = payStatus;
            paymentAmount = payAmount;
        }
        #endregion

        #region Methods

        public string GetCreditCardCredentials()
        {
            // retrieved from secure bank provider via verification
            return "**** **** **** 1234";
        }

        public string GetPaymentStatus()
        {
            return paymentStatus;
        }

        public void UpdatePaymentStatus(string newStatus)
        {
            paymentStatus = newStatus;
        }


        #endregion
    }
}
