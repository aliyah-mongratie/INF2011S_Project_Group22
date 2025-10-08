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

        Payment payment = new Payment();

        public frmMakePayment()
        {
            InitializeComponent();
        }

        public bool MakePaymentValidation()
        {
            string cardName = txtNameOnCard.Text;
            string cardNumber = txtCardNumber.Text;
            string securityCode = txtSecurityCode.Text;
            string expMonth = txtMonth.Text;
            string expYear = txtYear.Text;

            // Validation for Card Number
            if (string.IsNullOrWhiteSpace(cardName))
            {
                MessageBox.Show("Please enter the name on the card.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameOnCard.Focus();
                return false;
            }
            if (cardName.Any(char.IsDigit))
            {
                MessageBox.Show("Name on the card should not contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameOnCard.Clear();
                return false;
            }
            if (cardName.Length > 50)
            {
                MessageBox.Show("Name on the card should not exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameOnCard.Clear();
                return false;
            }

            // Validation for Card Number
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show("Please enter the card number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNumber.Clear();
                return false;
            }
            if (!cardNumber.All(char.IsDigit) || cardNumber.Length != 16)
            {
                MessageBox.Show("Card number must be exactly 16 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNumber.Clear();
                return false;
            }

            // Validation for Security Code
            if (string.IsNullOrWhiteSpace(securityCode))
            {
                MessageBox.Show("Please enter the security code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecurityCode.Focus();
                return false;
            }
            if (!securityCode.All(char.IsDigit) || securityCode.Length != 3)
            {
                MessageBox.Show("Security code must be exactly 3 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecurityCode.Clear();
                return false;
            }

            // Validation for Expiry Month
            if (string.IsNullOrWhiteSpace(expMonth))
            {
                MessageBox.Show("Please enter the expiry month.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Clear();
                return false;
            }
            if (!int.TryParse(expMonth, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Expiry month must be a number between 01 and 12.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Clear();
                return false;
            }

            // Validation for Expiry Year
            if (string.IsNullOrWhiteSpace(expYear))
            {
                MessageBox.Show("Please enter the expiry year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Clear();
                return false;
            }
            if (!int.TryParse(expYear, out int year) || expYear.Length != 2)
            {
                MessageBox.Show("Expiry year must be in 2 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Clear();
                return false;
            }

            // Check if the card is expired
            try
            {
                year += 2000; // Convert to four-digit year

                DateTime expiryDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));// Set to last day of the month and year

                if (expiryDate < DateTime.Now)// Compare with current date
                {
                    MessageBox.Show("The card is expired. Please use a valid card.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Show error message
                    txtMonth.Clear();
                    txtYear.Clear();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid expiry date. Please check the month, year and vakid card .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Clear();
                txtYear.Clear();
                return false;
            }

            string secureCardNumber = payment.GetCreditCardCredentials();
            MessageBox.Show($"Payment successful! Charged to card: {txtCardNumber.Text}", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true; // All validations passed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!MakePaymentValidation())
            {
                return; // Stop further processing if validation fails
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
