namespace INF2011S_Project_Group22
{
    partial class frmCreateReservation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateReservation));
            this.lblCreateAReservation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCreateResClear = new System.Windows.Forms.Button();
            this.rbTravelAgencyBooking = new System.Windows.Forms.RadioButton();
            this.rbPersonalBooking = new System.Windows.Forms.RadioButton();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNumRooms = new System.Windows.Forms.Label();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblSR = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtNumRooms = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.txtSpecialReq = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
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
            this.lblFNameErr = new System.Windows.Forms.Label();
            this.lblLNameErr = new System.Windows.Forms.Label();
            this.lblNoOfRoomsErr = new System.Windows.Forms.Label();
            this.lblNoOfPeopleErr = new System.Windows.Forms.Label();
            this.lblCheckInDateErr = new System.Windows.Forms.Label();
            this.lblCheckOutDateErr = new System.Windows.Forms.Label();
            this.lblEmailErr = new System.Windows.Forms.Label();
            this.lblBookingTypeErr = new System.Windows.Forms.Label();
            this.lblSpecialReqErr = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberErr = new System.Windows.Forms.Label();
            this.lblAgencyNameErr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAgencyName = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxRoomPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateAReservation
            // 
            this.lblCreateAReservation.AutoSize = true;
            this.lblCreateAReservation.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCreateAReservation.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAReservation.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCreateAReservation.Location = new System.Drawing.Point(1, 112);
            this.lblCreateAReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAReservation.Name = "lblCreateAReservation";
            this.lblCreateAReservation.Size = new System.Drawing.Size(255, 36);
            this.lblCreateAReservation.TabIndex = 2;
            this.lblCreateAReservation.Text = "Create A Booking";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(7, 529);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 36);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnCreateResExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirm.Location = new System.Drawing.Point(691, 529);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(190, 35);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnCreateResNext_Click);
            // 
            // btnCreateResClear
            // 
            this.btnCreateResClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCreateResClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResClear.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResClear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateResClear.Location = new System.Drawing.Point(914, 529);
            this.btnCreateResClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateResClear.Name = "btnCreateResClear";
            this.btnCreateResClear.Size = new System.Drawing.Size(190, 35);
            this.btnCreateResClear.TabIndex = 16;
            this.btnCreateResClear.Text = "Clear";
            this.btnCreateResClear.UseVisualStyleBackColor = false;
            this.btnCreateResClear.Click += new System.EventHandler(this.btnCreateResClear_Click);
            // 
            // rbTravelAgencyBooking
            // 
            this.rbTravelAgencyBooking.AutoSize = true;
            this.rbTravelAgencyBooking.BackColor = System.Drawing.Color.DarkCyan;
            this.rbTravelAgencyBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTravelAgencyBooking.ForeColor = System.Drawing.Color.NavajoWhite;
            this.rbTravelAgencyBooking.Location = new System.Drawing.Point(4, 159);
            this.rbTravelAgencyBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTravelAgencyBooking.Name = "rbTravelAgencyBooking";
            this.rbTravelAgencyBooking.Size = new System.Drawing.Size(188, 24);
            this.rbTravelAgencyBooking.TabIndex = 17;
            this.rbTravelAgencyBooking.TabStop = true;
            this.rbTravelAgencyBooking.Text = "Travel Agency Booking";
            this.rbTravelAgencyBooking.UseVisualStyleBackColor = false;
            this.rbTravelAgencyBooking.CheckedChanged += new System.EventHandler(this.rbTravelAgencyBooking_CheckedChanged);
            // 
            // rbPersonalBooking
            // 
            this.rbPersonalBooking.AutoSize = true;
            this.rbPersonalBooking.BackColor = System.Drawing.Color.DarkCyan;
            this.rbPersonalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonalBooking.ForeColor = System.Drawing.Color.NavajoWhite;
            this.rbPersonalBooking.Location = new System.Drawing.Point(217, 159);
            this.rbPersonalBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPersonalBooking.Name = "rbPersonalBooking";
            this.rbPersonalBooking.Size = new System.Drawing.Size(151, 24);
            this.rbPersonalBooking.TabIndex = 18;
            this.rbPersonalBooking.TabStop = true;
            this.rbPersonalBooking.Text = "Personal Booking";
            this.rbPersonalBooking.UseVisualStyleBackColor = false;
            this.rbPersonalBooking.CheckedChanged += new System.EventHandler(this.rbPersonalBooking_CheckedChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblFirstName.Location = new System.Drawing.Point(5, 214);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.AutoSize = true;
            this.lblNumRooms.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRooms.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNumRooms.Location = new System.Drawing.Point(5, 266);
            this.lblNumRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumRooms.Name = "lblNumRooms";
            this.lblNumRooms.Size = new System.Drawing.Size(197, 20);
            this.lblNumRooms.TabIndex = 20;
            this.lblNumRooms.Text = "Number of rooms required:";
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNumPeople.Location = new System.Drawing.Point(3, 310);
            this.lblNumPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(139, 20);
            this.lblNumPeople.TabIndex = 21;
            this.lblNumPeople.Text = "Number of people:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBookingDate.Location = new System.Drawing.Point(5, 358);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(107, 20);
            this.lblBookingDate.TabIndex = 22;
            this.lblBookingDate.Text = "Booking date:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblCheckOut.Location = new System.Drawing.Point(448, 362);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(125, 20);
            this.lblCheckOut.TabIndex = 23;
            this.lblCheckOut.Text = "Check-out Date:";
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblSR.Location = new System.Drawing.Point(3, 444);
            this.lblSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(239, 20);
            this.lblSR.TabIndex = 24;
            this.lblSR.Text = "Special Requirements (optional):";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblCheckIn.Location = new System.Drawing.Point(136, 358);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(114, 20);
            this.lblCheckIn.TabIndex = 25;
            this.lblCheckIn.Text = "Check-in Date:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblEmail.Location = new System.Drawing.Point(9, 485);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFirstName.Location = new System.Drawing.Point(104, 216);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 19);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtNumRooms
            // 
            this.txtNumRooms.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNumRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRooms.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtNumRooms.Location = new System.Drawing.Point(194, 269);
            this.txtNumRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumRooms.Name = "txtNumRooms";
            this.txtNumRooms.Size = new System.Drawing.Size(239, 19);
            this.txtNumRooms.TabIndex = 28;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNumPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtNumPeople.Location = new System.Drawing.Point(192, 310);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(239, 19);
            this.txtNumPeople.TabIndex = 29;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtCheckInDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCheckInDate.Location = new System.Drawing.Point(248, 358);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(162, 19);
            this.txtCheckInDate.TabIndex = 30;
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtCheckOutDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCheckOutDate.Location = new System.Drawing.Point(568, 363);
            this.txtCheckOutDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(162, 19);
            this.txtCheckOutDate.TabIndex = 31;
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialReq.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSpecialReq.Location = new System.Drawing.Point(248, 442);
            this.txtSpecialReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpecialReq.Multiline = true;
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(372, 20);
            this.txtSpecialReq.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.Location = new System.Drawing.Point(77, 485);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 19);
            this.txtEmail.TabIndex = 33;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblLastName.Location = new System.Drawing.Point(292, 216);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name:";
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
            this.gBoxRoomPeople.Location = new System.Drawing.Point(833, 227);
            this.gBoxRoomPeople.Name = "gBoxRoomPeople";
            this.gBoxRoomPeople.Size = new System.Drawing.Size(262, 223);
            this.gBoxRoomPeople.TabIndex = 36;
            this.gBoxRoomPeople.TabStop = false;
            this.gBoxRoomPeople.Text = "Select room and Specify number of people";
            // 
            // lblRoomSelectionErr
            // 
            this.lblRoomSelectionErr.AutoSize = true;
            this.lblRoomSelectionErr.ForeColor = System.Drawing.Color.Red;
            this.lblRoomSelectionErr.Location = new System.Drawing.Point(14, 204);
            this.lblRoomSelectionErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomSelectionErr.Name = "lblRoomSelectionErr";
            this.lblRoomSelectionErr.Size = new System.Drawing.Size(35, 13);
            this.lblRoomSelectionErr.TabIndex = 31;
            this.lblRoomSelectionErr.Text = "label1";
            // 
            // cbRoom101
            // 
            this.cbRoom101.AutoSize = true;
            this.cbRoom101.ForeColor = System.Drawing.Color.NavajoWhite;
            this.cbRoom101.Location = new System.Drawing.Point(14, 26);
            this.cbRoom101.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoom101.Name = "cbRoom101";
            this.cbRoom101.Size = new System.Drawing.Size(75, 17);
            this.cbRoom101.TabIndex = 26;
            this.cbRoom101.Text = "Room 101";
            this.cbRoom101.UseVisualStyleBackColor = true;
            // 
            // txtRoom105
            // 
            this.txtRoom105.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom105.Location = new System.Drawing.Point(101, 176);
            this.txtRoom105.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom105.Name = "txtRoom105";
            this.txtRoom105.Size = new System.Drawing.Size(76, 20);
            this.txtRoom105.TabIndex = 25;
            // 
            // cbRoom105
            // 
            this.cbRoom105.AutoSize = true;
            this.cbRoom105.Location = new System.Drawing.Point(14, 178);
            this.cbRoom105.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoom105.Name = "cbRoom105";
            this.cbRoom105.Size = new System.Drawing.Size(75, 17);
            this.cbRoom105.TabIndex = 30;
            this.cbRoom105.Text = "Room 105";
            this.cbRoom105.UseVisualStyleBackColor = true;
            // 
            // txtRoom101
            // 
            this.txtRoom101.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom101.Location = new System.Drawing.Point(101, 24);
            this.txtRoom101.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom101.Name = "txtRoom101";
            this.txtRoom101.Size = new System.Drawing.Size(76, 20);
            this.txtRoom101.TabIndex = 21;
            // 
            // cbRoom104
            // 
            this.cbRoom104.AutoSize = true;
            this.cbRoom104.Location = new System.Drawing.Point(14, 137);
            this.cbRoom104.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoom104.Name = "cbRoom104";
            this.cbRoom104.Size = new System.Drawing.Size(75, 17);
            this.cbRoom104.TabIndex = 29;
            this.cbRoom104.Text = "Room 104";
            this.cbRoom104.UseVisualStyleBackColor = true;
            // 
            // txtRoom104
            // 
            this.txtRoom104.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom104.Location = new System.Drawing.Point(101, 135);
            this.txtRoom104.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom104.Name = "txtRoom104";
            this.txtRoom104.Size = new System.Drawing.Size(76, 20);
            this.txtRoom104.TabIndex = 24;
            // 
            // cbRoom102
            // 
            this.cbRoom102.AutoSize = true;
            this.cbRoom102.Location = new System.Drawing.Point(14, 59);
            this.cbRoom102.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoom102.Name = "cbRoom102";
            this.cbRoom102.Size = new System.Drawing.Size(75, 17);
            this.cbRoom102.TabIndex = 27;
            this.cbRoom102.Text = "Room 102";
            this.cbRoom102.UseVisualStyleBackColor = true;
            // 
            // cbRoom103
            // 
            this.cbRoom103.AutoSize = true;
            this.cbRoom103.Location = new System.Drawing.Point(14, 100);
            this.cbRoom103.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoom103.Name = "cbRoom103";
            this.cbRoom103.Size = new System.Drawing.Size(75, 17);
            this.cbRoom103.TabIndex = 28;
            this.cbRoom103.Text = "Room 103";
            this.cbRoom103.UseVisualStyleBackColor = true;
            // 
            // txtRoom102
            // 
            this.txtRoom102.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom102.Location = new System.Drawing.Point(101, 57);
            this.txtRoom102.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom102.Name = "txtRoom102";
            this.txtRoom102.Size = new System.Drawing.Size(76, 20);
            this.txtRoom102.TabIndex = 22;
            // 
            // txtRoom103
            // 
            this.txtRoom103.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtRoom103.Location = new System.Drawing.Point(101, 97);
            this.txtRoom103.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoom103.Name = "txtRoom103";
            this.txtRoom103.Size = new System.Drawing.Size(76, 20);
            this.txtRoom103.TabIndex = 23;
            // 
            // lblFNameErr
            // 
            this.lblFNameErr.AutoSize = true;
            this.lblFNameErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblFNameErr.Location = new System.Drawing.Point(101, 236);
            this.lblFNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFNameErr.Name = "lblFNameErr";
            this.lblFNameErr.Size = new System.Drawing.Size(35, 13);
            this.lblFNameErr.TabIndex = 37;
            this.lblFNameErr.Text = "label1";
            // 
            // lblLNameErr
            // 
            this.lblLNameErr.AutoSize = true;
            this.lblLNameErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblLNameErr.Location = new System.Drawing.Point(379, 236);
            this.lblLNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLNameErr.Name = "lblLNameErr";
            this.lblLNameErr.Size = new System.Drawing.Size(35, 13);
            this.lblLNameErr.TabIndex = 38;
            this.lblLNameErr.Text = "label2";
            // 
            // lblNoOfRoomsErr
            // 
            this.lblNoOfRoomsErr.AutoSize = true;
            this.lblNoOfRoomsErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNoOfRoomsErr.ForeColor = System.Drawing.Color.Red;
            this.lblNoOfRoomsErr.Location = new System.Drawing.Point(191, 289);
            this.lblNoOfRoomsErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfRoomsErr.Name = "lblNoOfRoomsErr";
            this.lblNoOfRoomsErr.Size = new System.Drawing.Size(35, 13);
            this.lblNoOfRoomsErr.TabIndex = 39;
            this.lblNoOfRoomsErr.Text = "label3";
            // 
            // lblNoOfPeopleErr
            // 
            this.lblNoOfPeopleErr.AutoSize = true;
            this.lblNoOfPeopleErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblNoOfPeopleErr.ForeColor = System.Drawing.Color.Red;
            this.lblNoOfPeopleErr.Location = new System.Drawing.Point(191, 331);
            this.lblNoOfPeopleErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfPeopleErr.Name = "lblNoOfPeopleErr";
            this.lblNoOfPeopleErr.Size = new System.Drawing.Size(35, 13);
            this.lblNoOfPeopleErr.TabIndex = 40;
            this.lblNoOfPeopleErr.Text = "label4";
            // 
            // lblCheckInDateErr
            // 
            this.lblCheckInDateErr.AutoSize = true;
            this.lblCheckInDateErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckInDateErr.ForeColor = System.Drawing.Color.Red;
            this.lblCheckInDateErr.Location = new System.Drawing.Point(245, 379);
            this.lblCheckInDateErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckInDateErr.Name = "lblCheckInDateErr";
            this.lblCheckInDateErr.Size = new System.Drawing.Size(35, 13);
            this.lblCheckInDateErr.TabIndex = 41;
            this.lblCheckInDateErr.Text = "label5";
            this.lblCheckInDateErr.Click += new System.EventHandler(this.lblCheckInDateErr_Click);
            // 
            // lblCheckOutDateErr
            // 
            this.lblCheckOutDateErr.AutoSize = true;
            this.lblCheckOutDateErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCheckOutDateErr.ForeColor = System.Drawing.Color.Red;
            this.lblCheckOutDateErr.Location = new System.Drawing.Point(566, 384);
            this.lblCheckOutDateErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOutDateErr.Name = "lblCheckOutDateErr";
            this.lblCheckOutDateErr.Size = new System.Drawing.Size(35, 13);
            this.lblCheckOutDateErr.TabIndex = 42;
            this.lblCheckOutDateErr.Text = "label6";
            this.lblCheckOutDateErr.Click += new System.EventHandler(this.lblCheckOutDateErr_Click);
            // 
            // lblEmailErr
            // 
            this.lblEmailErr.AutoSize = true;
            this.lblEmailErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEmailErr.ForeColor = System.Drawing.Color.Red;
            this.lblEmailErr.Location = new System.Drawing.Point(75, 505);
            this.lblEmailErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailErr.Name = "lblEmailErr";
            this.lblEmailErr.Size = new System.Drawing.Size(35, 13);
            this.lblEmailErr.TabIndex = 43;
            this.lblEmailErr.Text = "label7";
            // 
            // lblBookingTypeErr
            // 
            this.lblBookingTypeErr.AutoSize = true;
            this.lblBookingTypeErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingTypeErr.ForeColor = System.Drawing.Color.Red;
            this.lblBookingTypeErr.Location = new System.Drawing.Point(10, 184);
            this.lblBookingTypeErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingTypeErr.Name = "lblBookingTypeErr";
            this.lblBookingTypeErr.Size = new System.Drawing.Size(35, 13);
            this.lblBookingTypeErr.TabIndex = 44;
            this.lblBookingTypeErr.Text = "label8";
            // 
            // lblSpecialReqErr
            // 
            this.lblSpecialReqErr.AutoSize = true;
            this.lblSpecialReqErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSpecialReqErr.ForeColor = System.Drawing.Color.Red;
            this.lblSpecialReqErr.Location = new System.Drawing.Point(245, 464);
            this.lblSpecialReqErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialReqErr.Name = "lblSpecialReqErr";
            this.lblSpecialReqErr.Size = new System.Drawing.Size(35, 13);
            this.lblSpecialReqErr.TabIndex = 45;
            this.lblSpecialReqErr.Text = "label1";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 405);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 405);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(310, 20);
            this.txtPhoneNumber.TabIndex = 47;
            // 
            // lblPhoneNumberErr
            // 
            this.lblPhoneNumberErr.AutoSize = true;
            this.lblPhoneNumberErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPhoneNumberErr.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberErr.Location = new System.Drawing.Point(148, 426);
            this.lblPhoneNumberErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumberErr.Name = "lblPhoneNumberErr";
            this.lblPhoneNumberErr.Size = new System.Drawing.Size(35, 13);
            this.lblPhoneNumberErr.TabIndex = 48;
            this.lblPhoneNumberErr.Text = "label7";
            // 
            // lblAgencyNameErr
            // 
            this.lblAgencyNameErr.AutoSize = true;
            this.lblAgencyNameErr.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAgencyNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblAgencyNameErr.Location = new System.Drawing.Point(508, 180);
            this.lblAgencyNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencyNameErr.Name = "lblAgencyNameErr";
            this.lblAgencyNameErr.Size = new System.Drawing.Size(35, 13);
            this.lblAgencyNameErr.TabIndex = 54;
            this.lblAgencyNameErr.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 102);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblAgencyName
            // 
            this.lblAgencyName.AutoSize = true;
            this.lblAgencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblAgencyName.Location = new System.Drawing.Point(397, 159);
            this.lblAgencyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencyName.Name = "lblAgencyName";
            this.lblAgencyName.Size = new System.Drawing.Size(112, 20);
            this.lblAgencyName.TabIndex = 56;
            this.lblAgencyName.Text = "Agency Name:";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAgencyName.Location = new System.Drawing.Point(508, 159);
            this.txtAgencyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(170, 20);
            this.txtAgencyName.TabIndex = 57;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(381, 212);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 26);
            this.txtLastName.TabIndex = 58;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "The date format is: DD-MM-YY";
            // 
            // frmCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1028, 574);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAgencyName);
            this.Controls.Add(this.lblAgencyName);
            this.Controls.Add(this.lblAgencyNameErr);
            this.Controls.Add(this.lblPhoneNumberErr);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSpecialReqErr);
            this.Controls.Add(this.lblBookingTypeErr);
            this.Controls.Add(this.lblEmailErr);
            this.Controls.Add(this.lblCheckOutDateErr);
            this.Controls.Add(this.lblCheckInDateErr);
            this.Controls.Add(this.lblNoOfPeopleErr);
            this.Controls.Add(this.lblNoOfRoomsErr);
            this.Controls.Add(this.lblLNameErr);
            this.Controls.Add(this.lblFNameErr);
            this.Controls.Add(this.gBoxRoomPeople);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSpecialReq);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.txtCheckInDate);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.txtNumRooms);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblSR);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblNumPeople);
            this.Controls.Add(this.lblNumRooms);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.rbPersonalBooking);
            this.Controls.Add(this.rbTravelAgencyBooking);
            this.Controls.Add(this.btnCreateResClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCreateAReservation);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateReservation";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCreateReservation_Load);
            this.gBoxRoomPeople.ResumeLayout(false);
            this.gBoxRoomPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreateAReservation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCreateResClear;
        private System.Windows.Forms.RadioButton rbTravelAgencyBooking;
        private System.Windows.Forms.RadioButton rbPersonalBooking;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNumRooms;
        private System.Windows.Forms.Label lblNumPeople;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblSR;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtNumRooms;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.TextBox txtCheckOutDate;
        private System.Windows.Forms.TextBox txtSpecialReq;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gBoxRoomPeople;
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
        private System.Windows.Forms.Label lblFNameErr;
        private System.Windows.Forms.Label lblLNameErr;
        private System.Windows.Forms.Label lblNoOfRoomsErr;
        private System.Windows.Forms.Label lblNoOfPeopleErr;
        private System.Windows.Forms.Label lblCheckInDateErr;
        private System.Windows.Forms.Label lblCheckOutDateErr;
        private System.Windows.Forms.Label lblEmailErr;
        private System.Windows.Forms.Label lblBookingTypeErr;
        private System.Windows.Forms.Label lblSpecialReqErr;
        private System.Windows.Forms.Label lblRoomSelectionErr;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumberErr;
        private System.Windows.Forms.Label lblAgencyNameErr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAgencyName;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}