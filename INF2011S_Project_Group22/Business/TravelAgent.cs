using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    public class TravelAgent : Person
    {
        #region Data Members
        // Travel Agent inherits from Person
        public string TravelAgentId { get; set; }
        public string AgencyName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        

        #endregion
        #region Constructors 
        public TravelAgent()
        {
            TravelAgentId = "";
            AgencyName = "";
            firstName = "";
            lastName = "";
            phoneNumber = "";
            email = "";
        }
        public TravelAgent(string newAgentId, string newAgencyName, string newFirstName, string newLastName, string newPhone, string newEmail)
        {
            TravelAgentId = newAgentId;
            AgencyName = newAgencyName;
            firstName = newFirstName;
            lastName = newLastName;
            phoneNumber = newPhone;
            email = newEmail;
        }
        #endregion
        #region Methods 
        public static string generateAgentId(string agencyName) //generates a random guestId 
        {
            Random rand = new Random();
             agencyName = agencyName.ToLower();

            int randomNumber = rand.Next(10000, 100000); // generates a random number between 10000 and 99999


            string agentId = agencyName + randomNumber.ToString(); // add the last name and the random number together 

            return agentId;

        }
        #endregion
    }
}
