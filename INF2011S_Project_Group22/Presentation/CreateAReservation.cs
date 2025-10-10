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
            lblAgencyNameErr.Visible = false;   
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

            //travel agent validation
            string agencyName = txtAgencyName.Text;

            if(rbTravelAgencyBooking.Checked == true)
            {
               
                if (string.IsNullOrWhiteSpace(agencyName))
                {
                    lblAgencyNameErr.Text = "Agency Name is required.";
                    lblAgencyNameErr.Visible = true;
                    txtAgencyName.Clear();
                    return false;
                }

                if (agencyName.Any(char.IsDigit))
                {
                    lblAgencyNameErr.Text = "Names cannot contain numbers.";

                    lblAgencyNameErr.Visible = true;
           
                    txtAgencyName.Clear();
                    valid = false;
                }
            }

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
            //validate the rooms checkboxes
            if (!cb.Checked)
            {
                return true;
            }

            if (!int.TryParse(txt.Text, out int num) || num > 1 || num < 4)
            {
                lblRoomSelectionErr.Text = "Number of people must be between 1 & 4";
                lblRoomSelectionErr.Visible = true;
                txt.Clear();
                return false;
            }
            return true;
        }
        


            // If all validations pass, proceed with reservation creation
        
        #endregion
        #region Methods Available rooms

        public bool getTotalRoomPeople()
        {
            //gets the total amount of people and displays the avaiable rooms
            // Check that total people for the booking is a number
            if (txtNumPeople.Text == "")
            {
                MessageBox.Show("Please enter the total number of guests.");
                return false;
            }

            int totalPeople = int.Parse(txtNumPeople.Text);
            int totalRoomPeople = 0;

            // Check each selected room and adds up the number of people in each textbox
            if (cbRoom101.Checked)
            {
                if (txtRoom101.Text != "")
                    totalRoomPeople += int.Parse(txtRoom101.Text);
            }

            if (cbRoom102.Checked)
            {
                if (txtRoom102.Text != "")
                    totalRoomPeople += int.Parse(txtRoom102.Text);
            }

            if (cbRoom103.Checked)
            {
                if (txtRoom103.Text != "")
                    totalRoomPeople += int.Parse(txtRoom103.Text);
            }

            if (cbRoom104.Checked)
            {
                if (txtRoom104.Text != "")
                    totalRoomPeople += int.Parse(txtRoom104.Text);
            }

            if (cbRoom105.Checked)
            {
                if (txtRoom105.Text != "")
                    totalRoomPeople += int.Parse(txtRoom105.Text);
            }

            // Check if total people in rooms exceed the total people entered
            if (totalRoomPeople > totalPeople)
            {
                MessageBox.Show("You have assigned more people to rooms than the total number entered.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (totalRoomPeople < totalPeople)
            {
                MessageBox.Show("Some guests are not assigned to any room. Please fill all rooms correctly.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Everything is valid
            return true;


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

                if (availableRooms.Count == 0)
                {
                    MessageBox.Show("No rooms are currently available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                }
            }

        public List<HotelRoom> GetSelectedRooms()
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








        public decimal CalculateBookingAmount()
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
            //holds the amount of nights from the checkin and checkout dates
          

            //declare selected rooms variable
            List<HotelRoom> selectedRooms = GetSelectedRooms();

            //Validate date logic
            //Get the selected rooms

            MessageBox.Show($"Selected rooms: {selectedRooms?.Count}");

            //holds the amount of nights from the checkin and checkout dates
            int nights = (checkOutDate - checkInDate).Days;
            if (nights <= 0)
            {
                lblCheckOutDateErr.Text = "Check-out date must be after check-in date.";
                lblCheckOutDateErr.Visible = true;
                return 0;
            }
            //holds the total price of all chosenrooms
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
            //holds the total amount of all the rooms
            decimal total = CalculateBookingAmount();

            //holds the booking total deposti amount and call the total booking amount
            Booking tempBooking = new Booking();
            decimal deposit = tempBooking.CalculateDeposit(total);

            if (total <= 0) return;
            MessageBox.Show($"The Total Booking Amount Is: {total.ToString("C")} \r\n The Total Number Of Rooms Booked Is: {GetSelectedRooms().Count} \r\n The Booking Deposit is: {deposit:C}");

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
            else
            {
                //display the booking amount and number of rooms through a messagebox 
                MessageBox.Show($"The Total Booking Amount Is: {CalculateBookingAmount().ToString("C")} \r\n The Total Number Of Rooms Booked Is: {GetSelectedRooms().Count} \r\n The Booking Deposit is: {deposit:C}");
            }

            BookingController bookingController = new BookingController();
            // initiate the objects so it can be passed to the MakeBooking method

           Guest guest = new Guest();

            guest.FirstName = txtFirstName.Text;
            guest.LastName = txtLastName.Text;
            guest.Email = txtEmail.Text;
            guest.phoneNumber = txtPhoneNumber.Text;
            DateTime checkInDate, checkOutDate;
            DateTime.TryParse(txtCheckInDate.Text, out checkInDate);
            DateTime.TryParse(txtCheckOutDate.Text, out checkOutDate);

           
            List<HotelRoom> rooms = new List<HotelRoom>(); //Create a new list to store the rooms that will be booked

            int numOfPeople = int.Parse(txtNumPeople.Text); //Parse the number of people from the textbox
            BookingType bookingType = (rbPersonalBooking.Checked) ? BookingType.Personal : BookingType.TravelAgency; //Determine the booking type based on the selected radio button
            int numOfRooms = int.Parse(txtNumRooms.Text); //Parse the number of rooms from the textbox

            string specialRequirements = txtSpecialReq.Text; //Get the special requirements from the textbox


            //makes sure that the total people in all the testboxes in each room, is less than the tot number of people entered
            getTotalRoomPeople();




            //prepare details data from inputs
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
             string phoneNumber = txtPhoneNumber.Text;
            //declare selected rooms variable
            List<HotelRoom> selectedRooms = GetSelectedRooms();

            // Only after all validation passes:
            if (rbPersonalBooking.Checked)
            {
                
                bookingType = BookingType.Personal;
                new frmMakePayment(CalculateBookingAmount(),bookingType,firstName, lastName, phoneNumber, email, numOfRooms,checkInDate,checkOutDate,specialRequirements, selectedRooms, numOfPeople, txtAgencyName.Text).ShowDialog();
            }
            else if (rbTravelAgencyBooking.Checked)
            {
                string agencyName = txtAgencyName.Text;
                //make trvel agent inputs visible when radio button is clicked
                string agentId = TravelAgent.generateAgentId(agencyName);
                TravelAgent agent = bookingController.AddAgent(agentId, agencyName, firstName, lastName, phoneNumber, email);
                txtAgencyName.Visible = true;
                lblAgencyName.Visible = true;
             
                string cardNo = "";
                bookingType = BookingType.TravelAgency;
                string guestId = Guest.generateGuestId(lastName);
                BookingConfirmation newform = new BookingConfirmation(CalculateBookingAmount(), cardNo,bookingType,guestId, checkInDate, checkOutDate, numOfRooms, specialRequirements, selectedRooms, numOfPeople);//goes to next form
                newform.ShowDialog();
                // new BookingConfirmation(booking.bookingResNumber).ShowDialog();


            }
            else
            {
                lblBookingTypeErr.Text = "Please select a booking type.";//error message pops up

            }






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
            //makes travel agent inputs invisible when form loads
            txtAgencyName.Visible = false;
            lblAgencyName.Visible = false;
            

            /*cbRoom101 = new HotelRoom(101, HotelRoom.RoomStatus.Available, );
            cbRoom102 = new HotelRoom(102, HotelRoom.RoomStatus.Occupied);
            cbRoom103 = new HotelRoom(103, HotelRoom.RoomStatus.Available);*/
        }

        private void lblCheckInDateErr_Click(object sender, EventArgs e)
        {

        }

        private void lblCheckOutDateErr_Click(object sender, EventArgs e)
        {

        }
    }
}
