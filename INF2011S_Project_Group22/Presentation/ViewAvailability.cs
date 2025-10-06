using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2011S_Project_Group22.Business;
using INF2011S_Project_Group22.Data;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class ViewAvailability: Form
    {
        private BookingController bookingController;

        public ViewAvailability()
        {
            InitializeComponent();
           
        }

        private void ShowRoomAvailability()
        {
            Collection<HotelRoom> allRooms = bookingController.AllHotelRooms;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAvailability_Load(object sender, EventArgs e)
        {
            bookingController = new BookingController();
        }

        private void lblUnavailable_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewAvailability_Load_1(object sender, EventArgs e)
        {

        }
    }
}
