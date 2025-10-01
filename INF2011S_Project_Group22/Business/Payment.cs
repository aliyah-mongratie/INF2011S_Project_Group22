using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static INF2011S_Project_Group22.Business.Booking;

namespace INF2011S_Project_Group22.Business
{
    internal class Payment
    {
        #region data members
        private string paymentID;
        public enum PaymentStatus
        {
            pending,
            paid,
            unpaid
        }
        public PaymentStatus paymentStat { get; set; }
        private float paymentAmount;

        //foreign key
        public string BookingReservationNumber { get; set; }
        #endregion
        #region Constructors
        public Payment(string payID,  float payAmount)
        {
            paymentID = payID;
            paymentStat = Payment.PaymentStatus.unpaid;
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
            return paymentStat.ToString();
        }

        public void UpdatePaymentStatus(PaymentStatus newStatus)
        {
            paymentStat = newStatus;
        }


        #endregion
    }
}
