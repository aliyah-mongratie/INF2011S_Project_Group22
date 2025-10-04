namespace INF2011S_Project_Group22.Presentation
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMakeABooking = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewAvailability = new System.Windows.Forms.Button();
            this.btnCancelABooking = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1748, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(-5, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 370);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnMakeABooking
            // 
            this.btnMakeABooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakeABooking.BackgroundImage")));
            this.btnMakeABooking.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeABooking.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMakeABooking.Location = new System.Drawing.Point(1006, 342);
            this.btnMakeABooking.Name = "btnMakeABooking";
            this.btnMakeABooking.Size = new System.Drawing.Size(252, 55);
            this.btnMakeABooking.TabIndex = 3;
            this.btnMakeABooking.Text = "Make a Booking";
            this.btnMakeABooking.UseVisualStyleBackColor = true;
            this.btnMakeABooking.Click += new System.EventHandler(this.btnMakeABooking_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWelcome.Location = new System.Drawing.Point(1031, 225);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(178, 46);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(1014, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "What would you like to do?";
            // 
            // btnViewAvailability
            // 
            this.btnViewAvailability.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewAvailability.BackgroundImage")));
            this.btnViewAvailability.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAvailability.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewAvailability.Location = new System.Drawing.Point(1012, 559);
            this.btnViewAvailability.Name = "btnViewAvailability";
            this.btnViewAvailability.Size = new System.Drawing.Size(252, 52);
            this.btnViewAvailability.TabIndex = 6;
            this.btnViewAvailability.Text = "View Availability";
            this.btnViewAvailability.UseVisualStyleBackColor = true;
            this.btnViewAvailability.Click += new System.EventHandler(this.btnViewAvailability_Click);
            // 
            // btnCancelABooking
            // 
            this.btnCancelABooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelABooking.BackgroundImage")));
            this.btnCancelABooking.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelABooking.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelABooking.Location = new System.Drawing.Point(1009, 412);
            this.btnCancelABooking.Name = "btnCancelABooking";
            this.btnCancelABooking.Size = new System.Drawing.Size(252, 53);
            this.btnCancelABooking.TabIndex = 7;
            this.btnCancelABooking.Text = "Cancel A Booking";
            this.btnCancelABooking.UseVisualStyleBackColor = true;
            this.btnCancelABooking.Click += new System.EventHandler(this.btnCancelABooking_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(1009, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 57);
            this.button4.TabIndex = 8;
            this.button4.Text = "Booking Enquiry";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 742);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCancelABooking);
            this.Controls.Add(this.btnViewAvailability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMakeABooking);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMakeABooking;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewAvailability;
        private System.Windows.Forms.Button btnCancelABooking;
        private System.Windows.Forms.Button button4;
    }
}