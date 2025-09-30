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
            this.lblGuestFullName = new System.Windows.Forms.Label();
            this.lblNumRooms = new System.Windows.Forms.Label();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblSR = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGuestFullName = new System.Windows.Forms.TextBox();
            this.txtNumRooms = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtSpecialReq = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 0);
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
            this.lblCreateAReservation.Location = new System.Drawing.Point(12, 201);
            this.lblCreateAReservation.Name = "lblCreateAReservation";
            this.lblCreateAReservation.Size = new System.Drawing.Size(349, 46);
            this.lblCreateAReservation.TabIndex = 2;
            this.lblCreateAReservation.Text = "Create a Reservation";
            // 
            // btnCreateResExit
            // 
            this.btnCreateResExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResExit.BackgroundImage")));
            this.btnCreateResExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResExit.Location = new System.Drawing.Point(12, 639);
            this.btnCreateResExit.Name = "btnCreateResExit";
            this.btnCreateResExit.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResExit.TabIndex = 14;
            this.btnCreateResExit.Text = "&Exit";
            this.btnCreateResExit.UseVisualStyleBackColor = true;
            // 
            // btnCreateResNext
            // 
            this.btnCreateResNext.BackColor = System.Drawing.Color.OldLace;
            this.btnCreateResNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResNext.BackgroundImage")));
            this.btnCreateResNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResNext.Location = new System.Drawing.Point(826, 639);
            this.btnCreateResNext.Name = "btnCreateResNext";
            this.btnCreateResNext.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResNext.TabIndex = 15;
            this.btnCreateResNext.Text = "Next";
            this.btnCreateResNext.UseVisualStyleBackColor = false;
            // 
            // btnCreateResClear
            // 
            this.btnCreateResClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResClear.BackgroundImage")));
            this.btnCreateResClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResClear.Location = new System.Drawing.Point(1085, 639);
            this.btnCreateResClear.Name = "btnCreateResClear";
            this.btnCreateResClear.Size = new System.Drawing.Size(253, 55);
            this.btnCreateResClear.TabIndex = 16;
            this.btnCreateResClear.Text = "Clear";
            this.btnCreateResClear.UseVisualStyleBackColor = true;
            // 
            // rbTravelAgencyBooking
            // 
            this.rbTravelAgencyBooking.AutoSize = true;
            this.rbTravelAgencyBooking.BackColor = System.Drawing.Color.OldLace;
            this.rbTravelAgencyBooking.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTravelAgencyBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbTravelAgencyBooking.Location = new System.Drawing.Point(323, 256);
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
            this.rbPersonalBooking.Location = new System.Drawing.Point(772, 256);
            this.rbPersonalBooking.Name = "rbPersonalBooking";
            this.rbPersonalBooking.Size = new System.Drawing.Size(157, 28);
            this.rbPersonalBooking.TabIndex = 18;
            this.rbPersonalBooking.TabStop = true;
            this.rbPersonalBooking.Text = "Personal Booking";
            this.rbPersonalBooking.UseVisualStyleBackColor = false;
            // 
            // lblGuestFullName
            // 
            this.lblGuestFullName.AutoSize = true;
            this.lblGuestFullName.BackColor = System.Drawing.Color.OldLace;
            this.lblGuestFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGuestFullName.Location = new System.Drawing.Point(348, 314);
            this.lblGuestFullName.Name = "lblGuestFullName";
            this.lblGuestFullName.Size = new System.Drawing.Size(163, 25);
            this.lblGuestFullName.TabIndex = 19;
            this.lblGuestFullName.Text = "Guest Full Name:";
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.AutoSize = true;
            this.lblNumRooms.BackColor = System.Drawing.Color.OldLace;
            this.lblNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumRooms.Location = new System.Drawing.Point(318, 365);
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
            this.lblBookingDate.Location = new System.Drawing.Point(366, 484);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(132, 25);
            this.lblBookingDate.TabIndex = 22;
            this.lblBookingDate.Text = "Booking date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.OldLace;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEnd.Location = new System.Drawing.Point(975, 484);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 25);
            this.lblEnd.TabIndex = 23;
            this.lblEnd.Text = "End:";
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
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.OldLace;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStart.Location = new System.Drawing.Point(637, 484);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(59, 25);
            this.lblStart.TabIndex = 25;
            this.lblStart.Text = "Start:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1351, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // txtGuestFullName
            // 
            this.txtGuestFullName.BackColor = System.Drawing.Color.Bisque;
            this.txtGuestFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuestFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestFullName.Location = new System.Drawing.Point(642, 311);
            this.txtGuestFullName.Name = "txtGuestFullName";
            this.txtGuestFullName.Size = new System.Drawing.Size(496, 23);
            this.txtGuestFullName.TabIndex = 27;
            // 
            // txtNumRooms
            // 
            this.txtNumRooms.BackColor = System.Drawing.Color.Bisque;
            this.txtNumRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRooms.Location = new System.Drawing.Point(642, 362);
            this.txtNumRooms.Name = "txtNumRooms";
            this.txtNumRooms.Size = new System.Drawing.Size(319, 23);
            this.txtNumRooms.TabIndex = 28;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.Color.Bisque;
            this.txtNumPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.Location = new System.Drawing.Point(642, 415);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(319, 23);
            this.txtNumPeople.TabIndex = 29;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.Bisque;
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(702, 484);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(216, 23);
            this.txtStartDate.TabIndex = 30;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.Bisque;
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(1034, 484);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(216, 23);
            this.txtEndDate.TabIndex = 31;
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.BackColor = System.Drawing.Color.Bisque;
            this.txtSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialReq.Location = new System.Drawing.Point(642, 537);
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(496, 23);
            this.txtSpecialReq.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(642, 594);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(496, 23);
            this.txtEmail.TabIndex = 33;
            // 
            // frmCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 706);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSpecialReq);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.txtNumRooms);
            this.Controls.Add(this.txtGuestFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblSR);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblNumPeople);
            this.Controls.Add(this.lblNumRooms);
            this.Controls.Add(this.lblGuestFullName);
            this.Controls.Add(this.rbPersonalBooking);
            this.Controls.Add(this.rbTravelAgencyBooking);
            this.Controls.Add(this.btnCreateResClear);
            this.Controls.Add(this.btnCreateResNext);
            this.Controls.Add(this.btnCreateResExit);
            this.Controls.Add(this.lblCreateAReservation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Label lblGuestFullName;
        private System.Windows.Forms.Label lblNumRooms;
        private System.Windows.Forms.Label lblNumPeople;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblSR;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGuestFullName;
        private System.Windows.Forms.TextBox txtNumRooms;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtSpecialReq;
        private System.Windows.Forms.TextBox txtEmail;
    }
}