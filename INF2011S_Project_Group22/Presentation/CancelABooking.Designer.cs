namespace INF2011S_Project_Group22.Presentation
{
    partial class frmCancelABooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelABooking));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEnterResNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEnterResNumber = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFNameError = new System.Windows.Forms.Label();
            this.lblLNameError = new System.Windows.Forms.Label();
            this.lblBookingResError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1348, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cancel A Booking";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.OldLace;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLastName.Location = new System.Drawing.Point(271, 418);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEnterResNumber
            // 
            this.lblEnterResNumber.AutoSize = true;
            this.lblEnterResNumber.BackColor = System.Drawing.Color.OldLace;
            this.lblEnterResNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterResNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEnterResNumber.Location = new System.Drawing.Point(181, 484);
            this.lblEnterResNumber.Name = "lblEnterResNumber";
            this.lblEnterResNumber.Size = new System.Drawing.Size(322, 25);
            this.lblEnterResNumber.TabIndex = 3;
            this.lblEnterResNumber.Text = "Enter Booking Reservation Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Bisque;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(543, 415);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(448, 30);
            this.txtLastName.TabIndex = 4;
            // 
            // txtEnterResNumber
            // 
            this.txtEnterResNumber.BackColor = System.Drawing.Color.Bisque;
            this.txtEnterResNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterResNumber.Location = new System.Drawing.Point(543, 481);
            this.txtEnterResNumber.Name = "txtEnterResNumber";
            this.txtEnterResNumber.Size = new System.Drawing.Size(448, 30);
            this.txtEnterResNumber.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(879, 637);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(226, 57);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirm.Location = new System.Drawing.Point(1111, 637);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(226, 57);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.OldLace;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFirstName.Location = new System.Drawing.Point(271, 355);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Bisque;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(543, 352);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(448, 30);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFNameError
            // 
            this.lblFNameError.AutoSize = true;
            this.lblFNameError.BackColor = System.Drawing.Color.OldLace;
            this.lblFNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFNameError.Location = new System.Drawing.Point(543, 385);
            this.lblFNameError.Name = "lblFNameError";
            this.lblFNameError.Size = new System.Drawing.Size(95, 16);
            this.lblFNameError.TabIndex = 11;
            this.lblFNameError.Text = "lblFNameError";
            // 
            // lblLNameError
            // 
            this.lblLNameError.AutoSize = true;
            this.lblLNameError.BackColor = System.Drawing.Color.OldLace;
            this.lblLNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLNameError.Location = new System.Drawing.Point(543, 448);
            this.lblLNameError.Name = "lblLNameError";
            this.lblLNameError.Size = new System.Drawing.Size(44, 16);
            this.lblLNameError.TabIndex = 12;
            this.lblLNameError.Text = "label3";
            // 
            // lblBookingResError
            // 
            this.lblBookingResError.AutoSize = true;
            this.lblBookingResError.BackColor = System.Drawing.Color.OldLace;
            this.lblBookingResError.ForeColor = System.Drawing.Color.Red;
            this.lblBookingResError.Location = new System.Drawing.Point(543, 514);
            this.lblBookingResError.Name = "lblBookingResError";
            this.lblBookingResError.Size = new System.Drawing.Size(44, 16);
            this.lblBookingResError.TabIndex = 13;
            this.lblBookingResError.Text = "label4";
            // 
            // frmCancelABooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 706);
            this.Controls.Add(this.lblBookingResError);
            this.Controls.Add(this.lblLNameError);
            this.Controls.Add(this.lblFNameError);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEnterResNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblEnterResNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCancelABooking";
            this.Text = "CancelABooking";
            this.Load += new System.EventHandler(this.frmCancelABooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEnterResNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEnterResNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFNameError;
        private System.Windows.Forms.Label lblLNameError;
        private System.Windows.Forms.Label lblBookingResError;
    }
}