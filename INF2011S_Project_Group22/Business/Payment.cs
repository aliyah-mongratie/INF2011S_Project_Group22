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
        public string paymentID;//uniquely identifies payment
        public string guestId;//need guestID for payment /slip
        public enum PaymentStatus
        {
            pending,
            paid,
            unpaid
        }
        public PaymentStatus paymentStat { get; set; }//various statuses for payment to be in
        public decimal paymentAmount;//is it the same ad 

        //foreign key
        public string BookingReservationNumber { get; set; }
        #endregion
        #region Constructors
        public Payment()
        {
            paymentID = "";
            guestId = "";
            paymentStat = Payment.PaymentStatus.unpaid;
            paymentAmount = 0;
        }
        public Payment(string payID,  float payAmount, string newGuestId)
        {
            paymentID = payID;
            paymentStat = Payment.PaymentStatus.unpaid;
            paymentAmount = payAmount;
            guestId = newGuestId;
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
