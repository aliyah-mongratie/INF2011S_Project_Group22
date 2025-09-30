namespace INF2011S_Project_Group22
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelABooking = new System.Windows.Forms.Button();
            this.btnBookingEnquiry = new System.Windows.Forms.Button();
            this.btnViewAvailability = new System.Windows.Forms.Button();
            this.btnMakeABooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1378, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 362);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(1001, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(990, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "What would you like to do?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancelABooking
            // 
            this.btnCancelABooking.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelABooking.Image")));
            this.btnCancelABooking.Location = new System.Drawing.Point(983, 418);
            this.btnCancelABooking.Name = "btnCancelABooking";
            this.btnCancelABooking.Size = new System.Drawing.Size(261, 61);
            this.btnCancelABooking.TabIndex = 6;
            this.btnCancelABooking.Text = "Cancel A Booking";
            this.btnCancelABooking.UseVisualStyleBackColor = true;
            // 
            // btnBookingEnquiry
            // 
            this.btnBookingEnquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingEnquiry.Image")));
            this.btnBookingEnquiry.Location = new System.Drawing.Point(983, 485);
            this.btnBookingEnquiry.Name = "btnBookingEnquiry";
            this.btnBookingEnquiry.Size = new System.Drawing.Size(261, 57);
            this.btnBookingEnquiry.TabIndex = 7;
            this.btnBookingEnquiry.Text = "Booking Enquiry";
            this.btnBookingEnquiry.UseVisualStyleBackColor = true;
            this.btnBookingEnquiry.Click += new System.EventHandler(this.btnBookingEnquiry_Click);
            // 
            // btnViewAvailability
            // 
            this.btnViewAvailability.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAvailability.Image")));
            this.btnViewAvailability.Location = new System.Drawing.Point(983, 562);
            this.btnViewAvailability.Name = "btnViewAvailability";
            this.btnViewAvailability.Size = new System.Drawing.Size(261, 55);
            this.btnViewAvailability.TabIndex = 8;
            this.btnViewAvailability.Text = "View Availability";
            this.btnViewAvailability.UseVisualStyleBackColor = true;
            // 
            // btnMakeABooking
            // 
            this.btnMakeABooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakeABooking.BackgroundImage")));
            this.btnMakeABooking.Location = new System.Drawing.Point(983, 357);
            this.btnMakeABooking.Name = "btnMakeABooking";
            this.btnMakeABooking.Size = new System.Drawing.Size(259, 55);
            this.btnMakeABooking.TabIndex = 13;
            this.btnMakeABooking.Text = "Make A Booking";
            this.btnMakeABooking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1350, 705);
            this.Controls.Add(this.btnMakeABooking);
            this.Controls.Add(this.btnViewAvailability);
            this.Controls.Add(this.btnBookingEnquiry);
            this.Controls.Add(this.btnCancelABooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Phumla Kamnandi Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelABooking;
        private System.Windows.Forms.Button btnBookingEnquiry;
        private System.Windows.Forms.Button btnViewAvailability;
        private System.Windows.Forms.Button btnMakeABooking;
    }
}

