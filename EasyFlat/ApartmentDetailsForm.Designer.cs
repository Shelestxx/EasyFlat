namespace EasyFlat
{
    partial class ApartmentDetailsForm
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
            lblTitle = new Label();
            lblDescription = new Label();
            lblLocation = new Label();
            lblRentPrice = new Label();
            lblRoomCount = new Label();
            lblArea = new Label();
            lblOwnerID = new Label();
            lblPublishDate = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(116, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(117, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(59, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "label1";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(119, 145);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(59, 25);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "label1";
            // 
            // lblRentPrice
            // 
            lblRentPrice.AutoSize = true;
            lblRentPrice.Location = new Point(116, 198);
            lblRentPrice.Name = "lblRentPrice";
            lblRentPrice.Size = new Size(59, 25);
            lblRentPrice.TabIndex = 3;
            lblRentPrice.Text = "label1";
            // 
            // lblRoomCount
            // 
            lblRoomCount.AutoSize = true;
            lblRoomCount.Location = new Point(117, 253);
            lblRoomCount.Name = "lblRoomCount";
            lblRoomCount.Size = new Size(59, 25);
            lblRoomCount.TabIndex = 4;
            lblRoomCount.Text = "label1";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(119, 302);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(59, 25);
            lblArea.TabIndex = 5;
            lblArea.Text = "label1";
            // 
            // lblOwnerID
            // 
            lblOwnerID.AutoSize = true;
            lblOwnerID.Location = new Point(118, 345);
            lblOwnerID.Name = "lblOwnerID";
            lblOwnerID.Size = new Size(59, 25);
            lblOwnerID.TabIndex = 6;
            lblOwnerID.Text = "label1";
            // 
            // lblPublishDate
            // 
            lblPublishDate.AutoSize = true;
            lblPublishDate.Location = new Point(118, 406);
            lblPublishDate.Name = "lblPublishDate";
            lblPublishDate.Size = new Size(59, 25);
            lblPublishDate.TabIndex = 7;
            lblPublishDate.Text = "label1";
            // 
            // ApartmentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(lblPublishDate);
            Controls.Add(lblOwnerID);
            Controls.Add(lblArea);
            Controls.Add(lblRoomCount);
            Controls.Add(lblRentPrice);
            Controls.Add(lblLocation);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "ApartmentDetailsForm";
            Text = "ApartmentDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblLocation;
        private Label lblRentPrice;
        private Label lblRoomCount;
        private Label lblArea;
        private Label lblOwnerID;
        private Label lblPublishDate;
    }
}