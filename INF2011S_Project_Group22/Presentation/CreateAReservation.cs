using INF2011S_Project_Group22.Business;
using INF2011S_Project_Group22.Data;
using INF2011S_Project_Group22.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static INF2011S_Project_Group22.Business.Booking;




namespace INF2011S_Project_Group22
{
    public partial class frmCreateReservation : Form
    {
        private Booking booking;
        private BookingType bookingType;
        private BookingController bookingController;
        private int totRoomPeople = 0;//variable to hold initial value of the total number of people input in all textboxes 
        public frmCreateReservation()
        {
            InitializeComponent();

           
           
            BookingController bookingController = new BookingController(); //instantiate the booking controller class to use its methods



        }
        #region Validation Method
        private void EnterDetailsValidation()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int numberOfPeople = int.Parse(txtNumPeople.Text);
            int numberOfRooms = int.Parse(txtNumRooms.Text);
            DateTime checkInDate;
            DateTime checkOutDate;

            try
            {
                checkInDate = DateTime.Parse(txtCheckInDate.Text);//parsing to the textboxes
                checkOutDate = DateTime.Parse(txtCheckOutDate.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid dates (e.g. 10/10/2025).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //If the personal booking is chosen, the user will be directed to the payment form. If not, they will be directed to the confirmed booking form.
            //The assumption is that personal bookings will always require payment, while travel agent bookings will be handled by the travel agent.

            if (rbPersonalBooking.Checked)
            {
                bookingType = BookingType.Personal;
                frmMakePayment newForm = new frmMakePayment();
                newForm.ShowDialog();
            }
            else if (rbTravelAgencyBooking.Checked)
            {
                bookingType = BookingType.TravelAgency;
                BookingConfirmation newForm = new BookingConfirmation();
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a booking type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //

            //Validation for first name and last name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)) // if the name fields (first or last) are empty or just whitespace, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("First Name and Last Name are required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit)) // if the name fields (first or last) contain any digits, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("First Name and Last Name cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstName.Length > 50 || lastName.Length > 50) // if the name fields (first or last) are longer than 50 characters, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("First Name and Last Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validation for number of people
            if (numberOfPeople == 0) // if the number of people is 0, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The number of people cannot be zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numberOfPeople < 1 || numberOfPeople > 6) // if the number of people is less than 1 or more than 6, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The number of people must be between 1 and 6.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validation for number of rooms
            if (numberOfRooms == 0) // if the number of rooms is 0, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The number of rooms cannot be zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (numberOfRooms < 1 || numberOfRooms > 3) // if the number of rooms is less than 1 or more than 3, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The number of rooms must be between 1 and 3.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validation for check-in and check-out dates

            //Make sure the dates are valid
            

            if (checkInDate < DateTime.Today) // if the check-in date is before today's date, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The check-in date cannot be in the past.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (checkOutDate <= checkInDate)
            {
                MessageBox.Show("The check-out date must be after the check-in date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Check-in date: {txtCheckInDate.Text}, Check-out date: {txtCheckOutDate.Text}");
            }

            //Special Requirements validation
            string specialRequirements = txtSpecialReq.Text;
            if (specialRequirements.Length > 200) // if the special requirements field is longer than 200 characters, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("Special Requirements cannot exceed 200 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Email validation
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check if the email contains '@' and '.'
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email must contain '@' and '.' characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all validations pass, proceed with reservation creation
        }
        #endregion
        #region Methods Available rooms
       
        public void getTotalRoomPeople()
        {
            int numberOfPeople = Convert.ToInt32(txtNumPeople.Text);



            while (txtNumPeople != null)
            {


                if (numberOfPeople > 0 && numberOfPeople < 7)
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
            switch (roomStatus)
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

        #endregion



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateResNext_Click(object sender, EventArgs e)
        {
            


            //Show a message box if any of the required fields are empty when the next button is clicked
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNumPeople.Text) ||
                string.IsNullOrWhiteSpace(txtNumRooms.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            EnterDetailsValidation(); //Call the method to validate the input fields




            // initiate the objects so it can be passed to the MakeBooking method
            Guest guest = new Guest();
            guest.FirstName = txtFirstName.Text;
            guest.LastName = txtLastName.Text;
            guest.Email = txtEmail.Text;
            DateTime checkInDate, checkOutDate;
            DateTime.TryParse(txtCheckInDate.Text, out checkInDate);
            DateTime.TryParse(txtCheckOutDate.Text, out checkOutDate);
            guest.CheckInDate = checkInDate;
            guest.CheckOutDate = checkOutDate;
            List<HotelRoom> rooms = new List<HotelRoom>(); //Create a new list to store the rooms that will be booked
            TravelAgent travelAgent = new TravelAgent(); //Create a new travel agent object, it will be populated if the booking type is travel agent
           
            int numOfPeople = int.Parse(txtNumPeople.Text); //Parse the number of people from the textbox
            BookingType bookingType= (rbPersonalBooking.Checked) ? BookingType.Personal : BookingType.TravelAgency; //Determine the booking type based on the selected radio button
            int numOfRooms = int.Parse(txtNumRooms.Text); //Parse the number of rooms from the textbox
            
            string specialRequirements = txtSpecialReq.Text; //Get the special requirements from the textbox


            //Call the MakeBooking method from the BookingController class to create a new booking
            BookingController bookingController = new BookingController();
            Booking booking = bookingController.MakeBooking(
                guest,
                rooms,
                travelAgent,
                numOfPeople.ToString(),
                (int)bookingType, // Convert BookingType enum to int
                numOfRooms,
                checkInDate,      // Pass checkInDate as DateTime
                checkOutDate,
                specialRequirements // Pass checkOutDate as DateTime
                                
            );
            




            BookingConfirmation newForm = new BookingConfirmation(); //Open the booking confirmation form once the details have been entered and validated
            newForm.ShowDialog();


        }

        private void btnCreateResClear_Click(object sender, EventArgs e)
        {

            //Clearing all textboxes after clicking the clear button
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNumPeople.Clear();
            txtNumRooms.Clear();
            txtCheckInDate.Clear();
            txtCheckOutDate.Clear();
            txtSpecialReq.Clear();
            txtEmail.Clear();

            txtFirstName.Focus();
        }

        private void btnCreateResExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            DisplayAvailableRooms();


            /*cbRoom101 = new HotelRoom(101, HotelRoom.RoomStatus.Available, );
            cbRoom102 = new HotelRoom(102, HotelRoom.RoomStatus.Occupied);
            cbRoom103 = new HotelRoom(103, HotelRoom.RoomStatus.Available);*/
        }

    }
}
