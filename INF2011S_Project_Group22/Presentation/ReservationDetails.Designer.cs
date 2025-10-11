namespace INF2011S_Project_Group22.Presentation
{
    partial class ReservationDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationDetails));
            this.lblBookingEnquiry = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNoRoomsReq = new System.Windows.Forms.Label();
            this.txtNoRoomsReq = new System.Windows.Forms.TextBox();
            this.lblNoPeople = new System.Windows.Forms.Label();
            this.txtNoPeople = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.lblSQ = new System.Windows.Forms.Label();
            this.txtSpecialRequirements = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBoxRoomPeople = new System.Windows.Forms.GroupBox();
            this.lblRoomSelectionErr = new System.Windows.Forms.Label();
            this.cbRoom101 = new System.Windows.Forms.CheckBox();
            this.txtRoom105 = new System.Windows.Forms.TextBox();
            this.cbRoom105 = new System.Windows.Forms.CheckBox();
            this.txtRoom101 = new System.Windows.Forms.TextBox();
            this.cbRoom104 = new System.Windows.Forms.CheckBox();
            this.txtRoom104 = new System.Windows.Forms.TextBox();
            this.cbRoom102 = new System.Windows.Forms.CheckBox();
            this.cbRoom103 = new System.Windows.Forms.CheckBox();
            this.txtRoom102 = new System.Windows.Forms.TextBox();
            this.txtRoom103 = new System.Windows.Forms.TextBox();
            this.rbTravelAgencyBooking = new System.Windows.Forms.RadioButton();
            this.rbPersonalBooking = new System.Windows.Forms.RadioButton();
            this.lblAgencyName = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxRoomPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingEnquiry
            // 
            this.lblBookingEnquiry.AutoSize = true;
            this.lblBookingEnquiry.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingEnquiry.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingEnquiry.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBookingEnquiry.Location = new System.Drawing.Point(0, 144);
            this.lblBookingEnquiry.Name = "lblBookingEnquiry";
            this.lblBookingEnquiry.Size = new System.Drawing.Size(278, 46);
            this.lblBookingEnquiry.TabIndex = 1;
            this.lblBookingEnquiry.Text = "Booking Details";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblFirstName.Location = new System.Drawing.Point(12, 258);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(454, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(141, 252);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(247, 30);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(589, 247);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(247, 30);
            this.txtLastName.TabIndex = 5;
            // 
            // lblNoRoomsReq
            // 
            this.lblNoRoomsReq.AutoSize = true;
            this.lblNoRoomsReq.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNoRoomsReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRoomsReq.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNoRoomsReq.Location = new System.Drawing.Point(12, 309);
            this.lblNoRoomsReq.Name = "lblNoRoomsReq";
            this.lblNoRoomsReq.Size = new System.Drawing.Size(257, 25);
            this.lblNoRoomsReq.TabIndex = 6;
            this.lblNoRoomsReq.Text = "Number of Rooms Required:";
            // 
            // txtNoRoomsReq
            // 
            this.txtNoRoomsReq.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNoRoomsReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRoomsReq.Location = new System.Drawing.Point(275, 306);
            this.txtNoRoomsReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoRoomsReq.Name = "txtNoRoomsReq";
            this.txtNoRoomsReq.ReadOnly = true;
            this.txtNoRoomsReq.Size = new System.Drawing.Size(271, 30);
            this.txtNoRoomsReq.TabIndex = 7;
            // 
            // lblNoPeople
            // 
            this.lblNoPeople.AutoSize = true;
            this.lblNoPeople.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNoPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPeople.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNoPeople.Location = new System.Drawing.Point(17, 360);
            this.lblNoPeople.Name = "lblNoPeople";
            this.lblNoPeople.Size = new System.Drawing.Size(174, 25);
            this.lblNoPeople.TabIndex = 8;
            this.lblNoPeople.Text = "Number of People:";
            // 
            // txtNoPeople
            // 
            this.txtNoPeople.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNoPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPeople.Location = new System.Drawing.Point(212, 355);
            this.txtNoPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoPeople.Name = "txtNoPeople";
            this.txtNoPeople.ReadOnly = true;
            this.txtNoPeople.Size = new System.Drawing.Size(271, 30);
            this.txtNoPeople.TabIndex = 9;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBookingDate.Location = new System.Drawing.Point(17, 418);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(135, 25);
            this.lblBookingDate.TabIndex = 10;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblCheckInDate.Location = new System.Drawing.Point(218, 418);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(144, 25);
            this.lblCheckInDate.TabIndex = 11;
            this.lblCheckInDate.Text = "Check-In Date:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblCheckOutDate.Location = new System.Drawing.Point(614, 418);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(160, 25);
            this.lblCheckOutDate.TabIndex = 12;
            this.lblCheckOutDate.Text = "Check-Out Date:";
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.BackColor = System.Drawing.Color.Bisque;
            this.txtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.Location = new System.Drawing.Point(385, 413);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.Size = new System.Drawing.Size(151, 30);
            this.txtCheckInDate.TabIndex = 13;
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutDate.Location = new System.Drawing.Point(780, 416);
            this.txtCheckOutDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.ReadOnly = true;
            this.txtCheckOutDate.Size = new System.Drawing.Size(151, 30);
            this.txtCheckOutDate.TabIndex = 14;
            // 
            // lblSQ
            // 
            this.lblSQ.AutoSize = true;
            this.lblSQ.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQ.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblSQ.Location = new System.Drawing.Point(17, 519);
            this.lblSQ.Name = "lblSQ";
            this.lblSQ.Size = new System.Drawing.Size(300, 25);
            this.lblSQ.TabIndex = 15;
            this.lblSQ.Text = "Special Requirements (Optional):";
            // 
            // txtSpecialRequirements
            // 
            this.txtSpecialRequirements.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSpecialRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialRequirements.Location = new System.Drawing.Point(341, 519);
            this.txtSpecialRequirements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialRequirements.Name = "txtSpecialRequirements";
            this.txtSpecialRequirements.ReadOnly = true;
            this.txtSpecialRequirements.Size = new System.Drawing.Size(433, 30);
            this.txtSpecialRequirements.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblEmail.Location = new System.Drawing.Point(17, 587);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 582);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(433, 30);
            this.txtEmail.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(8, 663);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(257, 44);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gBoxRoomPeople
            // 
            this.gBoxRoomPeople.BackColor = System.Drawing.Color.DarkCyan;
            this.gBoxRoomPeople.Controls.Add(this.lblRoomSelectionErr);
            this.gBoxRoomPeople.Controls.Add(this.cbRoom101);
            this.gBoxRoomPeople.Controls.Add(this.txtRoom105);
            this.gBoxRoomPeople.Controls.Add(this.cbRoom105);
            this.gBoxRoomPeople.Controls.Add(this.txtRoom101);
            this.gBoxRoomPeople.Controls.Add(this.cbRoom104);
            this.gBoxRoomPeople.Controls.Add(this.txtRoom104);
            this.gBoxRoomPeople.Controls.Add(this.cbRoom102);
            this.gBoxRoomPeople.Controls.Add(this.cbRoom103);
            this.gBoxRoomPeople.Controls.Add(this.txtRoom102);
            this.gBoxRoomPeople.Controls.Add(this.txtRoom103);
            this.gBoxRoomPeople.ForeColor = System.Drawing.Color.NavajoWhite;
            this.gBoxRoomPeople.Location = new System.Drawing.Point(970, 270);
            this.gBoxRoomPeople.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxRoomPeople.Name = "gBoxRoomPeople";
            this.gBoxRoomPeople.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxRoomPeople.Size = new System.Drawing.Size(349, 274);
            this.gBoxRoomPeople.TabIndex = 37;
            this.gBoxRoomPeople.TabStop = false;
            this.gBoxRoomPeople.Text = "Select room and Specify number of people";
            // 
            // lblRoomSelectionErr
            // 
            this.lblRoomSelectionErr.AutoSize = true;
            this.lblRoomSelectionErr.ForeColor = System.Drawing.Color.Red;
            this.lblRoomSelectionErr.Location = new System.Drawing.Point(19, 251);
            this.lblRoomSelectionErr.Name = "lblRoomSelectionErr";
            this.lblRoomSelectionErr.Size = new System.Drawing.Size(0, 16);
            this.lblRoomSelectionErr.TabIndex = 31;
            // 
            // cbRoom101
            // 
            this.cbRoom101.AutoSize = true;
            this.cbRoom101.ForeColor = System.Drawing.Color.NavajoWhite;
            this.cbRoom101.Location = new System.Drawing.Point(19, 32);
            this.cbRoom101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom101.Name = "cbRoom101";
            this.cbRoom101.Size = new System.Drawing.Size(90, 20);
            this.cbRoom101.TabIndex = 26;
            this.cbRoom101.Text = "Room 101";
            this.cbRoom101.UseVisualStyleBackColor = true;
            // 
            // txtRoom105
            // 
            this.txtRoom105.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom105.Location = new System.Drawing.Point(135, 217);
            this.txtRoom105.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom105.Name = "txtRoom105";
            this.txtRoom105.Size = new System.Drawing.Size(100, 22);
            this.txtRoom105.TabIndex = 25;
            // 
            // cbRoom105
            // 
            this.cbRoom105.AutoSize = true;
            this.cbRoom105.Location = new System.Drawing.Point(19, 219);
            this.cbRoom105.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom105.Name = "cbRoom105";
            this.cbRoom105.Size = new System.Drawing.Size(90, 20);
            this.cbRoom105.TabIndex = 30;
            this.cbRoom105.Text = "Room 105";
            this.cbRoom105.UseVisualStyleBackColor = true;
            // 
            // txtRoom101
            // 
            this.txtRoom101.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom101.Location = new System.Drawing.Point(135, 30);
            this.txtRoom101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom101.Name = "txtRoom101";
            this.txtRoom101.Size = new System.Drawing.Size(100, 22);
            this.txtRoom101.TabIndex = 21;
            // 
            // cbRoom104
            // 
            this.cbRoom104.AutoSize = true;
            this.cbRoom104.Location = new System.Drawing.Point(19, 169);
            this.cbRoom104.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom104.Name = "cbRoom104";
            this.cbRoom104.Size = new System.Drawing.Size(90, 20);
            this.cbRoom104.TabIndex = 29;
            this.cbRoom104.Text = "Room 104";
            this.cbRoom104.UseVisualStyleBackColor = true;
            // 
            // txtRoom104
            // 
            this.txtRoom104.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom104.Location = new System.Drawing.Point(135, 166);
            this.txtRoom104.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom104.Name = "txtRoom104";
            this.txtRoom104.Size = new System.Drawing.Size(100, 22);
            this.txtRoom104.TabIndex = 24;
            // 
            // cbRoom102
            // 
            this.cbRoom102.AutoSize = true;
            this.cbRoom102.Location = new System.Drawing.Point(19, 73);
            this.cbRoom102.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom102.Name = "cbRoom102";
            this.cbRoom102.Size = new System.Drawing.Size(90, 20);
            this.cbRoom102.TabIndex = 27;
            this.cbRoom102.Text = "Room 102";
            this.cbRoom102.UseVisualStyleBackColor = true;
            // 
            // cbRoom103
            // 
            this.cbRoom103.AutoSize = true;
            this.cbRoom103.Location = new System.Drawing.Point(19, 123);
            this.cbRoom103.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoom103.Name = "cbRoom103";
            this.cbRoom103.Size = new System.Drawing.Size(90, 20);
            this.cbRoom103.TabIndex = 28;
            this.cbRoom103.Text = "Room 103";
            this.cbRoom103.UseVisualStyleBackColor = true;
            // 
            // txtRoom102
            // 
            this.txtRoom102.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom102.Location = new System.Drawing.Point(135, 70);
            this.txtRoom102.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom102.Name = "txtRoom102";
            this.txtRoom102.Size = new System.Drawing.Size(100, 22);
            this.txtRoom102.TabIndex = 22;
            // 
            // txtRoom103
            // 
            this.txtRoom103.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom103.Location = new System.Drawing.Point(135, 119);
            this.txtRoom103.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom103.Name = "txtRoom103";
            this.txtRoom103.Size = new System.Drawing.Size(100, 22);
            this.txtRoom103.TabIndex = 23;
            // 
            // rbTravelAgencyBooking
            // 
            this.rbTravelAgencyBooking.AutoSize = true;
            this.rbTravelAgencyBooking.BackColor = System.Drawing.Color.DarkCyan;
            this.rbTravelAgencyBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTravelAgencyBooking.ForeColor = System.Drawing.Color.NavajoWhite;
            this.rbTravelAgencyBooking.Location = new System.Drawing.Point(12, 192);
            this.rbTravelAgencyBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTravelAgencyBooking.Name = "rbTravelAgencyBooking";
            this.rbTravelAgencyBooking.Size = new System.Drawing.Size(236, 29);
            this.rbTravelAgencyBooking.TabIndex = 38;
            this.rbTravelAgencyBooking.TabStop = true;
            this.rbTravelAgencyBooking.Text = "Travel Agency Booking";
            this.rbTravelAgencyBooking.UseVisualStyleBackColor = false;
            // 
            // rbPersonalBooking
            // 
            this.rbPersonalBooking.AutoSize = true;
            this.rbPersonalBooking.BackColor = System.Drawing.Color.DarkCyan;
            this.rbPersonalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonalBooking.ForeColor = System.Drawing.Color.NavajoWhite;
            this.rbPersonalBooking.Location = new System.Drawing.Point(273, 192);
            this.rbPersonalBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPersonalBooking.Name = "rbPersonalBooking";
            this.rbPersonalBooking.Size = new System.Drawing.Size(186, 29);
            this.rbPersonalBooking.TabIndex = 39;
            this.rbPersonalBooking.TabStop = true;
            this.rbPersonalBooking.Text = "Personal Booking";
            this.rbPersonalBooking.UseVisualStyleBackColor = false;
            // 
            // lblAgencyName
            // 
            this.lblAgencyName.AutoSize = true;
            this.lblAgencyName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAgencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblAgencyName.Location = new System.Drawing.Point(517, 192);
            this.lblAgencyName.Name = "lblAgencyName";
            this.lblAgencyName.Size = new System.Drawing.Size(142, 25);
            this.lblAgencyName.TabIndex = 53;
            this.lblAgencyName.Text = "Agency Name:";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAgencyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAgencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAgencyName.Location = new System.Drawing.Point(672, 194);
            this.txtAgencyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(205, 23);
            this.txtAgencyName.TabIndex = 54;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 469);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(149, 25);
            this.lblPhoneNumber.TabIndex = 55;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhoneNumber.Location = new System.Drawing.Point(175, 470);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(413, 24);
            this.txtPhoneNumber.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1415, 144);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1364, 718);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtAgencyName);
            this.Controls.Add(this.lblAgencyName);
            this.Controls.Add(this.rbPersonalBooking);
            this.Controls.Add(this.rbTravelAgencyBooking);
            this.Controls.Add(this.gBoxRoomPeople);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSpecialRequirements);
            this.Controls.Add(this.lblSQ);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.txtCheckInDate);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.txtNoPeople);
            this.Controls.Add(this.lblNoPeople);
            this.Controls.Add(this.txtNoRoomsReq);
            this.Controls.Add(this.lblNoRoomsReq);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblBookingEnquiry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservationDetails";
            this.Text = "ReservationDetails";
            this.Load += new System.EventHandler(this.ReservationDetails_Load);
            this.gBoxRoomPeople.ResumeLayout(false);
            this.gBoxRoomPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingEnquiry;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNoRoomsReq;
        private System.Windows.Forms.TextBox txtNoRoomsReq;
        private System.Windows.Forms.Label lblNoPeople;
        private System.Windows.Forms.TextBox txtNoPeople;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.TextBox txtCheckOutDate;
        private System.Windows.Forms.Label lblSQ;
        private System.Windows.Forms.TextBox txtSpecialRequirements;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBoxRoomPeople;
        private System.Windows.Forms.Label lblRoomSelectionErr;
        private System.Windows.Forms.CheckBox cbRoom101;
        private System.Windows.Forms.TextBox txtRoom105;
        private System.Windows.Forms.CheckBox cbRoom105;
        private System.Windows.Forms.TextBox txtRoom101;
        private System.Windows.Forms.CheckBox cbRoom104;
        private System.Windows.Forms.TextBox txtRoom104;
        private System.Windows.Forms.CheckBox cbRoom102;
        private System.Windows.Forms.CheckBox cbRoom103;
        private System.Windows.Forms.TextBox txtRoom102;
        private System.Windows.Forms.TextBox txtRoom103;
        private System.Windows.Forms.RadioButton rbTravelAgencyBooking;
        private System.Windows.Forms.RadioButton rbPersonalBooking;
        private System.Windows.Forms.Label lblAgencyName;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}