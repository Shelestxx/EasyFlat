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
            lblTitle.Location = new Point(93, 41);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(94, 80);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "label1";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(95, 116);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(50, 20);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "label1";
            // 
            // lblRentPrice
            // 
            lblRentPrice.AutoSize = true;
            lblRentPrice.Location = new Point(93, 158);
            lblRentPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentPrice.Name = "lblRentPrice";
            lblRentPrice.Size = new Size(50, 20);
            lblRentPrice.TabIndex = 3;
            lblRentPrice.Text = "label1";
            // 
            // lblRoomCount
            // 
            lblRoomCount.AutoSize = true;
            lblRoomCount.Location = new Point(94, 202);
            lblRoomCount.Margin = new Padding(2, 0, 2, 0);
            lblRoomCount.Name = "lblRoomCount";
            lblRoomCount.Size = new Size(50, 20);
            lblRoomCount.TabIndex = 4;
            lblRoomCount.Text = "label1";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(95, 242);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(50, 20);
            lblArea.TabIndex = 5;
            lblArea.Text = "label1";
            // 
            // lblOwnerID
            // 
            lblOwnerID.AutoSize = true;
            lblOwnerID.Location = new Point(94, 276);
            lblOwnerID.Margin = new Padding(2, 0, 2, 0);
            lblOwnerID.Name = "lblOwnerID";
            lblOwnerID.Size = new Size(50, 20);
            lblOwnerID.TabIndex = 6;
            lblOwnerID.Text = "label1";
            // 
            // lblPublishDate
            // 
            lblPublishDate.AutoSize = true;
            lblPublishDate.Location = new Point(94, 325);
            lblPublishDate.Margin = new Padding(2, 0, 2, 0);
            lblPublishDate.Name = "lblPublishDate";
            lblPublishDate.Size = new Size(50, 20);
            lblPublishDate.TabIndex = 7;
            lblPublishDate.Text = "label1";
            // 
            // ApartmentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(lblPublishDate);
            Controls.Add(lblOwnerID);
            Controls.Add(lblArea);
            Controls.Add(lblRoomCount);
            Controls.Add(lblRentPrice);
            Controls.Add(lblLocation);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Margin = new Padding(2, 2, 2, 2);
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