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
            this.lblGuestFullName = new System.Windows.Forms.Label();
            this.lblEnterResNumber = new System.Windows.Forms.Label();
            this.txtGuestFullName = new System.Windows.Forms.TextBox();
            this.txtEnterResNumber = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cancel a Booking";
            // 
            // lblGuestFullName
            // 
            this.lblGuestFullName.AutoSize = true;
            this.lblGuestFullName.BackColor = System.Drawing.Color.OldLace;
            this.lblGuestFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGuestFullName.Location = new System.Drawing.Point(257, 357);
            this.lblGuestFullName.Name = "lblGuestFullName";
            this.lblGuestFullName.Size = new System.Drawing.Size(163, 25);
            this.lblGuestFullName.TabIndex = 2;
            this.lblGuestFullName.Text = "Guest Full Name:";
            // 
            // lblEnterResNumber
            // 
            this.lblEnterResNumber.AutoSize = true;
            this.lblEnterResNumber.BackColor = System.Drawing.Color.OldLace;
            this.lblEnterResNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterResNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEnterResNumber.Location = new System.Drawing.Point(192, 421);
            this.lblEnterResNumber.Name = "lblEnterResNumber";
            this.lblEnterResNumber.Size = new System.Drawing.Size(322, 25);
            this.lblEnterResNumber.TabIndex = 3;
            this.lblEnterResNumber.Text = "Enter Booking Reservation Number:";
            // 
            // txtGuestFullName
            // 
            this.txtGuestFullName.BackColor = System.Drawing.Color.Bisque;
            this.txtGuestFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestFullName.Location = new System.Drawing.Point(543, 357);
            this.txtGuestFullName.Name = "txtGuestFullName";
            this.txtGuestFullName.Size = new System.Drawing.Size(448, 30);
            this.txtGuestFullName.TabIndex = 4;
            // 
            // txtEnterResNumber
            // 
            this.txtEnterResNumber.BackColor = System.Drawing.Color.Bisque;
            this.txtEnterResNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterResNumber.Location = new System.Drawing.Point(543, 421);
            this.txtEnterResNumber.Name = "txtEnterResNumber";
            this.txtEnterResNumber.Size = new System.Drawing.Size(448, 30);
            this.txtEnterResNumber.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(879, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfirm.Location = new System.Drawing.Point(1111, 637);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(226, 57);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmCancelABooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 706);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEnterResNumber);
            this.Controls.Add(this.txtGuestFullName);
            this.Controls.Add(this.lblEnterResNumber);
            this.Controls.Add(this.lblGuestFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCancelABooking";
            this.Text = "CancelABooking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuestFullName;
        private System.Windows.Forms.Label lblEnterResNumber;
        private System.Windows.Forms.TextBox txtGuestFullName;
        private System.Windows.Forms.TextBox txtEnterResNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
    }
}