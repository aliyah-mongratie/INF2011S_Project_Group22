using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_Project_Group22.Business
{
    internal class TravelAgent : Person
    {
        #region Data Members
        // Travel Agent inherits from Person
        public string TravelAgentId { get; set; }
        public string AgencyName { get; set; }
        #endregion
    }
}
