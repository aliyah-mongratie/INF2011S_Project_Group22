using INF2011S_Project_Group22.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22
{
    public partial class frmCreateReservation : Form
    {
        public frmCreateReservation()
        {
            InitializeComponent();
            
        }



        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateResNext_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int numberOfPeople = int.Parse(txtNumPeople.Text);
            int numberOfRooms = int.Parse(txtNumRooms.Text);
            DateTime checkInDate = dateTimePicker1.Value;
            DateTime checkOutDate = dateTimePicker2.Value;

            //If the personal booking is chosen, the user will be directed to the payment form. If not, they will be directed to the confirmed booking form.
            //The assumption is that personal bookings will always require payment, while travel agent bookings will be handled by the travel agent.

            if (rbPersonalBooking.Checked)
            {
                frmMakePayment newForm = new frmMakePayment();
                newForm.ShowDialog();
            }
            else if (rbTravelAgencyBooking.Checked)
            {
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
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            if (checkInDate < DateTime.Today) // if the check-in date is before today's date, a messagebox will pop up telling the user there is an error.
            {
                MessageBox.Show("The check-in date cannot be in the past.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (checkOutDate >= checkInDate)
            {
                MessageBox.Show("The check-out date must be after the check-in date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Check-in date: {dateTimePicker1.Value}, Check-out date: {dateTimePicker2.Value}");
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

            // If all validations pass, proceed with reservation creation
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

        }

    }
}
