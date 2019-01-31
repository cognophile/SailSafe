namespace SailSafe___1413042
{
    partial class NewBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBookingForm));
            this.txtLicenseBook = new System.Windows.Forms.TextBox();
            this.lblLicenseBooking = new System.Windows.Forms.Label();
            this.lblBookInstruct = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblNameBooking = new System.Windows.Forms.Label();
            this.btnBookHome = new System.Windows.Forms.Button();
            this.rad9amBook = new System.Windows.Forms.RadioButton();
            this.rad10amBook = new System.Windows.Forms.RadioButton();
            this.btnWriteStream = new System.Windows.Forms.Button();
            this.radCar = new System.Windows.Forms.RadioButton();
            this.radVan = new System.Windows.Forms.RadioButton();
            this.radLargeVehicle = new System.Windows.Forms.RadioButton();
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.rad5pmBook = new System.Windows.Forms.RadioButton();
            this.rad4pmBook = new System.Windows.Forms.RadioButton();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.btnResetBook = new System.Windows.Forms.Button();
            this.grpDirection.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLicenseBook
            // 
            this.txtLicenseBook.Location = new System.Drawing.Point(12, 136);
            this.txtLicenseBook.Name = "txtLicenseBook";
            this.txtLicenseBook.Size = new System.Drawing.Size(202, 20);
            this.txtLicenseBook.TabIndex = 1;
            // 
            // lblLicenseBooking
            // 
            this.lblLicenseBooking.AutoSize = true;
            this.lblLicenseBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseBooking.Location = new System.Drawing.Point(9, 120);
            this.lblLicenseBooking.Name = "lblLicenseBooking";
            this.lblLicenseBooking.Size = new System.Drawing.Size(88, 13);
            this.lblLicenseBooking.TabIndex = 16;
            this.lblLicenseBooking.Text = "License Plate:";
            // 
            // lblBookInstruct
            // 
            this.lblBookInstruct.AutoSize = true;
            this.lblBookInstruct.BackColor = System.Drawing.Color.Transparent;
            this.lblBookInstruct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookInstruct.Location = new System.Drawing.Point(165, 9);
            this.lblBookInstruct.Name = "lblBookInstruct";
            this.lblBookInstruct.Size = new System.Drawing.Size(463, 19);
            this.lblBookInstruct.TabIndex = 15;
            this.lblBookInstruct.Text = "Please Enter the Details Required Below and Click Save";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(12, 81);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(202, 20);
            this.txtBookName.TabIndex = 0;
            // 
            // lblNameBooking
            // 
            this.lblNameBooking.AutoSize = true;
            this.lblNameBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblNameBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBooking.Location = new System.Drawing.Point(9, 65);
            this.lblNameBooking.Name = "lblNameBooking";
            this.lblNameBooking.Size = new System.Drawing.Size(67, 13);
            this.lblNameBooking.TabIndex = 13;
            this.lblNameBooking.Text = "Full Name:";
            // 
            // btnBookHome
            // 
            this.btnBookHome.Location = new System.Drawing.Point(706, 319);
            this.btnBookHome.Name = "btnBookHome";
            this.btnBookHome.Size = new System.Drawing.Size(66, 24);
            this.btnBookHome.TabIndex = 11;
            this.btnBookHome.Text = "Home";
            this.btnBookHome.UseVisualStyleBackColor = true;
            this.btnBookHome.Click += new System.EventHandler(this.button4_Click);
            // 
            // rad9amBook
            // 
            this.rad9amBook.AutoSize = true;
            this.rad9amBook.BackColor = System.Drawing.Color.Transparent;
            this.rad9amBook.Location = new System.Drawing.Point(9, 26);
            this.rad9amBook.Name = "rad9amBook";
            this.rad9amBook.Size = new System.Drawing.Size(77, 18);
            this.rad9amBook.TabIndex = 2;
            this.rad9amBook.TabStop = true;
            this.rad9amBook.Text = "9am (N-S)";
            this.rad9amBook.UseVisualStyleBackColor = false;
            // 
            // rad10amBook
            // 
            this.rad10amBook.AutoSize = true;
            this.rad10amBook.BackColor = System.Drawing.Color.Transparent;
            this.rad10amBook.Location = new System.Drawing.Point(9, 49);
            this.rad10amBook.Name = "rad10amBook";
            this.rad10amBook.Size = new System.Drawing.Size(83, 18);
            this.rad10amBook.TabIndex = 3;
            this.rad10amBook.TabStop = true;
            this.rad10amBook.Text = "10am (S-N)";
            this.rad10amBook.UseVisualStyleBackColor = false;
            // 
            // btnWriteStream
            // 
            this.btnWriteStream.Location = new System.Drawing.Point(562, 319);
            this.btnWriteStream.Name = "btnWriteStream";
            this.btnWriteStream.Size = new System.Drawing.Size(66, 23);
            this.btnWriteStream.TabIndex = 9;
            this.btnWriteStream.Text = "Save";
            this.btnWriteStream.UseVisualStyleBackColor = true;
            this.btnWriteStream.Click += new System.EventHandler(this.btnWriteStream_Click);
            // 
            // radCar
            // 
            this.radCar.AutoSize = true;
            this.radCar.BackColor = System.Drawing.Color.Transparent;
            this.radCar.Location = new System.Drawing.Point(16, 15);
            this.radCar.Name = "radCar";
            this.radCar.Size = new System.Drawing.Size(44, 18);
            this.radCar.TabIndex = 6;
            this.radCar.TabStop = true;
            this.radCar.Text = "Car";
            this.radCar.UseVisualStyleBackColor = false;
            // 
            // radVan
            // 
            this.radVan.AutoSize = true;
            this.radVan.BackColor = System.Drawing.Color.Transparent;
            this.radVan.Location = new System.Drawing.Point(16, 38);
            this.radVan.Name = "radVan";
            this.radVan.Size = new System.Drawing.Size(45, 18);
            this.radVan.TabIndex = 7;
            this.radVan.TabStop = true;
            this.radVan.Text = "Van";
            this.radVan.UseVisualStyleBackColor = false;
            // 
            // radLargeVehicle
            // 
            this.radLargeVehicle.AutoSize = true;
            this.radLargeVehicle.BackColor = System.Drawing.Color.Transparent;
            this.radLargeVehicle.Location = new System.Drawing.Point(16, 61);
            this.radLargeVehicle.Name = "radLargeVehicle";
            this.radLargeVehicle.Size = new System.Drawing.Size(105, 18);
            this.radLargeVehicle.TabIndex = 8;
            this.radLargeVehicle.TabStop = true;
            this.radLargeVehicle.Text = "Larger Vehicle";
            this.radLargeVehicle.UseVisualStyleBackColor = false;
            // 
            // grpDirection
            // 
            this.grpDirection.BackColor = System.Drawing.Color.Transparent;
            this.grpDirection.Controls.Add(this.rad5pmBook);
            this.grpDirection.Controls.Add(this.rad4pmBook);
            this.grpDirection.Controls.Add(this.rad10amBook);
            this.grpDirection.Controls.Add(this.rad9amBook);
            this.grpDirection.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDirection.Location = new System.Drawing.Point(12, 212);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(142, 131);
            this.grpDirection.TabIndex = 30;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Choose Direction";
            // 
            // rad5pmBook
            // 
            this.rad5pmBook.AutoSize = true;
            this.rad5pmBook.BackColor = System.Drawing.Color.Transparent;
            this.rad5pmBook.Location = new System.Drawing.Point(9, 97);
            this.rad5pmBook.Name = "rad5pmBook";
            this.rad5pmBook.Size = new System.Drawing.Size(78, 18);
            this.rad5pmBook.TabIndex = 5;
            this.rad5pmBook.TabStop = true;
            this.rad5pmBook.Text = "5pm (S-N)";
            this.rad5pmBook.UseVisualStyleBackColor = false;
            // 
            // rad4pmBook
            // 
            this.rad4pmBook.AutoSize = true;
            this.rad4pmBook.BackColor = System.Drawing.Color.Transparent;
            this.rad4pmBook.Location = new System.Drawing.Point(9, 73);
            this.rad4pmBook.Name = "rad4pmBook";
            this.rad4pmBook.Size = new System.Drawing.Size(78, 18);
            this.rad4pmBook.TabIndex = 4;
            this.rad4pmBook.TabStop = true;
            this.rad4pmBook.Text = "4pm (N-S)";
            this.rad4pmBook.UseVisualStyleBackColor = false;
            // 
            // grpVehicle
            // 
            this.grpVehicle.BackColor = System.Drawing.Color.Transparent;
            this.grpVehicle.Controls.Add(this.radVan);
            this.grpVehicle.Controls.Add(this.radCar);
            this.grpVehicle.Controls.Add(this.radLargeVehicle);
            this.grpVehicle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVehicle.Location = new System.Drawing.Point(139, 212);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(141, 95);
            this.grpVehicle.TabIndex = 31;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Choose Vehicle Type";
            // 
            // btnResetBook
            // 
            this.btnResetBook.Location = new System.Drawing.Point(634, 319);
            this.btnResetBook.Name = "btnResetBook";
            this.btnResetBook.Size = new System.Drawing.Size(66, 23);
            this.btnResetBook.TabIndex = 10;
            this.btnResetBook.Text = "Reset";
            this.btnResetBook.UseVisualStyleBackColor = true;
            this.btnResetBook.Click += new System.EventHandler(this.btnResetBook_Click);
            // 
            // NewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.btnResetBook);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.grpDirection);
            this.Controls.Add(this.btnWriteStream);
            this.Controls.Add(this.txtLicenseBook);
            this.Controls.Add(this.lblLicenseBooking);
            this.Controls.Add(this.lblBookInstruct);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblNameBooking);
            this.Controls.Add(this.btnBookHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 393);
            this.MinimumSize = new System.Drawing.Size(800, 393);
            this.Name = "NewBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SailSafe - Book a Guest";
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicenseBook;
        private System.Windows.Forms.Label lblLicenseBooking;
        private System.Windows.Forms.Label lblBookInstruct;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblNameBooking;
        private System.Windows.Forms.Button btnBookHome;
        private System.Windows.Forms.RadioButton rad9amBook;
        private System.Windows.Forms.RadioButton rad10amBook;
        private System.Windows.Forms.Button btnWriteStream;
        private System.Windows.Forms.RadioButton radCar;
        private System.Windows.Forms.RadioButton radVan;
        private System.Windows.Forms.RadioButton radLargeVehicle;
        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.RadioButton rad5pmBook;
        private System.Windows.Forms.RadioButton rad4pmBook;
        private System.Windows.Forms.Button btnResetBook;
    }
}