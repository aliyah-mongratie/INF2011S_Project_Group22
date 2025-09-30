using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class Receptionist
    {
        #region Data Members
        public string receptionistID;
        #endregion

        #region Property Methods
        public string ReceptionistID
        {
            get { return receptionistID; }
            set { receptionistID = value; }
        }
        #endregion
        #region Constructors
        public Receptionist(): base() //default constructor //base is used to call the parent class constructor, allowing the child class to inherit the properties and methods of the parent class
        {
            receptionistID = "";
        }
        public Receptionist(string receptionistID): base() //parameterized constructor
        {
            this.receptionistID = receptionistID;
        }


    }
}
