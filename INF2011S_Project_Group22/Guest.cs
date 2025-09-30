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
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public int creditCardNumber { get; set; }


        public Guest()
        {
            checkInDate = DateTime.MinValue;
            checkOutDate = DateTime.MinValue;
            creditCardNumber = 0;
        }

        public Guest(string firstName, string lastName, string phoneNumber, string email, string role, DateTime checkInDate, DateTime checkOutDate, int creditCardNumber) : base(firstName, lastName, phoneNumber, email, role)
        {
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.creditCardNumber = creditCardNumber;
        }

    }

}
