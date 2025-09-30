using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class Receptionist: Person
    {
        #region Data members
        public int receptionistID;
        #endregion

        #region Property Methods

        public int ReceptionistID
        {
            get { return receptionistID; }
            set { receptionistID = value; }
        }
        #endregion

        #region Constructors

        public Receptionist():base() //default constructor // Base is used to call the attributes in the default constructor of the parent/base class.
        {
            receptionistID = 0;

        }
   
        public Receptionist(int receptionistID, string firstName, string lastName, string phoneNumber, string email, string role) : base(firstName, lastName, phoneNumber, email, role) //parameterized constructor
        {
            this.receptionistID = receptionistID;
        }

        #endregion



        // Data members/ attributes inherited from the Person class

    }
}
