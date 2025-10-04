using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class ViewAvailability : Form
    {
        public ViewAvailability()
        {
            InitializeComponent();
        }

        private void ViewAvailability_Load(object sender, EventArgs e)
        {
            
           roomSelection();


        }
        private void roomSelection()
        {
            /*We use lists to store data about the rooms and the amount of people in each room. Lists are dynamic and easy to use, making them a good choice for this task
            The usage of lists will also be useful to loop through and see how many people are in each room*/

            // Create a list with all the rooms 
            List<int> rooms = new List<int>();
            //List for the amount of people in each room
            List<int> peopleInRoom = new List<int>();

            

            //Check which rooms are selected first
            if (cbRoom101.Checked) rooms.Add(1);
            if (cbRoom102.Checked) rooms.Add(2);
            if (cbRoom103.Checked) rooms.Add(3);
            if (cbRoom104.Checked) rooms.Add(4);
            if (cbRoom105.Checked) rooms.Add(5);

            //The textboxes will be invisible until the user selects the corresponding room checkbox

            if (cbRoom101.Checked)
            {
                txtRoom101.Visible = true;
            }
            else
            {
                txtRoom101.Visible = false;
            }

            if (cbRoom102.Checked)
            {
                txtRoom102.Visible = true;
            }
            else  
            {
                txtRoom102.Visible = false;
            }

            if (cbRoom103.Checked)
            {
                txtRoom103.Visible = true;
            }
            else
            {
                txtRoom103.Visible = false;
            }

            if (cbRoom104.Checked)
            {
                txtRoom104.Visible = true;
            }
            else
            {
                txtRoom104.Visible = false;
            }

            if (cbRoom105.Checked)
            {
                txtRoom105.Visible = true;
            }
            else
            {
                txtRoom105.Visible = false;
            }


                //Validation for the amount of rooms booked
            if (rooms.Count == 0)
            {
                MessageBox.Show("Please select at least one room");
            }
            else if (rooms.Count > 3)
            {
                MessageBox.Show("There is a maximum of 3 rooms that can be booked at once");
            }

            //Check how many people are in each room
            foreach (int room in rooms)
            {
                int peopleInRoomCount = 0; //Create the counter for the amount of people in each room, initialized to 0.
                /*TryParse is used to convert the text from the textboxes to integers. 
                 * If the conversion fails, peopleInRoomCount will remain 0. 
                 * TryParse will allow us to handle exceptions that the user might make.It allows for better error handling and prevents the application from crashing due to invalid input.*/
                switch (room)
                {
                    case 1:
                        int.TryParse(txtRoom101.Text, out peopleInRoomCount);
                        break;
                    case 2: 
                        int.TryParse(txtRoom102.Text, out peopleInRoomCount);
                        break;
                    case 3:
                        int.TryParse(txtRoom103.Text, out peopleInRoomCount);
                        break;
                    case 4: 
                        int.TryParse(txtRoom104.Text, out peopleInRoomCount);
                        break;
                    case 5:
                        int.TryParse(txtRoom105.Text, out peopleInRoomCount);
                        break;
                    default:
                        break;

                }
                if (peopleInRoomCount < 0 || peopleInRoomCount > 4)
                {
                    MessageBox.Show("Please enter a valid number of people for room " + room + " (0-4)");
                    return;
                }

                peopleInRoom.Add(peopleInRoomCount);
                //Adding the amount of people in each room to the list
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If the user is satisfied with the room selection, they can proceed to the reservation form
            frmCreateReservation newForm = new frmCreateReservation();
            newForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if the user wants to carry out a different functionality, the back button directs them back to the homepage.
            this.Close();// close is used, since the homepage is already open in the background.
        }
    }
}
