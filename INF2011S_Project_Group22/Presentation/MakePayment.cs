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
    public partial class frmMakePayment : Form
    {
        private Payment payment;
        public frmMakePayment()
        {
            InitializeComponent();

            payment = new Payment();
        }

        private bool MakePaymentValidation()
        {


            string cardHolderName = txtNameOnCard.Text;
            string cardNumber = txtCardNumber.Text;
            string securityCode = txtSecurityCode.Text;
            string expMonth = txtMonth.Text;
            string expYear = txtYear.Text;

            // Validation for Card Holder Name
            if (string.IsNullOrWhiteSpace(cardHolderName))
            {
                MessageBox.Show("Card Holder Name is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cardHolderName.Any(char.IsDigit))
            {
                MessageBox.Show("Card Holder Name cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameOnCard.Clear();
                return false;
            }
            if (cardHolderName.Length > 50)
            {
                MessageBox.Show("Card Holder Name cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameOnCard.Clear();
                return false;
            }

            // Validation for Card Number
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show("Card Number is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!cardNumber.All(char.IsDigit) || cardNumber.Length != 16)
            {
                MessageBox.Show("Card Number must contain 16 digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNumber.Clear();
                return false;
            }

            // Validation for CVV
            if (string.IsNullOrWhiteSpace(securityCode))
            {
                MessageBox.Show("CVV is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!securityCode.All(char.IsDigit) || securityCode.Length != 3)
            {
                MessageBox.Show("CVV must contain 3 digits only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecurityCode.Clear();
                return false;
            }

            // Validation for Expiry Month
            if (string.IsNullOrWhiteSpace(expMonth))
            {
                MessageBox.Show("Expiry Month is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(expMonth, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Expiry Month must be a valid month between 01 and 12.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Clear();
                return false;
            }

            // Validation for Expiry Year
            if (string.IsNullOrWhiteSpace(expYear))
            {
                MessageBox.Show("Expiry Year is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(expYear, out int year) || expYear.Length != 2)
            {
                MessageBox.Show("Expiry Year must be a valid year in 2 digits (e.g. 25 for 2025).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Clear();
                return false;
            }

            //Verify if the card is expired
            try
            {
                //Convert the 2-digit year to a 4-digit year
                year += 2000;

                DateTime expiryDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));// Set to the last day of the month
                if (expiryDate < DateTime.Now)// Check if the expiry date is in the past
                {
                    MessageBox.Show("The card is expired. Please use a valid card.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonth.Clear();
                    txtYear.Clear();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Expiry Date. Please check the month and year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If all validations pass, set the payment details
            string secureCardNumber = payment.GetCreditCardCredentials();
            MessageBox.Show($"Payment successful! Your card {txtCardNumber.Text} has been charged.", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameOnCard.Text) || string.IsNullOrWhiteSpace(txtCardNumber.Text) || string.IsNullOrWhiteSpace(txtSecurityCode.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MakePaymentValidation())
            {
                return;
            }
            BookingConfirmation frmBookingConfirmation = new BookingConfirmation();
            frmBookingConfirmation.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMakePayment_Load(object sender, EventArgs e)
        {

        }
    }
}
