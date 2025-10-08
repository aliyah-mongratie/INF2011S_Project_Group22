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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;




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


        }
        #region Validation Method
        private bool EnterDetailsValidation()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                lblFNameErr.Text = "First Name is required.";
                lblLNameErr.Text = "Last Name is required.";

                lblFNameErr.Visible = true;
                lblLNameErr.Visible = true;

                txtFirstName.Clear();
                txtLastName.Clear();

                return false;
            }

            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                lblFNameErr.Text = "Names cannot contain numbers.";
                lblLNameErr.Text = "Names cannot contain numbers.";

                lblFNameErr.Visible = true;
                lblLNameErr.Visible = true;

                txtFirstName.Clear();
                txtLastName.Clear();


                return false;
            }

            if (!int.TryParse(txtNumPeople.Text, out int numberOfPeople) || numberOfPeople < 1 || numberOfPeople > 6)
            {
                lblNoOfPeopleErr.Text="Number of people must be between 1 and 6.";
                lblNoOfPeopleErr.Visible = true;
                
                txtNumPeople.Clear();
                return false;
            }

            if (!int.TryParse(txtNumRooms.Text, out int numberOfRooms) || numberOfRooms < 1 || numberOfRooms > 3)
            {
                lblNoOfRoomsErr.Text="Number of rooms must be between 1 and 3.";
                lblNoOfRoomsErr.Visible = true;

                txtNumRooms.Clear();
                return false;
            }

            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                lblEmailErr.Text="Please enter a valid email address.";
                lblEmailErr.Visible = true;
                txtEmail.Clear();
                return false;
            }

            string specialRequirements = txtSpecialReq.Text;
            if (specialRequirements.Length > 200)
            {

                lblSpecialReqErr.Text="Special requirements cannot exceed 200 characters.";
                lblSpecialReqErr.Visible = true;

                txtSpecialReq.Clear();
                return false;
            }

            return false;
            
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

                if (availableRooms.Count == 0)
                {
                    MessageBox.Show("No rooms are currently available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
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

        private decimal CalculateBookingAmount()
        {
            decimal totalBookingPrice = 0;

            // Validate dates first
            if (string.IsNullOrEmpty(txtCheckInDate.Text) || string.IsNullOrEmpty(txtCheckOutDate.Text))
            {
                MessageBox.Show("Please enter both check-in and check-out dates.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            DateTime checkInDate;
            DateTime checkOutDate;

            try
            {
                checkInDate = Convert.ToDateTime(txtCheckInDate.Text);
                checkOutDate = Convert.ToDateTime(txtCheckOutDate.Text);
            }
            catch
            {
                MessageBox.Show("Invalid date format. Please use (e.g. 10/10/2025).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            int nights = booking.GetBookingDuration(checkInDate, checkOutDate);

            var selectedRooms = GetSelectedRooms();
            if (selectedRooms == null || selectedRooms.Count == 0)
            {
                lblRoomSelectionErr.Text="Please select at least one room.";
                lblRoomSelectionErr.Visible = true;

                return 0;
            }

            
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

            try
            {
                // Validate the user input first
                if (!EnterDetailsValidation())
                    return;

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtNumPeople.Text) ||
                    string.IsNullOrWhiteSpace(txtNumRooms.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prepare booking data from inputs
                Guest guest = new Guest
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text
                    // string phoneNumber = txtPhoneNumber.Text; // depending on if Imaan added phone number to the form. Then check what she called it
                };

                DateTime.TryParse(txtCheckInDate.Text, out DateTime checkInDate);
                DateTime.TryParse(txtCheckOutDate.Text, out DateTime checkOutDate);

                int numOfPeople = int.Parse(txtNumPeople.Text);
                int numOfRooms = int.Parse(txtNumRooms.Text);
                string specialRequirements = txtSpecialReq.Text;

                BookingType bookingType = rbPersonalBooking.Checked ? BookingType.Personal : BookingType.TravelAgency;

                List<HotelRoom> rooms = GetSelectedRooms();
                TravelAgent travelAgent = new TravelAgent();

                // calculate the booking costs and sidplay with the room count and deposti amount
                Booking tempBooking = new Booking();
                decimal totalAmount = CalculateBookingAmount();
                decimal deposit = tempBooking.CalculateDeposit(totalAmount);

                MessageBox.Show($"The Total Booking Amount Is: {totalAmount:C}\r\n" +
                                $"The Total Number Of Rooms Booked Is: {rooms.Count}\r\n" +
                                $"The Booking Deposit is: {deposit:C}");

                //create booking once using the controller
                bookingController = new BookingController();
                booking = bookingController.MakeBooking(
                    guest,
                    rooms,
                    travelAgent,
                    bookingType.ToString(),
                    numOfPeople,
                    numOfRooms,
                    checkInDate,
                    checkOutDate,
                    specialRequirements
                );

                //booking now containg bookingResNUm
                int bookNo = bookingController.MakeBooking( guest, rooms, travelAgent, bookingType.ToString(), numOfPeople, numOfRooms, checkInDate, 
                                                           checkOutDate, specialRequirements).bookingResNumber;



                if (booking == null)
                {
                    MessageBox.Show("Error: Booking could not be created. Please try again.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //prepare details data from inputs
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                // string phoneNumber = txtPhoneNumber.Text; // depending on if Imaan added phone number to the form. Then check what she called it


                // Only after all validation passes:
                if (rbPersonalBooking.Checked)
                {
                    bookingType = BookingType.Personal;
                    new frmMakePayment(firstName, lastName, email, bookNo) /* add phone number here if its in UI*/.ShowDialog();
                }
                else if (rbTravelAgencyBooking.Checked)
                {
                    bookingType = BookingType.TravelAgency;
                    new BookingConfirmation(booking.bookingResNumber).ShowDialog();
                    

                }
                else
                {
                    lblBookingTypeErr.Text = "Please select a booking type.";
                   
                }
               

                // If all validations pass, proceed with reservation creation
                //Open the payment details page once the details have been entered and validated 

                frmMakePayment newForm = new frmMakePayment(firstName, lastName, email, bookNo); //add phone number here if it is in UI
                newForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            txtFirstName.Focus();
        }

        private void btnCreateResExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            DisplayAvailableRooms();


            /*cbRoom101 = new HotelRoom(101, HotelRoom.RoomStatus.Available);
            cbRoom102 = new HotelRoom(102, HotelRoom.RoomStatus.Occupied);
            cbRoom103 = new HotelRoom(103, HotelRoom.RoomStatus.Available);*/
        }

    }
}
