using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ReservationDetails newForm= new ReservationDetails();
            newForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
        }
    }
}
