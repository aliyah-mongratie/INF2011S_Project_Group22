using INF2011S_Project_Group22.Data;
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
            paymentStat = Payment.PaymentStatus.unpaid;//default status
            paymentAmount = 0;
        }
        public Payment(string payID, string newGuestId, Payment.PaymentStatus payStatus, decimal payAmount)
        {
            paymentID = payID;
            paymentStat = Payment.PaymentStatus.unpaid;//defualt status
            paymentAmount = payAmount;
            guestId = newGuestId;
            paymentStat = payStatus;
        }
        #endregion

        #region Methods

        public string GetCreditCardCredentials()
        {
            // retrieved from secure bank provider via verification
            return "**** **** **** 1234";//default
        }

        public string GetPaymentStatus()
        {
            return paymentStat.ToString();//fetches the oayment status, defualt
        }

        public void UpdatePaymentStatus(PaymentStatus newStatus)
        {
            paymentStat = newStatus;//fetches the new status according to the booking /guest account statuses
        }

        public static int generatePaymentId() //generates a random booking/reservation number
        {
            Random random = new Random();
            return random.Next(10000, 100000); // generates a random number between 10000 and 100000
        }
        public int GetBookingDuration(DateTime checkInDate, DateTime checkOutDate)
        {
            return (checkOutDate - checkInDate).Days;//calculates amount of days/nights stay for booking
        }

       

        #endregion
    }
}
