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
        private void SetRoomStatus(Label label, HotelRoom.RoomStatus roomStatus)
        {
            // Method to change the colour of the label based on the room status. YellowGreen = available and Crimson = Occupied.
            switch(roomStatus)
            {
                case HotelRoom.RoomStatus.Available:
                    label.ForeColor = Color.YellowGreen;

                    break;
                case HotelRoom.RoomStatus.Occupied:
                    label.ForeColor = Color.Crimson;
                    break;

            }

        }

        private void ShowRoomAvailability()
        {
            //Display the room availability based on the HotelRoomId and its status
            Collection<HotelRoom> allRooms = bookingController.AllHotelRooms;
            foreach (HotelRoom room in allRooms)
            {
                switch (room.HotelRoomID)
                {
                    case "101":
                        SetRoomStatus(lblStatus101, room.roomStat);
                        break;
                    case "102":
                        SetRoomStatus(lblStatus102, room.roomStat);
                        break;
                    case "103":
                        SetRoomStatus(lblStatus103, room.roomStat);
                        break;
                    case "104":
                        SetRoomStatus(lblStatus104, room.roomStat);
                        break;
                    case "105":
                        SetRoomStatus(lblStatus105, room.roomStat);
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewAvailability_Load(object sender, EventArgs e)
        {
            bookingController = new BookingController();

            ShowRoomAvailability(); // Display the room availability when the form loads
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

        private void btnResDetails_Click(object sender, EventArgs e)
        {
            frmCreateReservation newform = new frmCreateReservation(); //Open the reservation details form to create a reservation 
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
