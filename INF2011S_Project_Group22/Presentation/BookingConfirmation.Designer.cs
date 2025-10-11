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
            this.lblBookingReservation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblbookingcon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblBookingConfirmed.Size = new System.Drawing.Size(0, 36);
            this.lblBookingConfirmed.TabIndex = 1;
            // 
            // lblBookingReservation
            // 
            this.lblBookingReservation.AutoSize = true;
            this.lblBookingReservation.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingReservation.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBookingReservation.Location = new System.Drawing.Point(531, 519);
            this.lblBookingReservation.Name = "lblBookingReservation";
            this.lblBookingReservation.Size = new System.Drawing.Size(43, 24);
            this.lblBookingReservation.TabIndex = 4;
            this.lblBookingReservation.Text = "lbl1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(29, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(254, 56);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 293);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblbookingcon
            // 
            this.lblbookingcon.AutoSize = true;
            this.lblbookingcon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingcon.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblbookingcon.Location = new System.Drawing.Point(527, 165);
            this.lblbookingcon.Name = "lblbookingcon";
            this.lblbookingcon.Size = new System.Drawing.Size(369, 45);
            this.lblbookingcon.TabIndex = 9;
            this.lblbookingcon.Text = "Booking Confirmed!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1383, 131);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1359, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbookingcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingReservation);
            this.Controls.Add(this.lblBookingConfirmed);
            this.Name = "BookingConfirmation";
            this.Text = "BookingConfirmation";
            this.Load += new System.EventHandler(this.BookingConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingConfirmed;
        private System.Windows.Forms.Label lblBookingReservation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblbookingcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}