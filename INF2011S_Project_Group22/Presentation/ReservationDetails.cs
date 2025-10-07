using INF2011S_Project_Group22.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static INF2011S_Project_Group22.HotelRoom;


namespace INF2011S_Project_Group22.Presentation
{
    public partial class ReservationDetails : Form
    {
        private int totRoomPeople = 0;//variable to hold initial value of the total number of people input in all textboxes 
        BookingController controller = new BookingController();//instance of controller class

        public ReservationDetails()
        {

            InitializeComponent();

            FillReservationDetails();

            

        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {
            DisplayAvailableRooms();

            
            /*cbRoom101 = new HotelRoom(101, HotelRoom.RoomStatus.Available, );
            cbRoom102 = new HotelRoom(102, HotelRoom.RoomStatus.Occupied);
            cbRoom103 = new HotelRoom(103, HotelRoom.RoomStatus.Available);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #region Methods
        public void getTotalRoomPeople()
        {
            int numberOfPeople = Convert.ToInt32(txtNoPeople.Text);

            

            while (txtNoPeople != null)
            {
              

                if (numberOfPeople > 0 && numberOfPeople < 7 )
                {
                    /*  if the number of people entered is < 7 then the room capacities added together
                    must also be < 7*/
                    while (totRoomPeople < 7)
                    {
                        DisplayAvailableRooms();
                    }
                    
                   
                }
                else
                {
                    // ❌ Conversion failed (user didn’t type a number)
                    MessageBox.Show("Please enter a valid number for guests.");
                }
            }
       
        }

        private void SetAvailableRooms(CheckBox cb, HotelRoom.RoomStatus roomStatus)
        {
            switch(roomStatus) 
            {
                case HotelRoom.RoomStatus.Available:
                    cb.Visible = true; break;
                case HotelRoom.RoomStatus.Occupied:
                    cb.Visible = false; break;

            }

        }
        public void DisplayAvailableRooms()
        {
            //displays the textboxes and checkboxes of only available rooms

            //  Get available rooms from the controller
            BookingController controller = new BookingController();
            List<HotelRoom> availableRooms = controller.GetAvailableRooms();

            foreach (HotelRoom room in availableRooms)
            {
                // Find the checkbox by name — for example: chkRoom101, chkRoom102, etc.
                Control[] foundControls = this.Controls.Find("chkRoom" + room.HotelRoomID, true); //Looks for a control (like a CheckBox) by name on the reservationDetails UI

                CheckBox cb = null;

                // Check if any control was found
                if (foundControls.Length > 0)
                {
                    cb = (CheckBox)foundControls[0]; // Take the first control found
                }

                // If the checkbox exists, show or hide it based on the room status
                if (cb != null)
                {
                    SetAvailableRooms(cb, room.roomStat);
                }



                //  Hide all room checkboxes first

                /*foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox cb && cb.Name.StartsWith("chkRoom"))
                    {
                        cb.Visible = false;//chk links the checkbox to a specific hotel room ID
                        cb.Enabled = false;
                    }
                }*/

                //  Show only available room checkboxes
                /* foreach (HotelRoom room in availableRooms)
                 {
                     string checkBoxName = "chk" + room.HotelRoomID; // e.g. "chkRoom101"
                     CheckBox roomCheckBox = this.Controls.Find(checkBoxName, true).FirstOrDefault() as CheckBox;

                     if (roomCheckBox != null)
                     {
                         roomCheckBox.Visible = true;
                         roomCheckBox.Enabled = true;
                     }
                 }

                 //  Handle case when no rooms are available
                 if (availableRooms.Count == 0)
                 {
                     MessageBox.Show("No rooms are currently available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }*/
            }
        }

        private List<HotelRoom> GetSelectedRooms()
        {
            // adds the checked rooms to a list and stores it for the booking by collecting user input and storing it
            List<HotelRoom> selectedRooms = new List<HotelRoom>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked && cb.Tag is HotelRoom room)
                {
                    selectedRooms.Add(room);
                }
            }

            return selectedRooms;

        }



        public void FillReservationDetails()
        {
            Booking booking=new Booking();
            int bookingResNumber = booking.bookingResNumber;

            try
            {


                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HotelBookingDB.mdf;Integrated Security=True"))//Connection string to connect to the database. This allows us to connect to the database without exposing sensitive information.
                {
                    //These using statement ensures that the connection is properly disposed of after use, preventing potential memory leaks. what the method does is it checks if the booking number exists in the database.
                    connection.Open();

                    string query = "SELECT * FROM Booking WHERE BookingResNumber = @BookingResNumber";
                    SqlCommand command = new SqlCommand(query, connection);//SqlCommand is used to execute the query against the database.
                    command.Parameters.AddWithValue("@BookingResNumber", bookingResNumber);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["GuestFirstName"].ToString();
                        txtLastName.Text = reader["GuestLastName"].ToString();
                        txtNoRoomsReq.Text = reader["NumberOfRooms"].ToString();
                        txtNoPeople.Text = reader["NumberOfGuests"].ToString();
                        txtCheckInDate.Text = Convert.ToDateTime(reader["CheckInDate"]).ToString("yyyy-MM-dd");
                        txtCheckOutDate.Text = Convert.ToDateTime(reader["CheckOutDate"]).ToString("yyyy-MM-dd");
                        txtSpecialRequirements.Text = reader["SpecialRequirements"].ToString();
                        txtEmail.Text = reader["GuestEmail"].ToString();
                    }
                    else
                    {
                        //If the booking number does not exist, display a message to the user and clear all input fields.
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtNoRoomsReq.Clear();
                        txtNoPeople.Clear();
                        txtCheckInDate.Clear();
                        txtCheckOutDate.Clear();
                        txtSpecialRequirements.Clear();
                        txtEmail.Clear();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the reservation details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

      
    }
}
