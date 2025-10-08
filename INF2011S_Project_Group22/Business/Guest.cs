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
        public string guestID;
       
       public string firstName;
       public string lastName;
        
       
        public string creditCardNumber;
        public string email;
       
        #endregion

        #region Property methods
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Constructors
        public Guest():base() //default constructor
        {
            guestID = "";
            firstName = "";
            lastName = "";
            creditCardNumber = "";
           email = "";
        }

        public Guest(string newGuestId, string newFirstName, string newLastName, string newEmail,string newCreditCardNumber):base() //parameterized constructor
        {
            guestID = newGuestId;
           firstName = newFirstName;
           lastName = newLastName;
           email = newEmail;
            creditCardNumber = newCreditCardNumber;
            
        }
        #endregion

        #region methods 
        public static string generateGuestId(string lastName) //generates a random guestId 
        {
            Random rand = new Random();
            lastName = lastName.ToLower();

            int randomNumber = rand.Next(10000, 100000); // generates a random number between 10000 and 99999

            
            string guestId = lastName + randomNumber.ToString(); // add the last name and the random number together 

            return guestId;

        }
        #endregion
    }

}
