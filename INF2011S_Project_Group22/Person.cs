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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        #endregion

        #region Default Constructor

        public Person()
        {
            firstName = " ";
            lastName = " ";
            phoneNumber =0;
            email = " ";
            role = " ";

        }
        #endregion

        #region Parameterized Constructor

        public Person(string firstName, string lastName, int phoneNumber, string email, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.role = role;
        }
        #endregion



    }

}
