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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateReservation));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCreateAReservation = new System.Windows.Forms.Label();
            this.btnCreateResExit = new System.Windows.Forms.Button();
            this.btnCreateResNext = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblCreateAReservation
            // 
            this.lblCreateAReservation.AutoSize = true;
            this.lblCreateAReservation.BackColor = System.Drawing.Color.OldLace;
            this.lblCreateAReservation.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCreateAReservation.Location = new System.Drawing.Point(12, 217);
            this.lblCreateAReservation.Name = "lblCreateAReservation";
            this.lblCreateAReservation.Size = new System.Drawing.Size(349, 46);
            this.lblCreateAReservation.TabIndex = 2;
            this.lblCreateAReservation.Text = "Create a Reservation";
            // 
            // btnCreateResExit
            // 
            this.btnCreateResExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResExit.BackgroundImage")));
            this.btnCreateResExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResExit.Location = new System.Drawing.Point(12, 639);
            this.btnCreateResExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateResExit.Name = "btnCreateResExit";
            this.btnCreateResExit.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResExit.TabIndex = 14;
            this.btnCreateResExit.Text = "&Exit";
            this.btnCreateResExit.UseVisualStyleBackColor = true;
            this.btnCreateResExit.Click += new System.EventHandler(this.btnCreateResExit_Click);
            // 
            // btnCreateResNext
            // 
            this.btnCreateResNext.BackColor = System.Drawing.Color.OldLace;
            this.btnCreateResNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResNext.BackgroundImage")));
            this.btnCreateResNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResNext.Location = new System.Drawing.Point(827, 639);
            this.btnCreateResNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateResNext.Name = "btnCreateResNext";
            this.btnCreateResNext.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResNext.TabIndex = 15;
            this.btnCreateResNext.Text = "Next";
            this.btnCreateResNext.UseVisualStyleBackColor = false;
            this.btnCreateResNext.Click += new System.EventHandler(this.btnCreateResNext_Click);
            // 
            // btnCreateResClear
            // 
            this.btnCreateResClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResClear.BackgroundImage")));
            this.btnCreateResClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResClear.Location = new System.Drawing.Point(1085, 639);
            this.btnCreateResClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateResClear.Name = "btnCreateResClear";
            this.btnCreateResClear.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResClear.TabIndex = 16;
            this.btnCreateResClear.Text = "Clear";
            this.btnCreateResClear.UseVisualStyleBackColor = true;
            this.btnCreateResClear.Click += new System.EventHandler(this.btnCreateResClear_Click);
            // 
            // rbTravelAgencyBooking
            // 
            this.rbTravelAgencyBooking.AutoSize = true;
            this.rbTravelAgencyBooking.BackColor = System.Drawing.Color.OldLace;
            this.rbTravelAgencyBooking.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTravelAgencyBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbTravelAgencyBooking.Location = new System.Drawing.Point(323, 265);
            this.rbTravelAgencyBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTravelAgencyBooking.Name = "rbTravelAgencyBooking";
            this.rbTravelAgencyBooking.Size = new System.Drawing.Size(199, 28);
            this.rbTravelAgencyBooking.TabIndex = 17;
            this.rbTravelAgencyBooking.TabStop = true;
            this.rbTravelAgencyBooking.Text = "Travel Agency Booking";
            this.rbTravelAgencyBooking.UseVisualStyleBackColor = false;
            // 
            // rbPersonalBooking
            // 
            this.rbPersonalBooking.AutoSize = true;
            this.rbPersonalBooking.BackColor = System.Drawing.Color.OldLace;
            this.rbPersonalBooking.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonalBooking.Location = new System.Drawing.Point(772, 265);
            this.rbPersonalBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPersonalBooking.Name = "rbPersonalBooking";
            this.rbPersonalBooking.Size = new System.Drawing.Size(157, 28);
            this.rbPersonalBooking.TabIndex = 18;
            this.rbPersonalBooking.TabStop = true;
            this.rbPersonalBooking.Text = "Personal Booking";
            this.rbPersonalBooking.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.OldLace;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFirstName.Location = new System.Drawing.Point(348, 314);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.AutoSize = true;
            this.lblNumRooms.BackColor = System.Drawing.Color.OldLace;
            this.lblNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumRooms.Location = new System.Drawing.Point(318, 368);
            this.lblNumRooms.Name = "lblNumRooms";
            this.lblNumRooms.Size = new System.Drawing.Size(243, 25);
            this.lblNumRooms.TabIndex = 20;
            this.lblNumRooms.Text = "Number of rooms required:";
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.BackColor = System.Drawing.Color.OldLace;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumPeople.Location = new System.Drawing.Point(348, 418);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(172, 25);
            this.lblNumPeople.TabIndex = 21;
            this.lblNumPeople.Text = "Number of people:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.Color.OldLace;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBookingDate.Location = new System.Drawing.Point(365, 484);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(132, 25);
            this.lblBookingDate.TabIndex = 22;
            this.lblBookingDate.Text = "Booking date:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.BackColor = System.Drawing.Color.OldLace;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCheckOut.Location = new System.Drawing.Point(925, 482);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(155, 25);
            this.lblCheckOut.TabIndex = 23;
            this.lblCheckOut.Text = "Check-out Date:";
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.BackColor = System.Drawing.Color.OldLace;
            this.lblSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSR.Location = new System.Drawing.Point(297, 540);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(291, 25);
            this.lblSR.TabIndex = 24;
            this.lblSR.Text = "Special Requirements (optonal):";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.BackColor = System.Drawing.Color.OldLace;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCheckIn.Location = new System.Drawing.Point(552, 484);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(143, 25);
            this.lblCheckIn.TabIndex = 25;
            this.lblCheckIn.Text = "Check-in Date:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.OldLace;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(396, 597);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Bisque;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(532, 316);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 23);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtNumRooms
            // 
            this.txtNumRooms.BackColor = System.Drawing.Color.Bisque;
            this.txtNumRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRooms.Location = new System.Drawing.Point(643, 368);
            this.txtNumRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumRooms.Name = "txtNumRooms";
            this.txtNumRooms.Size = new System.Drawing.Size(319, 23);
            this.txtNumRooms.TabIndex = 28;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.Color.Bisque;
            this.txtNumPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.Location = new System.Drawing.Point(643, 415);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(319, 23);
            this.txtNumPeople.TabIndex = 29;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.BackColor = System.Drawing.Color.Bisque;
            this.txtCheckInDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate.Location = new System.Drawing.Point(701, 484);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(216, 23);
            this.txtCheckInDate.TabIndex = 30;
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.BackColor = System.Drawing.Color.Bisque;
            this.txtCheckOutDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutDate.Location = new System.Drawing.Point(1085, 484);
            this.txtCheckOutDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(216, 23);
            this.txtCheckOutDate.TabIndex = 31;
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.BackColor = System.Drawing.Color.Bisque;
            this.txtSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialReq.Location = new System.Drawing.Point(643, 537);
            this.txtSpecialReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(496, 23);
            this.txtSpecialReq.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(643, 594);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(496, 23);
            this.txtEmail.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1355, 706);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Bisque;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(992, 314);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(286, 23);
            this.txtLastName.TabIndex = 34;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.OldLace;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLastName.Location = new System.Drawing.Point(822, 316);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 25);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // frmCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 706);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
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
            this.Controls.Add(this.btnCreateResNext);
            this.Controls.Add(this.btnCreateResExit);
            this.Controls.Add(this.lblCreateAReservation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateReservation";
            this.Text = "Create A Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCreateAReservation;
        private System.Windows.Forms.Button btnCreateResExit;
        private System.Windows.Forms.Button btnCreateResNext;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}