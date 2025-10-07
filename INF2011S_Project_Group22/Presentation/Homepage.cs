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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnMakeABooking_Click(object sender, EventArgs e)
        {
            ViewAvailability newForm = new ViewAvailability(); //Open the availability form when the make a booking button is clicked
            newForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAvailability_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelABooking_Click(object sender, EventArgs e)
        {
            frmCancelABooking newForm = new frmCancelABooking();
            newForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReservationEnquiry newForm = new frmReservationEnquiry();
            newForm.ShowDialog();
        }

       
    }
}
