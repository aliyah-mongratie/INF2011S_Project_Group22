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
        public frmMakePayment()
        {
            InitializeComponent();
            Payment payment = new Payment();
            lblCardNoError.Visible = false;
            lblExpiryDateError.Visible = false;
            lblCVVError.Visible = false;
            lblNameCardError.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

   
   
        private bool MakePaymentValidation()
        {

            Payment payment = new Payment();

            string cardName = txtNameOnCard.Text;
            string cardNumber = txtCardNumber.Text;
            string securityCode = txtSecurityCode.Text;
            string expMonth = txtMonth.Text;
            string expYear = txtYear.Text;

            // Validation for Card Number
            if (string.IsNullOrWhiteSpace(cardName))
            {
                lblNameCardError.Text= "Name on the card is a required field.";
                lblNameCardError.Visible = true;
                return false;
            }
            if (cardName.Any(char.IsDigit))
            {
                lblNameCardError.Text = "Name on the card should not contain numbers.";
                lblNameCardError.Visible = true;
                txtNameOnCard.Clear();
                return false;
            }
            if (cardName.Length > 50)
            {
                lblNameCardError.Text = "Name on the card should not exceed 50 characters.";
                lblNameCardError.Visible = true;
                txtNameOnCard.Clear();
                return false;
            }

            // Validation for Card Number
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                lblCardNoError.Text = "Please enter the card number.";
                lblCardNoError.Visible = true;
                txtCardNumber.Clear();
                return false;
            }
            if (!cardNumber.All(char.IsDigit) || cardNumber.Length != 16)
            {
                lblCardNoError.Text = "Card number must be exactly 16 digits."; 
                lblCardNoError.Visible = true;
                txtCardNumber.Clear();
                return false;
            }

            // Validation for Security Code
            if (string.IsNullOrWhiteSpace(securityCode))
            {
                lblCVVError.Text = "Please enter the security code.";
                lblCVVError.Visible = true;
                txtSecurityCode.Focus();
                return false;
            }
            if (!securityCode.All(char.IsDigit) || securityCode.Length != 3)
            {
                lblCVVError.Text = "Security code must be exactly 3 digits.";
                lblCVVError.Visible = true;
                txtSecurityCode.Clear();
                return false;
            }

            // Validation for Expiry Month
            if (string.IsNullOrWhiteSpace(expMonth))
            {
                lblExpiryDateError.Text = "Please enter the expiry month.";
                lblExpiryDateError.Visible = true;
                txtMonth.Clear();
                return false;
            }
            if (!int.TryParse(expMonth, out int month) || month < 1 || month > 12)
            {
                lblExpiryDateError.Text = "Expiry month must be a number between 01 and 12.";
                lblExpiryDateError.Visible = true;
                return false;
            }

            // Validation for Expiry Year
            if (string.IsNullOrWhiteSpace(expYear))
            {
                lblExpiryDateError.Text="Please enter the expiry year.";
                lblExpiryDateError.Visible = true;
                txtYear.Clear();
                return false;
            }
            if (!int.TryParse(expYear, out int year) || expYear.Length != 2)
            {
                lblExpiryDateError.Text = "Expiry year must be in 2 digits.";
                lblExpiryDateError.Visible = true;
                return false;
            }

            // Check if the card is expired
            try
            {
                year += 2000; // Convert to four-digit year

                DateTime expiryDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));// Set to last day of the month and year

                if (expiryDate < DateTime.Now)// Compare with current date
                {
                    lblExpiryDateError.Text = "The card is expired. Please use a valid card.";
                    lblExpiryDateError.Visible = true;
                    txtYear.Clear();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid expiry date. Please check the month, year and valid card .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Clear();
                txtYear.Clear();
                return false;
            }

           // string secureCardNumber = payment.GetCreditCardCredentials();
            string secureCardNumber = "**** **** **** " + cardNumber.Substring(cardNumber.Length - 4); // Mask all but last 4 digits
            MessageBox.Show($"Payment successful! Charged to card: {secureCardNumber}", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true; // All validations passed
        }
        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!MakePaymentValidation())
            {
                return; // Stop further processing if validation fails
            }
            else
            {
                BookingConfirmation newform = new BookingConfirmation();
                newform.ShowDialog();

            }

               
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMakePayment_Load(object sender, EventArgs e)
        {
            //Is the github working now?
        }
    }
}
