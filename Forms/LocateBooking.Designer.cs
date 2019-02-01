namespace SailSafe
{
    partial class LocateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocateBooking));
            this.txtPlateLocate = new System.Windows.Forms.TextBox();
            this.lblPlateLocate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameLocate = new System.Windows.Forms.TextBox();
            this.lblNameLocate = new System.Windows.Forms.Label();
            this.btnLocateHome = new System.Windows.Forms.Button();
            this.btnLocateSearch = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtDisplayPlate = new System.Windows.Forms.TextBox();
            this.txtDisplaySailing = new System.Windows.Forms.TextBox();
            this.txtDisplayVehicle = new System.Windows.Forms.TextBox();
            this.txtDisplayDate = new System.Windows.Forms.TextBox();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlateLocate
            // 
            this.txtPlateLocate.Location = new System.Drawing.Point(12, 108);
            this.txtPlateLocate.Name = "txtPlateLocate";
            this.txtPlateLocate.Size = new System.Drawing.Size(202, 20);
            this.txtPlateLocate.TabIndex = 1;
            this.txtPlateLocate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateLocate_KeyPress);
            // 
            // lblPlateLocate
            // 
            this.lblPlateLocate.AutoSize = true;
            this.lblPlateLocate.BackColor = System.Drawing.Color.Transparent;
            this.lblPlateLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateLocate.ForeColor = System.Drawing.Color.Black;
            this.lblPlateLocate.Location = new System.Drawing.Point(9, 92);
            this.lblPlateLocate.Name = "lblPlateLocate";
            this.lblPlateLocate.Size = new System.Drawing.Size(88, 13);
            this.lblPlateLocate.TabIndex = 21;
            this.lblPlateLocate.Text = "License Plate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(218, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Please Enter the Details Required Below";
            // 
            // txtNameLocate
            // 
            this.txtNameLocate.Location = new System.Drawing.Point(12, 53);
            this.txtNameLocate.Name = "txtNameLocate";
            this.txtNameLocate.Size = new System.Drawing.Size(202, 20);
            this.txtNameLocate.TabIndex = 0;
            // 
            // lblNameLocate
            // 
            this.lblNameLocate.AutoSize = true;
            this.lblNameLocate.BackColor = System.Drawing.Color.Transparent;
            this.lblNameLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLocate.ForeColor = System.Drawing.Color.Black;
            this.lblNameLocate.Location = new System.Drawing.Point(9, 37);
            this.lblNameLocate.Name = "lblNameLocate";
            this.lblNameLocate.Size = new System.Drawing.Size(67, 13);
            this.lblNameLocate.TabIndex = 18;
            this.lblNameLocate.Text = "Full Name:";
            // 
            // btnLocateHome
            // 
            this.btnLocateHome.Location = new System.Drawing.Point(706, 321);
            this.btnLocateHome.Name = "btnLocateHome";
            this.btnLocateHome.Size = new System.Drawing.Size(66, 22);
            this.btnLocateHome.TabIndex = 3;
            this.btnLocateHome.Text = "Home";
            this.btnLocateHome.UseVisualStyleBackColor = true;
            this.btnLocateHome.Click += new System.EventHandler(this.btnLocateHome_Click);
            // 
            // btnLocateSearch
            // 
            this.btnLocateSearch.Location = new System.Drawing.Point(565, 321);
            this.btnLocateSearch.Name = "btnLocateSearch";
            this.btnLocateSearch.Size = new System.Drawing.Size(66, 22);
            this.btnLocateSearch.TabIndex = 2;
            this.btnLocateSearch.Text = "Search";
            this.btnLocateSearch.UseVisualStyleBackColor = true;
            this.btnLocateSearch.Click += new System.EventHandler(this.btnLocateSearch_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(12, 188);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.ReadOnly = true;
            this.txtDisplayName.Size = new System.Drawing.Size(760, 20);
            this.txtDisplayName.TabIndex = 26;
            // 
            // txtDisplayPlate
            // 
            this.txtDisplayPlate.Location = new System.Drawing.Point(12, 214);
            this.txtDisplayPlate.Name = "txtDisplayPlate";
            this.txtDisplayPlate.ReadOnly = true;
            this.txtDisplayPlate.Size = new System.Drawing.Size(760, 20);
            this.txtDisplayPlate.TabIndex = 27;
            // 
            // txtDisplaySailing
            // 
            this.txtDisplaySailing.Location = new System.Drawing.Point(12, 240);
            this.txtDisplaySailing.Name = "txtDisplaySailing";
            this.txtDisplaySailing.ReadOnly = true;
            this.txtDisplaySailing.Size = new System.Drawing.Size(760, 20);
            this.txtDisplaySailing.TabIndex = 28;
            // 
            // txtDisplayVehicle
            // 
            this.txtDisplayVehicle.Location = new System.Drawing.Point(12, 266);
            this.txtDisplayVehicle.Name = "txtDisplayVehicle";
            this.txtDisplayVehicle.ReadOnly = true;
            this.txtDisplayVehicle.Size = new System.Drawing.Size(760, 20);
            this.txtDisplayVehicle.TabIndex = 29;
            // 
            // txtDisplayDate
            // 
            this.txtDisplayDate.Location = new System.Drawing.Point(12, 162);
            this.txtDisplayDate.Name = "txtDisplayDate";
            this.txtDisplayDate.ReadOnly = true;
            this.txtDisplayDate.Size = new System.Drawing.Size(760, 20);
            this.txtDisplayDate.TabIndex = 30;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(637, 321);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(66, 22);
            this.btnResetSearch.TabIndex = 31;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.txtDisplayDate);
            this.Controls.Add(this.txtDisplayVehicle);
            this.Controls.Add(this.txtDisplaySailing);
            this.Controls.Add(this.txtDisplayPlate);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.btnLocateSearch);
            this.Controls.Add(this.btnLocateHome);
            this.Controls.Add(this.txtPlateLocate);
            this.Controls.Add(this.lblPlateLocate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameLocate);
            this.Controls.Add(this.lblNameLocate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 393);
            this.MinimumSize = new System.Drawing.Size(800, 393);
            this.Name = "LocateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SailSafe - Locate a Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlateLocate;
        private System.Windows.Forms.Label lblPlateLocate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameLocate;
        private System.Windows.Forms.Label lblNameLocate;
        private System.Windows.Forms.Button btnLocateHome;
        private System.Windows.Forms.Button btnLocateSearch;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtDisplayPlate;
        private System.Windows.Forms.TextBox txtDisplaySailing;
        private System.Windows.Forms.TextBox txtDisplayVehicle;
        private System.Windows.Forms.TextBox txtDisplayDate;
        private System.Windows.Forms.Button btnResetSearch;
    }
}