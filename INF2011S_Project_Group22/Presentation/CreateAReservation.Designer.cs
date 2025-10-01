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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGuestFullName = new System.Windows.Forms.TextBox();
            this.txtNumRooms = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtSpecialReq = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblCreateAReservation
            // 
            this.lblCreateAReservation.AutoSize = true;
            this.lblCreateAReservation.BackColor = System.Drawing.Color.OldLace;
            this.lblCreateAReservation.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCreateAReservation.Location = new System.Drawing.Point(9, 176);
            this.lblCreateAReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAReservation.Name = "lblCreateAReservation";
            this.lblCreateAReservation.Size = new System.Drawing.Size(277, 36);
            this.lblCreateAReservation.TabIndex = 2;
            this.lblCreateAReservation.Text = "Create a Reservation";
            // 
            // btnCreateResExit
            // 
            this.btnCreateResExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResExit.BackgroundImage")));
            this.btnCreateResExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResExit.Location = new System.Drawing.Point(9, 519);
            this.btnCreateResExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateResExit.Name = "btnCreateResExit";
            this.btnCreateResExit.Size = new System.Drawing.Size(190, 45);
            this.btnCreateResExit.TabIndex = 14;
            this.btnCreateResExit.Text = "&Exit";
            this.btnCreateResExit.UseVisualStyleBackColor = true;
            // 
            // btnCreateResNext
            // 
            this.btnCreateResNext.BackColor = System.Drawing.Color.OldLace;
            this.btnCreateResNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResNext.BackgroundImage")));
            this.btnCreateResNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResNext.Location = new System.Drawing.Point(620, 519);
            this.btnCreateResNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateResNext.Name = "btnCreateResNext";
            this.btnCreateResNext.Size = new System.Drawing.Size(190, 45);
            this.btnCreateResNext.TabIndex = 15;
            this.btnCreateResNext.Text = "Next";
            this.btnCreateResNext.UseVisualStyleBackColor = false;
            // 
            // btnCreateResClear
            // 
            this.btnCreateResClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateResClear.BackgroundImage")));
            this.btnCreateResClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateResClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateResClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreateResClear.Location = new System.Drawing.Point(814, 519);
            this.btnCreateResClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateResClear.Name = "btnCreateResClear";
            this.btnCreateResClear.Size = new System.Drawing.Size(190, 45);
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
            this.rbTravelAgencyBooking.Location = new System.Drawing.Point(242, 215);
            this.rbTravelAgencyBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTravelAgencyBooking.Name = "rbTravelAgencyBooking";
            this.rbTravelAgencyBooking.Size = new System.Drawing.Size(167, 24);
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
            this.rbPersonalBooking.Location = new System.Drawing.Point(579, 215);
            this.rbPersonalBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPersonalBooking.Name = "rbPersonalBooking";
            this.rbPersonalBooking.Size = new System.Drawing.Size(134, 24);
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
            this.lblGuestFullName.Location = new System.Drawing.Point(261, 255);
            this.lblGuestFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuestFullName.Name = "lblGuestFullName";
            this.lblGuestFullName.Size = new System.Drawing.Size(132, 20);
            this.lblGuestFullName.TabIndex = 19;
            this.lblGuestFullName.Text = "Guest Full Name:";
            // 
            // lblNumRooms
            // 
            this.lblNumRooms.AutoSize = true;
            this.lblNumRooms.BackColor = System.Drawing.Color.OldLace;
            this.lblNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumRooms.Location = new System.Drawing.Point(238, 297);
            this.lblNumRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumRooms.Name = "lblNumRooms";
            this.lblNumRooms.Size = new System.Drawing.Size(197, 20);
            this.lblNumRooms.TabIndex = 20;
            this.lblNumRooms.Text = "Number of rooms required:";
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.BackColor = System.Drawing.Color.OldLace;
            this.lblNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumPeople.Location = new System.Drawing.Point(261, 340);
            this.lblNumPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(139, 20);
            this.lblNumPeople.TabIndex = 21;
            this.lblNumPeople.Text = "Number of people:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.Color.OldLace;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBookingDate.Location = new System.Drawing.Point(274, 393);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(107, 20);
            this.lblBookingDate.TabIndex = 22;
            this.lblBookingDate.Text = "Booking date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.OldLace;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEnd.Location = new System.Drawing.Point(731, 393);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(42, 20);
            this.lblEnd.TabIndex = 23;
            this.lblEnd.Text = "End:";
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.BackColor = System.Drawing.Color.OldLace;
            this.lblSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSR.Location = new System.Drawing.Point(223, 439);
            this.lblSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(236, 20);
            this.lblSR.TabIndex = 24;
            this.lblSR.Text = "Special Requirements (optonal):";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.OldLace;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStart.Location = new System.Drawing.Point(478, 393);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(48, 20);
            this.lblStart.TabIndex = 25;
            this.lblStart.Text = "Start:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.OldLace;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(297, 485);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email:";
            // 
            // txtGuestFullName
            // 
            this.txtGuestFullName.BackColor = System.Drawing.Color.Bisque;
            this.txtGuestFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuestFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestFullName.Location = new System.Drawing.Point(482, 253);
            this.txtGuestFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuestFullName.Name = "txtGuestFullName";
            this.txtGuestFullName.Size = new System.Drawing.Size(372, 19);
            this.txtGuestFullName.TabIndex = 27;
            // 
            // txtNumRooms
            // 
            this.txtNumRooms.BackColor = System.Drawing.Color.Bisque;
            this.txtNumRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRooms.Location = new System.Drawing.Point(482, 294);
            this.txtNumRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumRooms.Name = "txtNumRooms";
            this.txtNumRooms.Size = new System.Drawing.Size(239, 19);
            this.txtNumRooms.TabIndex = 28;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.BackColor = System.Drawing.Color.Bisque;
            this.txtNumPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.Location = new System.Drawing.Point(482, 337);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(239, 19);
            this.txtNumPeople.TabIndex = 29;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.Bisque;
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(526, 393);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(162, 19);
            this.txtStartDate.TabIndex = 30;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.Bisque;
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(776, 393);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(162, 19);
            this.txtEndDate.TabIndex = 31;
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.BackColor = System.Drawing.Color.Bisque;
            this.txtSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialReq.Location = new System.Drawing.Point(482, 436);
            this.txtSpecialReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(372, 19);
            this.txtSpecialReq.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(482, 483);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 19);
            this.txtEmail.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 574);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 574);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGuestFullName;
        private System.Windows.Forms.TextBox txtNumRooms;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtSpecialReq;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}