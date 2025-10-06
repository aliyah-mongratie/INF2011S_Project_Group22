using INF2011S_Project_Group22.Business;
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
    public partial class ReservationDetails : Form
    {
        public ReservationDetails()
        {
            InitializeComponent();
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roomSelection()
        {

            CheckBox[] roomCheckBoxes = { cbRoom101, cbRoom102, cbRoom103, cbRoom104, cbRoom105 }; //Array of checkboxes for room selection

            TextBox[] roomTextBoxes = { txtRoom101, txtRoom102, txtRoom103, txtRoom104, txtRoom105 }; //Array of textboxes for number of people in each room


            //Textboxes are made visible based on the rooms selected by the user.


            //Loop through the checkboxes and textboxes to ensure that the user selects at least one room and enters the number of people for each selected room.

            int selectedRooms = 0;
            int noOfPeople = txtRoom101.Text.Length + txtRoom102.Text.Length + txtRoom103.Text.Length + txtRoom104.Text.Length + txtRoom105.Text.Length;
            for (int i = 0; i < roomCheckBoxes.Length; i++)
            {
                if (roomCheckBoxes[i].Checked)
                {
                    selectedRooms++;

                    //Validation for number of rooms available for selection

                    if (selectedRooms > 3)
                    {
                        MessageBox.Show("You can select a maximum of 3 rooms.");
                        return;
                    }
                    //Validation for number of people in each room

                    if (int.TryParse(roomTextBoxes[i].Text, out int noOfpeople))
                    {
                        if (noOfpeople < 1 || noOfpeople > 4)
                        {
                            MessageBox.Show("Please enter a valid number of people (1-4) for " + roomCheckBoxes[i].Text);
                            txtRoom101.Clear();
                            txtRoom102.Clear();
                            txtRoom103.Clear();
                            txtRoom104.Clear();
                            txtRoom105.Clear();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of people for " + roomCheckBoxes[i].Text);
                        return;

                    }
                    //Check room availability from the database
                    Booking booking = new Booking();

                    booking.CheckRoomAvailability();


                }

            }
        }
    }
}
