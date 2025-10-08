namespace INF2011S_Project_Group22.Presentation
{
    partial class BookingConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingConfirmation));
            this.lblBookingConfirmed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBookingReservation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingConfirmed
            // 
            this.lblBookingConfirmed.AutoSize = true;
            this.lblBookingConfirmed.BackColor = System.Drawing.Color.OldLace;
            this.lblBookingConfirmed.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingConfirmed.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBookingConfirmed.Location = new System.Drawing.Point(529, 260);
            this.lblBookingConfirmed.Name = "lblBookingConfirmed";
            this.lblBookingConfirmed.Size = new System.Drawing.Size(327, 36);
            this.lblBookingConfirmed.TabIndex = 1;
            this.lblBookingConfirmed.Text = "Booking Confirmed!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 259);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblBookingReservation
            // 
            this.lblBookingReservation.AutoSize = true;
            this.lblBookingReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingReservation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBookingReservation.Location = new System.Drawing.Point(496, 578);
            this.lblBookingReservation.Name = "lblBookingReservation";
            this.lblBookingReservation.Size = new System.Drawing.Size(43, 24);
            this.lblBookingReservation.TabIndex = 4;
            this.lblBookingReservation.Text = "lbl1";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(29, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(254, 56);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // BookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1359, 698);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingReservation);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBookingConfirmed);
            this.Name = "BookingConfirmation";
            this.Text = "BookingConfirmation";
            this.Load += new System.EventHandler(this.BookingConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingConfirmed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBookingReservation;
        private System.Windows.Forms.Button btnBack;
    }
}