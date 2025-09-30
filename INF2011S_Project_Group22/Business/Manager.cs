using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22
{
    internal class Manager:Person
    {
        #region Data Members
         
        public int managerID;
        #endregion

        #region Property Methods

        public int ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }

        #endregion
        #region Constructors

        public Manager() : base() //default constructor 
        {
            managerID = 0;
        }

        //parameterized constructor
        public Manager(int managerID, string firstName, string lastName, string phoneNumber, string email, string role) : base(firstName, lastName, phoneNumber, email, role) //parameterized constructor
        {
            this.managerID = managerID;
        }
        #endregion




        // Data members/ attributes inherited from the Person class
    }
    #region Methods
    //View report method will go here
    #endregion 

}
