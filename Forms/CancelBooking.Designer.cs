namespace SailSafe
{
    partial class CancelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelBooking));
            this.txtPlateRemove = new System.Windows.Forms.TextBox();
            this.lblPlateLocate = new System.Windows.Forms.Label();
            this.txtNameRemove = new System.Windows.Forms.TextBox();
            this.lblNameLocate = new System.Windows.Forms.Label();
            this.btnEditHome = new System.Windows.Forms.Button();
            this.btnRemoveBooking = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBookInstruct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlateRemove
            // 
            this.txtPlateRemove.Location = new System.Drawing.Point(15, 99);
            this.txtPlateRemove.Name = "txtPlateRemove";
            this.txtPlateRemove.Size = new System.Drawing.Size(202, 20);
            this.txtPlateRemove.TabIndex = 27;
            // 
            // lblPlateLocate
            // 
            this.lblPlateLocate.AutoSize = true;
            this.lblPlateLocate.BackColor = System.Drawing.Color.Transparent;
            this.lblPlateLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateLocate.ForeColor = System.Drawing.Color.Black;
            this.lblPlateLocate.Location = new System.Drawing.Point(12, 83);
            this.lblPlateLocate.Name = "lblPlateLocate";
            this.lblPlateLocate.Size = new System.Drawing.Size(88, 13);
            this.lblPlateLocate.TabIndex = 26;
            this.lblPlateLocate.Text = "License Plate:";
            // 
            // txtNameRemove
            // 
            this.txtNameRemove.Location = new System.Drawing.Point(15, 60);
            this.txtNameRemove.Name = "txtNameRemove";
            this.txtNameRemove.Size = new System.Drawing.Size(202, 20);
            this.txtNameRemove.TabIndex = 25;
            // 
            // lblNameLocate
            // 
            this.lblNameLocate.AutoSize = true;
            this.lblNameLocate.BackColor = System.Drawing.Color.Transparent;
            this.lblNameLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLocate.ForeColor = System.Drawing.Color.Black;
            this.lblNameLocate.Location = new System.Drawing.Point(12, 44);
            this.lblNameLocate.Name = "lblNameLocate";
            this.lblNameLocate.Size = new System.Drawing.Size(67, 13);
            this.lblNameLocate.TabIndex = 24;
            this.lblNameLocate.Text = "Full Name:";
            // 
            // btnEditHome
            // 
            this.btnEditHome.Location = new System.Drawing.Point(709, 320);
            this.btnEditHome.Name = "btnEditHome";
            this.btnEditHome.Size = new System.Drawing.Size(66, 23);
            this.btnEditHome.TabIndex = 29;
            this.btnEditHome.Text = "Home";
            this.btnEditHome.UseVisualStyleBackColor = true;
            this.btnEditHome.Click += new System.EventHandler(this.btnEditHome_Click);
            // 
            // btnRemoveBooking
            // 
            this.btnRemoveBooking.Location = new System.Drawing.Point(637, 320);
            this.btnRemoveBooking.Name = "btnRemoveBooking";
            this.btnRemoveBooking.Size = new System.Drawing.Size(66, 23);
            this.btnRemoveBooking.TabIndex = 30;
            this.btnRemoveBooking.Text = "Remove";
            this.btnRemoveBooking.UseVisualStyleBackColor = true;
            this.btnRemoveBooking.Click += new System.EventHandler(this.btnRemoveBooking_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "Success!";
            // 
            // lblBookInstruct
            // 
            this.lblBookInstruct.AutoSize = true;
            this.lblBookInstruct.BackColor = System.Drawing.Color.Transparent;
            this.lblBookInstruct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookInstruct.Location = new System.Drawing.Point(218, 9);
            this.lblBookInstruct.Name = "lblBookInstruct";
            this.lblBookInstruct.Size = new System.Drawing.Size(340, 19);
            this.lblBookInstruct.TabIndex = 32;
            this.lblBookInstruct.Text = "Please Enter the Details Required Below";
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.lblBookInstruct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemoveBooking);
            this.Controls.Add(this.btnEditHome);
            this.Controls.Add(this.txtPlateRemove);
            this.Controls.Add(this.lblPlateLocate);
            this.Controls.Add(this.txtNameRemove);
            this.Controls.Add(this.lblNameLocate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CancelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlateRemove;
        private System.Windows.Forms.Label lblPlateLocate;
        private System.Windows.Forms.TextBox txtNameRemove;
        private System.Windows.Forms.Label lblNameLocate;
        private System.Windows.Forms.Button btnEditHome;
        private System.Windows.Forms.Button btnRemoveBooking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBookInstruct;
    }
}