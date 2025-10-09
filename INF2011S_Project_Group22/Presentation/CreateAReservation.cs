using INF2011S_Project_Group22.Business;
using INF2011S_Project_Group22.Data;
using INF2011S_Project_Group22.Presentation;
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
using static INF2011S_Project_Group22.Business.Booking;




namespace INF2011S_Project_Group22
{
    public partial class frmCreateReservation : Form
    {
        private Booking booking;
        private BookingType bookingType;
        private HotelRoom room;
        private BookingController bookingController;
        private int totRoomPeople = 0;//variable to hold initial value of the total number of people input in all textboxes 
        public frmCreateReservation()
        {
            InitializeComponent();


            bookingController = new BookingController(); //instantiate the booking controller class to use its methods
            booking = new Booking();
            room = new HotelRoom();
            //Make all error labels invisible when the form loads

            HideErrorLabels();

        }
        private void HideErrorLabels()
        {
            lblFNameErr.Visible = false;
            lblLNameErr.Visible = false;
            lblNoOfPeopleErr.Visible = false;
            lblCheckInDateErr.Visible = false;
            lblCheckOutDateErr.Visible = false;
            lblEmailErr.Visible = false;
            lblNoOfRoomsErr.Visible = false;
            lblSpecialReqErr.Visible = false;
            lblBookingTypeErr.Visible = false;
            lblRoomSelectionErr.Visible = false;
            lblPhoneNumberErr.Visible = false;
        }
        #region Validation Method
        private bool EnterDetailsValidation()
        {
            HideErrorLabels(); //Hide all error labels at the start of validation

            // Collect user input from textboxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string specialRequirements = txtSpecialReq.Text;

            bool valid = true;



            //First and Last names are required fields 
            if (string.IsNullOrWhiteSpace(firstName))
            {
                lblFNameErr.Text = "First Name is required.";
                lblFNameErr.Visible = true;
                txtFirstName.Clear();
                return false;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                lblLNameErr.Text = "Last Name is required.";
                lblLNameErr.Visible = true;
                txtLastName.Clear();
                return false;
            }

            //Name validation- no numbers allowed
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                lblFNameErr.Text = "Names cannot contain numbers.";
                lblLNameErr.Text = "Names cannot contain numbers.";

                lblFNameErr.Visible = true;
                lblLNameErr.Visible = true;

                txtFirstName.Clear();
                txtLastName.Clear();
                valid = false;
            }

            //Number of people validation
            if (!int.TryParse(txtNumPeople.Text, out int numberOfPeople) || numberOfPeople < 1 || numberOfPeople > 6)
            {
                lblNoOfPeopleErr.Text = "Number of people must be between 1 and 6.";
                lblNoOfPeopleErr.Visible = true;

                txtNumPeople.Clear();
                valid = false;
            }

            //Number of rooms validation
            if (!int.TryParse(txtNumRooms.Text, out int numberOfRooms) || numberOfRooms < 1 || numberOfRooms > 3)
            {
                lblNoOfRoomsErr.Text = "Number of rooms must be between 1 and 3.";
                lblNoOfRoomsErr.Visible = true;

                txtNumRooms.Clear();
                valid = false;
            }

            //Validation for email- must contain "@" and "."

            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                lblEmailErr.Text = "Please enter a valid email address.";
                lblEmailErr.Visible = true;
                txtEmail.Clear();
                valid = false;
            }

            //Validation for special requirements- no longer than 200 characters


            if (specialRequirements.Length > 200)
            {

                lblSpecialReqErr.Text = "Special requirements cannot exceed 200 characters.";
                lblSpecialReqErr.Visible = true;

                txtSpecialReq.Clear();
                valid = false;
            }

            //Validation for phone numbers 
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                lblPhoneNumberErr.Text = "Phone number is required.";
                lblPhoneNumberErr.Visible = true;
                txtPhoneNumber.Clear();
                valid = false;

            }
            if (!phoneNumber.All(char.IsDigit) || phoneNumber.Length != 10)
            {
                lblPhoneNumberErr.Text = "Phone number must be 10 digits.";
                lblPhoneNumberErr.Visible = true;
                txtPhoneNumber.Clear();
                valid = false;
            }
            else
            {
                lblPhoneNumberErr.Visible = false;
            }

            return valid;

        }
        private bool ValidateRoomSelection(CheckBox cb, TextBox txt) //Method to help validate rooms
        {
            if (!cb.Checked) return true;
            if (!int.TryParse(txt.Text, out int num) || num < 1 || num < 4)
            {
                lblRoomSelectionErr.Text = "Number of people must be between 1 & 4";
                lblRoomSelectionErr.Visible = true;
                txt.Clear();
                return false;
            }
            return true;
        }
        // If all validations pass, proceed with reservation creation


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
            //makes the rooms that are available visible in the checkboxes
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

            foreach (Control ctrl in gBoxRoomPeople.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked && cb.Tag is HotelRoom room)
                {
                    selectedRooms.Add(room);
                }
            }

            return selectedRooms;

        }








        private decimal CalculateBookingAmount()
        {

            HideErrorLabels(); //Hide all error labels at the start of calculation

            //Declare date variables
            DateTime checkInDate;
            DateTime checkOutDate;

            //Validate and parse dates
            if (!DateTime.TryParse(txtCheckInDate.Text, out checkInDate) || !DateTime.TryParse(txtCheckOutDate.Text, out checkOutDate))
            {
                lblCheckInDateErr.Text = lblCheckOutDateErr.Text = "Please enter valid check in and check out dates.";
                lblCheckInDateErr.Visible = lblCheckOutDateErr.Visible = true;
                return 0;
            }

            //declare selected rooms variable
            List<HotelRoom> selectedRooms = GetSelectedRooms();

            //Validate date logic
            //Get the selected rooms

            MessageBox.Show($"Selected rooms: {selectedRooms?.Count}");

            int nights = (checkOutDate - checkInDate).Days;
            if (nights <= 0)
            {
                lblCheckOutDateErr.Text = "Check-out date must be after check-in date.";
                lblCheckOutDateErr.Visible = true;
                return 0;
            }
            decimal total = 0;
            foreach (var room in selectedRooms)
            {
                total += room.GetRoomPrice(checkInDate) * nights;
            }


            //var selectedRooms = GetSelectedRooms();
            if (selectedRooms == null || selectedRooms.Count == 0)
            {
                lblRoomSelectionErr.Text = "Please select at least one room.";
                lblRoomSelectionErr.Visible = true;

                return 0;
            }
            if (selectedRooms.Count > int.Parse(txtNumRooms.Text))
            {
                lblRoomSelectionErr.Text = "You have selected more rooms than specified.";
                lblRoomSelectionErr.Visible = true;
                return 0;
            }
            if (selectedRooms.Count < int.Parse(txtNumRooms.Text))
            {
                lblRoomSelectionErr.Text = "You have selected fewer rooms than specified.";
                lblRoomSelectionErr.Visible = true;
                return 0;
            }
            //Validate room capacities
            int totalCapacity = 0;
            foreach (HotelRoom room in selectedRooms)
            {
                // Assuming each room has a Capacity property
                totalCapacity += 4; // Each room can accommodate up to 4 people
            }

            //Calculate total price
            decimal totalBookingPrice = 0;

            foreach (HotelRoom selectedRoom in selectedRooms)
            {
                decimal roomPrice = selectedRoom.GetRoomPrice(checkInDate);
                totalBookingPrice += roomPrice * nights;
            }

            return totalBookingPrice;
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






            if (!EnterDetailsValidation())
            {
                return;
            }
            if (!rbPersonalBooking.Checked && !rbTravelAgencyBooking.Checked)
            {
                lblBookingTypeErr.Text = "Please select a booking type.";
                lblBookingTypeErr.Visible = true;
                return;

            }

            decimal total = CalculateBookingAmount();
            if (total <= 0) return;
            MessageBox.Show($"The Total Booking Amount Is: {total.ToString("C")} \r\n The Total Number Of Rooms Booked Is: {GetSelectedRooms().Count}");

            /*Show a message box if any of the required fields are empty when the next button is clicked
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNumPeople.Text) ||
                string.IsNullOrWhiteSpace(txtNumRooms.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //display the booking amount and number of rooms through a messagebox 
                MessageBox.Show($"The Total Booking Amount Is: {CalculateBookingAmount().ToString("C")} \r\n The Total Number Of Rooms Booked Is: {GetSelectedRooms().Count}");
            }
            */

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
            BookingType bookingType = (rbPersonalBooking.Checked) ? BookingType.Personal : BookingType.TravelAgency; //Determine the booking type based on the selected radio button
            int numOfRooms = int.Parse(txtNumRooms.Text); //Parse the number of rooms from the textbox

            string specialRequirements = txtSpecialReq.Text; //Get the special requirements from the textbox


            //Call the MakeBooking method from the BookingController class to create a new booking
            BookingController bookingController = new BookingController();
            Booking booking = bookingController.MakeBooking(guest,
                rooms,
                travelAgent,
                numOfPeople.ToString(),
                (int)bookingType, // Convert BookingType enum to int
                numOfRooms,
                checkInDate,      // Pass checkInDate as DateTime
                checkOutDate,
                specialRequirements);
            // Pass checkOutDate as DateTime
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
            rbPersonalBooking.Checked = false;
            rbTravelAgencyBooking.Checked = false;
            cbRoom101.Checked = false;
            cbRoom102.Checked = false;
            cbRoom103.Checked = false;
            cbRoom104.Checked = false;
            cbRoom105.Checked = false;
            txtRoom101.Clear();
            txtRoom102.Clear();
            txtRoom103.Clear();
            txtRoom104.Clear();
            txtRoom105.Clear();

            //Make all error labels invisible when the form is cleared
            lblFNameErr.Visible = false;
            lblLNameErr.Visible = false;
            lblNoOfPeopleErr.Visible = false;
            lblCheckInDateErr.Visible = false;
            lblCheckOutDateErr.Visible = false;
            lblEmailErr.Visible = false;
            lblNoOfRoomsErr.Visible = false;
            lblSpecialReqErr.Visible = false;
            lblBookingTypeErr.Visible = false;
            lblRoomSelectionErr.Visible = false;
            lblPhoneNumberErr.Visible = false;



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
