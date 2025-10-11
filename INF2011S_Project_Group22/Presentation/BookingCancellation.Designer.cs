namespace INF2011S_Project_Group22.Presentation
{
    partial class frmBookingCancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingCancellation));
            this.lblBookingNumberRemoved = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBookingCancelled = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingNumberRemoved
            // 
            this.lblBookingNumberRemoved.AutoSize = true;
            this.lblBookingNumberRemoved.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBookingNumberRemoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNumberRemoved.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBookingNumberRemoved.Location = new System.Drawing.Point(544, 547);
            this.lblBookingNumberRemoved.Name = "lblBookingNumberRemoved";
            this.lblBookingNumberRemoved.Size = new System.Drawing.Size(28, 16);
            this.lblBookingNumberRemoved.TabIndex = 3;
            this.lblBookingNumberRemoved.Text = "lbl2";
            this.lblBookingNumberRemoved.Click += new System.EventHandler(this.lblBookingNumberRemoved_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(64, 629);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBookingCancelled
            // 
            this.lblBookingCancelled.AutoSize = true;
            this.lblBookingCancelled.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingCancelled.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBookingCancelled.Location = new System.Drawing.Point(504, 181);
            this.lblBookingCancelled.Name = "lblBookingCancelled";
            this.lblBookingCancelled.Size = new System.Drawing.Size(351, 45);
            this.lblBookingCancelled.TabIndex = 5;
            this.lblBookingCancelled.Text = "Booking Cancelled!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1383, 131);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(512, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 293);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmBookingCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1349, 706);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBookingCancelled);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingNumberRemoved);
            this.Name = "frmBookingCancellation";
            this.Text = "BookingCancellation";
            this.Load += new System.EventHandler(this.frmBookingCancellation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingNumberRemoved;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookingCancelled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}