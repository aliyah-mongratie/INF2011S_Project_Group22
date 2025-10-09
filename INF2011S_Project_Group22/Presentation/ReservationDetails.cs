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
       
        BookingController controller = new BookingController();//instance of controller class

        public ReservationDetails()
        {

            InitializeComponent();

            FillReservationDetails();

            

        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #region Methods
        //Method to fill reservation details made

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
                        txtPhoneNumber.Text = reader["GuestPhoneNumber"].ToString();
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
                        txtPhoneNumber.Clear();

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
