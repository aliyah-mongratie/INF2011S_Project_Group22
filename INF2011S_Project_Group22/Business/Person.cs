using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    public abstract class Person //abstact because we will not be instantiating objects, but we will use it as a base class from which the receptionist, manager, travel agent and guest inherits from
    {
        //Imaan's section


        #region Data Members
        public string firstName;
        public string lastName;
        public string phoneNumber; //phone numbers have a leading zero. If int is used, it removes the leading zero. Due to this, phoneNumber will be saved as datatype string
        public string email;
        public string role;

        #endregion

#region Property Methods

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

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        #endregion
        #region  Constructors

        public Person ()// Default constructor
        {
            firstName = "";
            lastName = "";
            phoneNumber = "";
            email = "";
            role = "";
        }
        public Person(string fstName, string lstName, string cellPhoneNumber, string newEmail, string newRole)// Parameterized constructor
        {
            firstName = fstName;
            lastName = lstName;
            phoneNumber = cellPhoneNumber;
            email = newEmail;
            role = newRole;
        }

        #endregion


    }

}
