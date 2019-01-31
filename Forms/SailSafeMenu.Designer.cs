namespace SailSafe___1413042
{
    partial class SailSafeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SailSafeMenu));
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnLocateBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnViewSailings = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAuthorInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.btnMenuLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(12, 16);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(100, 77);
            this.btnCreateBooking.TabIndex = 0;
            this.btnCreateBooking.Text = "Create New Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLocateBooking
            // 
            this.btnLocateBooking.Location = new System.Drawing.Point(12, 99);
            this.btnLocateBooking.Name = "btnLocateBooking";
            this.btnLocateBooking.Size = new System.Drawing.Size(100, 77);
            this.btnLocateBooking.TabIndex = 1;
            this.btnLocateBooking.Text = "Locate Current Booking";
            this.btnLocateBooking.UseVisualStyleBackColor = true;
            this.btnLocateBooking.Click += new System.EventHandler(this.btnLocateBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(12, 182);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(100, 77);
            this.btnEditBooking.TabIndex = 2;
            this.btnEditBooking.Text = "Remove Current Booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnViewSailings
            // 
            this.btnViewSailings.Location = new System.Drawing.Point(12, 265);
            this.btnViewSailings.Name = "btnViewSailings";
            this.btnViewSailings.Size = new System.Drawing.Size(100, 77);
            this.btnViewSailings.TabIndex = 3;
            this.btnViewSailings.Text = "View Sailings";
            this.btnViewSailings.UseVisualStyleBackColor = true;
            this.btnViewSailings.Click += new System.EventHandler(this.btnViewSailings_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(278, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 22);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to SailSafe!";
            // 
            // lblAuthorInfo
            // 
            this.lblAuthorInfo.AutoSize = true;
            this.lblAuthorInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorInfo.Location = new System.Drawing.Point(292, 76);
            this.lblAuthorInfo.Name = "lblAuthorInfo";
            this.lblAuthorInfo.Size = new System.Drawing.Size(115, 14);
            this.lblAuthorInfo.TabIndex = 5;
            this.lblAuthorInfo.Text = "Author Information:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(340, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 14);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Alex Boggis";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.BackColor = System.Drawing.Color.Transparent;
            this.lblSID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSID.Location = new System.Drawing.Point(340, 120);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(71, 14);
            this.lblSID.TabIndex = 7;
            this.lblSID.Text = "SiD: 1413042";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAppVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.Location = new System.Drawing.Point(340, 140);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(65, 14);
            this.lblAppVersion.TabIndex = 8;
            this.lblAppVersion.Text = "Version: 2.3";
            // 
            // btnMenuLogOut
            // 
            this.btnMenuLogOut.Location = new System.Drawing.Point(598, 319);
            this.btnMenuLogOut.Name = "btnMenuLogOut";
            this.btnMenuLogOut.Size = new System.Drawing.Size(66, 23);
            this.btnMenuLogOut.TabIndex = 9;
            this.btnMenuLogOut.Text = "Log Out";
            this.btnMenuLogOut.UseVisualStyleBackColor = true;
            this.btnMenuLogOut.Click += new System.EventHandler(this.btnMenuLogOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SailSafeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenuLogOut);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAuthorInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnViewSailings);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnLocateBooking);
            this.Controls.Add(this.btnCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 393);
            this.MinimumSize = new System.Drawing.Size(800, 393);
            this.Name = "SailSafeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SailSafe - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnLocateBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnViewSailings;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAuthorInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Button btnMenuLogOut;
        private System.Windows.Forms.Button button1;
    }
}

