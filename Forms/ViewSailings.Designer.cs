namespace SailSafe___1413042
{
    partial class ViewSailings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSailings));
            this.lblLaneOne = new System.Windows.Forms.Label();
            this.lblViewInstruct = new System.Windows.Forms.Label();
            this.btnViewHome = new System.Windows.Forms.Button();
            this.txtListView = new System.Windows.Forms.TextBox();
            this.btnDisplayTxt = new System.Windows.Forms.Button();
            this.btnViewAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLaneOne
            // 
            this.lblLaneOne.AutoSize = true;
            this.lblLaneOne.BackColor = System.Drawing.Color.Transparent;
            this.lblLaneOne.Location = new System.Drawing.Point(12, 74);
            this.lblLaneOne.Name = "lblLaneOne";
            this.lblLaneOne.Size = new System.Drawing.Size(447, 13);
            this.lblLaneOne.TabIndex = 5;
            this.lblLaneOne.Text = "Format: Date and Time, Guest Name, License Plate, Sailing Time and Direction, Veh" +
    "icle Type";
            // 
            // lblViewInstruct
            // 
            this.lblViewInstruct.AutoSize = true;
            this.lblViewInstruct.BackColor = System.Drawing.Color.Transparent;
            this.lblViewInstruct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInstruct.ForeColor = System.Drawing.Color.Black;
            this.lblViewInstruct.Location = new System.Drawing.Point(312, 9);
            this.lblViewInstruct.Name = "lblViewInstruct";
            this.lblViewInstruct.Size = new System.Drawing.Size(164, 19);
            this.lblViewInstruct.TabIndex = 21;
            this.lblViewInstruct.Text = "All Current Guests:";
            // 
            // btnViewHome
            // 
            this.btnViewHome.Location = new System.Drawing.Point(706, 427);
            this.btnViewHome.Name = "btnViewHome";
            this.btnViewHome.Size = new System.Drawing.Size(66, 23);
            this.btnViewHome.TabIndex = 1;
            this.btnViewHome.Text = "Home";
            this.btnViewHome.UseVisualStyleBackColor = true;
            this.btnViewHome.Click += new System.EventHandler(this.btnMenuLogOut_Click);
            // 
            // txtListView
            // 
            this.txtListView.Location = new System.Drawing.Point(12, 90);
            this.txtListView.Multiline = true;
            this.txtListView.Name = "txtListView";
            this.txtListView.ReadOnly = true;
            this.txtListView.Size = new System.Drawing.Size(760, 331);
            this.txtListView.TabIndex = 23;
            // 
            // btnDisplayTxt
            // 
            this.btnDisplayTxt.Location = new System.Drawing.Point(551, 427);
            this.btnDisplayTxt.Name = "btnDisplayTxt";
            this.btnDisplayTxt.Size = new System.Drawing.Size(66, 23);
            this.btnDisplayTxt.TabIndex = 0;
            this.btnDisplayTxt.Text = "Display";
            this.btnDisplayTxt.UseVisualStyleBackColor = true;
            this.btnDisplayTxt.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // btnViewAddBook
            // 
            this.btnViewAddBook.Location = new System.Drawing.Point(623, 427);
            this.btnViewAddBook.Name = "btnViewAddBook";
            this.btnViewAddBook.Size = new System.Drawing.Size(77, 23);
            this.btnViewAddBook.TabIndex = 24;
            this.btnViewAddBook.Text = "Add Booking";
            this.btnViewAddBook.UseVisualStyleBackColor = true;
            this.btnViewAddBook.Click += new System.EventHandler(this.btnViewAddBook_Click);
            // 
            // ViewSailings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnViewAddBook);
            this.Controls.Add(this.btnDisplayTxt);
            this.Controls.Add(this.txtListView);
            this.Controls.Add(this.btnViewHome);
            this.Controls.Add(this.lblViewInstruct);
            this.Controls.Add(this.lblLaneOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ViewSailings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SailSafe - View Sailings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLaneOne;
        private System.Windows.Forms.Label lblViewInstruct;
        private System.Windows.Forms.Button btnViewHome;
        private System.Windows.Forms.TextBox txtListView;
        private System.Windows.Forms.Button btnDisplayTxt;
        private System.Windows.Forms.Button btnViewAddBook;
    }
}