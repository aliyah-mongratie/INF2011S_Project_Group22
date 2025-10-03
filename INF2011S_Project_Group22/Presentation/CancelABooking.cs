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
    public partial class frmCancelABooking : Form
    {
        public frmCancelABooking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Once bookingController is done, we will use the first name, last name and booking number to find the booking in the database and cancel/delete it.
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int bookingNumber = int.Parse(txtEnterResNumber.Text);

            frmBookingCancellation newBookingCancellation = new frmBookingCancellation();
            newBookingCancellation.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
