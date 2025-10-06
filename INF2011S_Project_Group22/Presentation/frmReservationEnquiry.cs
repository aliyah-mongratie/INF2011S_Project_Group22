using INF2011S_Project_Group22.Business;
using INF2011S_Project_Group22.Data;
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

namespace INF2011S_Project_Group22.Presentation
{
    public partial class frmReservationEnquiry : Form
    {
        public frmReservationEnquiry()
        {
            InitializeComponent();
        }

        private bool ReservationEnquiryDetails()
        {
            //This method will validate the input fields for reservation enquiry
            //It will check if the fields are empty, if they contain invalid characters, and if they exceed the maximum length
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            //Validation for First Name and Last Name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Fist Name and Last Name are required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("First and Last Name cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Clear();
                txtLastName.Clear();
                return false;
            }
            if (firstName.Length > 50 || lastName.Length > 50)
            {
                MessageBox.Show("First Name and Last Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Clear();
                txtLastName.Clear();
                return false;
            }

            //Validation for Booking Number
            if (string.IsNullOrWhiteSpace(txtResNumber.Text))
            {
                MessageBox.Show("Booking Number is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtResNumber.Text, out int bookingNumber)) // out int bookingNumber will store the parsed integer if successful, the out keyword allows the method to return this value.
            {
                MessageBox.Show("Booking Number must contain digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (txtResNumber.Text.Length > 6)
            {
                MessageBox.Show("Booking Number cannot exceed 6 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResNumber.Clear();
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HotelBookingDB.mdf;Integrated Security=True"))//Connection string to connect to the database. This allows us to connect to the database without exposing sensitive information.
                {
                    //These using statement ensures that the connection is properly disposed of after use, preventing potential memory leaks. what the method does is it checks if the booking number exists in the database.
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Booking WHERE BookingResNumber = @BookingResNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))//SqlCommand is used to execute the query against the database.
                    {
                        command.Parameters.AddWithValue("@BookingResNumber", bookingNumber); //Parameters are used to prevent SQL injection attacks. It ensures that the input is treated as a value and not as part of the SQL command.
                        int count = (int)command.ExecuteScalar(); //ExecuteScalar is used when the query returns a single value. In this case, it returns the count of records that match the booking number.

                        if (count == 0)
                        {
                            MessageBox.Show("No reservation found with the provided booking number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtResNumber.Clear();
                            return false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking the reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtResNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ReservationEnquiryDetails())
            {
                return;
            }

            if (!int.TryParse(txtResNumber.Text, out int bookingResNumber))
            {
                MessageBox.Show("Invalid booking number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            ReservationDetails newViewReservationDetails = new ReservationDetails();
            newViewReservationDetails.ShowDialog();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReservationEnquiry_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
