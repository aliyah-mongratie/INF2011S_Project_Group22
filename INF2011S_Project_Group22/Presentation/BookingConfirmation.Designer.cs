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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBookingConfirmed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookingReservation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 708);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(21, 604);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(215, 105);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblBookingReservation
            // 
            this.lblBookingReservation.AutoSize = true;
            this.lblBookingReservation.Location = new System.Drawing.Point(496, 578);
            this.lblBookingReservation.Name = "lblBookingReservation";
            this.lblBookingReservation.Size = new System.Drawing.Size(28, 16);
            this.lblBookingReservation.TabIndex = 4;
            this.lblBookingReservation.Text = "lbl1";
            // 
            // BookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 698);
            this.Controls.Add(this.lblBookingReservation);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBookingConfirmed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookingConfirmation";
            this.Text = "BookingConfirmation";
            this.Load += new System.EventHandler(this.BookingConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBookingConfirmed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBookingReservation;
    }
}