using INF2011S_Project_Group22.Business;
using INF2011S_Project_Group22.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class ReservationEnquiry : Form
    {
        public ReservationEnquiry()
        {
            InitializeComponent();
        }

        private void ReservationEnquiry_Load(object sender, EventArgs e)
        {

        }

        #region Enquiry Validation Method
        public void EnquiryValidation()
        {
            

           

            #endregion





        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            
            ReservationDetails newform= new ReservationDetails();
            newform.ShowDialog();
 


        }
            


        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
